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
    public partial class FrmAddEditClient : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["RecordKeepingConnection"].ConnectionString;
        private int? clientId;
        private SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
        public FrmAddEditClient()
        {
            InitializeComponent();
            LoadCreatedByUsers();
        }

        // Constructor for editing an existing client
        public FrmAddEditClient(int clientId) : this() // Call the default constructor
        {
            this.clientId = clientId;
            LoadClientData(clientId); // Load the client data for editing
        }
        private void LoadClientData(int clientId)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = "SELECT FullName, ContactNumber, Address, DateOfBirth, CreatedBy FROM Clients WHERE ClientID = @ClientID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ClientID", clientId);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtFullName.Text = reader["FullName"].ToString();
                    txtContactNumber.Text = reader["ContactNumber"].ToString();
                    txtAddress.Text = reader["Address"].ToString();
                    dtpDateOfBirth.Value = Convert.ToDateTime(reader["DateOfBirth"]);
                    cmbCreatedBy.SelectedValue = reader["CreatedBy"];
                }
            }
        }

        private void LoadCreatedByUsers()
        {
            using (SqlConnection conn = GetConnection())
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string query;

                if (clientId.HasValue) // Update existing client
                {
                    query = "UPDATE Clients SET FullName = @FullName, ContactNumber = @ContactNumber, Address = @Address, DateOfBirth = @DateOfBirth, CreatedBy = @CreatedBy WHERE ClientID = @ClientID";
                }
                else // Add new client
                {
                    query = "INSERT INTO Clients (FullName, ContactNumber, Address, DateOfBirth, CreatedBy) VALUES (@FullName, @ContactNumber, @Address, @DateOfBirth, @CreatedBy)";
                }

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                cmd.Parameters.AddWithValue("@ContactNumber", txtContactNumber.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@DateOfBirth", dtpDateOfBirth.Value);
                cmd.Parameters.AddWithValue("@CreatedBy", cmbCreatedBy.SelectedValue);

                if (clientId.HasValue)
                    cmd.Parameters.AddWithValue("@ClientID", clientId);

                cmd.ExecuteNonQuery();
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
