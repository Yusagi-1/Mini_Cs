using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Configuration;
namespace Mini_Cs
{
    public partial class FrmAddEditTransaction : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["RecordKeepingConnection"].ConnectionString;
        private int? transactionId;
        private DataTable clientsTable;
        private DataTable servicesTable;

        public FrmAddEditTransaction()
        {
            InitializeComponent();
            cmbClient.DropDownStyle = ComboBoxStyle.DropDown;
            cmbService.DropDownStyle = ComboBoxStyle.DropDown;
            LoadClients();
            LoadServices();
            LoadCreatedByUsers();
            txtAmount.ReadOnly = true;
            UpdateAmount();
        }
        public FrmAddEditTransaction(int transactionId) : this()
        {
            this.transactionId = transactionId;
            LoadTransactionData(transactionId);
        }
        private void FrmAddEditTransaction_Load(object sender, EventArgs e)
        {
            txtDiscount.TextChanged += (s, e) => UpdateAmount();
        }


        private void LoadClients()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT ClientID, FullName FROM Clients";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                clientsTable = new DataTable();
                adapter.Fill(clientsTable);

                cmbClient.DataSource = clientsTable;
                cmbClient.DisplayMember = "FullName";
                cmbClient.ValueMember = "ClientID";

                AutoCompleteStringCollection clientAutoCompleteCollection = new AutoCompleteStringCollection();
                foreach (DataRow row in clientsTable.Rows)
                {
                    clientAutoCompleteCollection.Add(row["FullName"].ToString());
                }

                cmbClient.AutoCompleteCustomSource = clientAutoCompleteCollection;
                cmbClient.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbClient.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
        }


        private void LoadServices()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT ServiceID, ServiceName, Price FROM Services";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                servicesTable = new DataTable();
                adapter.Fill(servicesTable);

                cmbService.DataSource = servicesTable;
                cmbService.DisplayMember = "ServiceName";
                cmbService.ValueMember = "ServiceID";

                cmbService.SelectedIndexChanged += (s, e) => UpdateAmount();
            }
        }



        private void LoadCreatedByUsers()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT UserID, Username FROM Users";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable usersTable = new DataTable();
                adapter.Fill(usersTable);
                cmbCreatedBy.DataSource = usersTable;
                cmbCreatedBy.DisplayMember = "Username";
                cmbCreatedBy.ValueMember = "UserID";
            }
        }
        private void LoadTransactionData(int transactionId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT ClientID, ServiceID, TransactionDate, Amount, Notes, CreatedBy, Discount FROM Transactions WHERE TransactionID = @TransactionID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TransactionID", transactionId);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    cmbClient.SelectedValue = reader["ClientID"];
                    cmbService.SelectedValue = reader["ServiceID"];
                    dtpTransactionDate.Value = Convert.ToDateTime(reader["TransactionDate"]);
                    txtAmount.Text = reader["Amount"].ToString();
                    txtNotes.Text = reader["Notes"].ToString();
                    cmbCreatedBy.SelectedValue = reader["CreatedBy"];
                    txtDiscount.Text = reader["Discount"].ToString();
                }
            }
        }
        private void UpdateAmount()
        {
            if (cmbService.SelectedValue == null)
            {
                MessageBox.Show("Please select a valid service.");
                return;
            }

            int serviceId = Convert.ToInt32(cmbService.SelectedValue);
            decimal servicePrice = GetServicePrice(serviceId);

            if (servicePrice == 0)
            {
                MessageBox.Show("Service price is not available.");
                return;
            }

            decimal discount = 0m;

            if (decimal.TryParse(txtDiscount.Text, out discount))
            {
                discount = Math.Max(discount, 0); // Ensure non-negative discount
            }

            decimal amount = servicePrice - discount;
            if (amount < 0) amount = 0m;

            txtAmount.Text = amount.ToString("C2", new System.Globalization.CultureInfo("es-MX"));
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query;

                decimal servicePrice = GetServicePrice(Convert.ToInt32(cmbService.SelectedValue));
                decimal discount = 0m;

                if (decimal.TryParse(txtDiscount.Text, out discount))
                {
                    discount = Math.Max(discount, 0);
                }

                decimal amount = servicePrice - discount;
                if (amount < 0) amount = 0m;

                if (transactionId.HasValue)
                {
                    query = "UPDATE Transactions SET ClientID = @ClientID, ServiceID = @ServiceID, TransactionDate = @TransactionDate, Amount = @Amount, Notes = @Notes, CreatedBy = @CreatedBy, Discount = @Discount WHERE TransactionID = @TransactionID";
                }
                else
                {
                    query = "INSERT INTO Transactions (ClientID, ServiceID, TransactionDate, Amount, Notes, CreatedBy, Discount) VALUES (@ClientID, @ServiceID, @TransactionDate, @Amount, @Notes, @CreatedBy, @Discount)";
                }

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ClientID", cmbClient.SelectedValue);
                cmd.Parameters.AddWithValue("@ServiceID", cmbService.SelectedValue);
                cmd.Parameters.AddWithValue("@TransactionDate", dtpTransactionDate.Value);
                cmd.Parameters.AddWithValue("@Amount", amount);
                cmd.Parameters.AddWithValue("@Notes", txtNotes.Text);
                cmd.Parameters.AddWithValue("@CreatedBy", cmbCreatedBy.SelectedValue);
                cmd.Parameters.AddWithValue("@Discount", discount);

                if (transactionId.HasValue)
                    cmd.Parameters.AddWithValue("@TransactionID", transactionId);

                cmd.ExecuteNonQuery();
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        private decimal GetServicePrice(int serviceId)
        {
            decimal price = 0m;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Price FROM Services WHERE ServiceID = @ServiceID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ServiceID", serviceId);
                conn.Open();

                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    price = Convert.ToDecimal(result);
                }
            }

            return price;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbService_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
