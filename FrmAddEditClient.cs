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


        public FrmAddEditClient(int clientId) : this()
        {
            this.clientId = clientId;
            LoadClientData(clientId);
        }
        private void LoadClientData(int clientId)
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    string query = "SELECT FullName, ContactNumber, Address, Email, Notes, CreatedBy FROM Clients WHERE ClientID = @ClientID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ClientID", clientId);
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtFullName.Text = reader["FullName"].ToString();
                        txtContactNumber.Text = reader["ContactNumber"].ToString();
                        txtAddress.Text = reader["Address"].ToString();
                        txtEmail.Text = reader["Email"].ToString();  // Load Email
                        txtNotes.Text = reader["Notes"].ToString();  // Load Notes

                        cmbCreatedBy.SelectedValue = reader["CreatedBy"];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading client data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCreatedByUsers()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    string query;

                    if (clientId.HasValue) // Update existing client
                    {
                        query = "UPDATE Clients SET FullName = @FullName, ContactNumber = @ContactNumber, Address = @Address, Email = @Email, Notes = @Notes, CreatedBy = @CreatedBy WHERE ClientID = @ClientID";
                    }
                    else // Add new client
                    {
                        query = "INSERT INTO Clients (FullName, ContactNumber, Address, Email, Notes, CreatedBy) VALUES (@FullName, @ContactNumber, @Address, @Email, @Notes, @CreatedBy)";
                    }

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                    cmd.Parameters.AddWithValue("@ContactNumber", txtContactNumber.Text);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text); // Add Email parameter
                    cmd.Parameters.AddWithValue("@Notes", txtNotes.Text); // Add Notes parameter

                    cmd.Parameters.AddWithValue("@CreatedBy", cmbCreatedBy.SelectedValue);

                    if (clientId.HasValue)
                        cmd.Parameters.AddWithValue("@ClientID", clientId);

                    cmd.ExecuteNonQuery();
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the client: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFamilyName_Click(object sender, EventArgs e)
        {

        }
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Full name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtContactNumber.Text))
            {
                MessageBox.Show("Contact number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Address is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))  // Validate Email
            {
                MessageBox.Show("Email is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbCreatedBy.SelectedValue == null)
            {
                MessageBox.Show("Created by must be selected.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


        private void txtEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtNotes_Click(object sender, EventArgs e)
        {

        }
    }
}
