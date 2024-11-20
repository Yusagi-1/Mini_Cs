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
    public partial class FrmAddDeceased : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["RecordKeepingConnection"].ConnectionString;
        private int? deceasedId;

        public FrmAddDeceased()
        {
            InitializeComponent();
            LoadCreatedByUsers();
            LoadClientIDs();
            txtFullName.ReadOnly = true;
        }

        public FrmAddDeceased(int deceasedId) : this() // Constructor for editing an existing deceased record
        {
            this.deceasedId = deceasedId;
            LoadDeceasedData(deceasedId); // Load the data for editing
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
        private void LoadFullName(int clientId)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = "SELECT FullName FROM Clients WHERE ClientID = @ClientID"; // Use FullName
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ClientID", clientId);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtFullName.Text = reader["FullName"].ToString(); // Display FullName
                }
            }
        }



        private void LoadDeceasedData(int deceasedId)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = "SELECT DeceasedName, Age, DeathDate, GraveAddress, Notes, CreatedBy, RelationshipToClient FROM Deceased WHERE DeceasedID = @DeceasedID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DeceasedID", deceasedId);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtDeceasedName.Text = reader["DeceasedName"].ToString();
                    txtAge.Text = reader["Age"].ToString();
                    dtpDeathDate.Value = Convert.ToDateTime(reader["DeathDate"]);
                    txtGraveAddress.Text = reader["GraveAddress"].ToString();
                    txtNotes.Text = reader["Notes"].ToString();
                    cmbCreatedBy.SelectedValue = reader["CreatedBy"];
                    cmbRelationship.Text = reader["RelationshipToClient"].ToString(); // Load Relationship
                }
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string query;

                if (deceasedId.HasValue) // Update existing deceased record
                {
                    query = @"UPDATE Deceased 
                      SET DeceasedName = @DeceasedName, Age = @Age, DeathDate = @DeathDate, 
                          GraveAddress = @GraveAddress, Notes = @Notes, CreatedBy = @CreatedBy, 
                          ClientID = @ClientID, RelationshipToClient = @RelationshipToClient
                      WHERE DeceasedID = @DeceasedID";
                }
                else // Add new deceased record
                {
                    query = @"INSERT INTO Deceased (DeceasedName, Age, DeathDate, GraveAddress, Notes, CreatedBy, ClientID, RelationshipToClient) 
                      VALUES (@DeceasedName, @Age, @DeathDate, @GraveAddress, @Notes, @CreatedBy, @ClientID, @RelationshipToClient)";
                }

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DeceasedName", txtDeceasedName.Text);
                cmd.Parameters.AddWithValue("@Age", txtAge.Text);
                cmd.Parameters.AddWithValue("@DeathDate", dtpDeathDate.Value);
                cmd.Parameters.AddWithValue("@GraveAddress", txtGraveAddress.Text);
                cmd.Parameters.AddWithValue("@Notes", txtNotes.Text);
                cmd.Parameters.AddWithValue("@CreatedBy", cmbCreatedBy.SelectedValue);

                // Get ClientID from ComboBox
                if (cmbClientID.SelectedValue != null)
                {
                    cmd.Parameters.AddWithValue("@ClientID", cmbClientID.SelectedValue);
                }
                else
                {
                    MessageBox.Show("Please select a valid ClientID.");
                    return; // Stop execution if no ClientID is selected
                }

                // Add Relationship parameter
                if (!string.IsNullOrEmpty(cmbRelationship.Text))
                {
                    cmd.Parameters.AddWithValue("@RelationshipToClient", cmbRelationship.Text);
                }
                else
                {
                    MessageBox.Show("Please select a valid Relationship.");
                    return; // Stop execution if no Relationship is selected
                }

                if (deceasedId.HasValue)
                {
                    cmd.Parameters.AddWithValue("@DeceasedID", deceasedId);
                }

                cmd.ExecuteNonQuery();
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadCreatedByUsers()
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = "SELECT UserID, Username FROM Users";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable usersTable = new DataTable();
                adapter.Fill(usersTable);

                // Check if there are rows in the DataTable
                if (usersTable.Rows.Count == 0)
                {
                    MessageBox.Show("No users found in the database.");
                }

                cmbCreatedBy.DataSource = usersTable;
                cmbCreatedBy.DisplayMember = "Username";
                cmbCreatedBy.ValueMember = "UserID";
            }
        }

        private void LoadClientIDs()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT ClientID FROM Clients";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable clientsTable = new DataTable();
                adapter.Fill(clientsTable);

                cmbClientID.DataSource = clientsTable;
                cmbClientID.DisplayMember = "ClientID";
                cmbClientID.ValueMember = "ClientID";
                cmbClientID.SelectedIndex = -1; // Ensure no default selection
            }
        }


        private void cmbClientID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClientID.SelectedValue != null)
            {
                if (int.TryParse(cmbClientID.SelectedValue.ToString(), out int clientId))
                {
                    LoadFullName(clientId); // Load full name of the client
                }
            }
        }




        private void cmbRelationship_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtFullName_Click(object sender, EventArgs e)
        {

        }
    }
}
