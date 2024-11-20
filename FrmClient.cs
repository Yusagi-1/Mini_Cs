using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.Data.SqlClient;
namespace Mini_Cs
{
    public partial class FrmClient : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["RecordKeepingConnection"].ConnectionString;

        private SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public FrmClient()
        {
            InitializeComponent();
            LoadClients();
        }
        private void LoadClients()
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    string query = "SELECT ClientID, FullName, ContactNumber, Address, Email, Notes, CreatedBy FROM Clients";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable clientsTable = new DataTable();
                    adapter.Fill(clientsTable);
                    dgvClients.DataSource = clientsTable;

                    // Set column headers for better user readability
                    dgvClients.Columns["ClientID"].HeaderText = "ID";
                    dgvClients.Columns["FullName"].HeaderText = "Full Name";
                    dgvClients.Columns["ContactNumber"].HeaderText = "Contact Number";
                    dgvClients.Columns["Address"].HeaderText = "Address";
                    dgvClients.Columns["Email"].HeaderText = "Email";  // Added Email
                    dgvClients.Columns["Notes"].HeaderText = "Notes";
                    dgvClients.Columns["CreatedBy"].HeaderText = "Created By";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading clients: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearchClient_Click(object sender, EventArgs e)
        {
            try
            {
                string filterText = txtSearchClient.Text;

                if (dgvClients.DataSource is DataTable dataTable)
                {
                    // Use parameterized row filtering
                    dataTable.DefaultView.RowFilter = $"FullName LIKE '%{filterText.Replace("'", "''")}%' OR Address LIKE '%{filterText.Replace("'", "''")}%'"; // Escape single quotes
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            FrmAddEditClient addForm = new FrmAddEditClient();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadClients();
            }
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            if (dgvClients.SelectedRows.Count > 0)
            {
                try
                {
                    int clientId = (int)dgvClients.SelectedRows[0].Cells["ClientID"].Value;

                    FrmAddEditClient editForm = new FrmAddEditClient(clientId);
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadClients();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while editing the client: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a client to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            if (dgvClients.SelectedRows.Count > 0)
            {
                try
                {
                    int clientId = (int)dgvClients.SelectedRows[0].Cells["ClientID"].Value;

                    if (MessageBox.Show("Are you sure you want to delete this client?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        using (SqlConnection conn = GetConnection())
                        {
                            string query = "DELETE FROM Clients WHERE ClientID = @ClientID";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@ClientID", clientId);

                            conn.Open();
                            cmd.ExecuteNonQuery();
                            LoadClients();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while deleting the client: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a client to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
