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
            using (SqlConnection conn = GetConnection())
            {
                string query = "SELECT ClientID, FullName, ContactNumber, Address, DateOfBirth, CreatedBy FROM Clients";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable clientsTable = new DataTable();
                adapter.Fill(clientsTable);
                dgvClients.DataSource = clientsTable;
            }
        }

        private void txtSearchClient_Click(object sender, EventArgs e)
        {
            string filterText = txtSearchClient.Text;
            (dgvClients.DataSource as DataTable).DefaultView.RowFilter = $"FullName LIKE '%{filterText}%' OR Address LIKE '%{filterText}%'";
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
                int clientId = (int)dgvClients.SelectedRows[0].Cells["ClientID"].Value;
                FrmAddEditClient editForm = new FrmAddEditClient(clientId);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadClients();
                }
            }
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            if (dgvClients.SelectedRows.Count > 0)
            {
                int clientId = (int)dgvClients.SelectedRows[0].Cells["ClientID"].Value;

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
    }
}
