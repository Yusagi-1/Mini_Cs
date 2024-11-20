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
    public partial class FrmDeceased : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["RecordKeepingConnection"].ConnectionString;
        private int? deceasedId = null;
        public FrmDeceased()
        {
            InitializeComponent();
            LoadDeceasedData();
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }



        private void LoadDeceasedData()
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = @"
            SELECT 
                D.DeceasedID, 
                D.DeceasedName, 
                D.Age, 
                D.DeathDate, 
                D.GraveAddress, 
                D.Notes,  
                C.FullName AS ClientFullName, 
                D.RelationshipToClient
            FROM 
                Deceased D
            LEFT JOIN 
                Clients C ON D.ClientID = C.ClientID"; // Join with Clients table on ClientID

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable deceasedTable = new DataTable();
                adapter.Fill(deceasedTable);
                dgvDeceased.DataSource = deceasedTable;

                // Optionally format DataGridView
                FormatDeceasedGrid();
            }
        }
        private void FormatDeceasedGrid()
        {
            dgvDeceased.Columns["DeceasedID"].Visible = false; // Hide ID if not needed
            dgvDeceased.Columns["DeceasedName"].HeaderText = "Deceased Name";
            dgvDeceased.Columns["Age"].HeaderText = "Age";
            dgvDeceased.Columns["DeathDate"].HeaderText = "Death Date";
            dgvDeceased.Columns["GraveAddress"].HeaderText = "Grave Address";
            dgvDeceased.Columns["Notes"].HeaderText = "Notes";
            dgvDeceased.Columns["ClientFullName"].HeaderText = "Client Full Name"; // Add header for full name
            dgvDeceased.Columns["RelationshipToClient"].HeaderText = "Relationship"; // Add header for relationship
        }

        private void txtSearchDeceased_Click(object sender, EventArgs e)
        {
            string filterText = txtSearchDeceased.Text;
            (dgvDeceased.DataSource as DataTable).DefaultView.RowFilter =
                $"DeceasedName LIKE '%{filterText}%' OR " +
                $"GraveAddress LIKE '%{filterText}%' OR " +
                $"ClientFullName LIKE '%{filterText}%' OR " +
                $"RelationshipToClient LIKE '%{filterText}%'";
        }


        private void dgvDeceased_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddDeceased_Click(object sender, EventArgs e)
        {
            FrmAddDeceased addForm = new FrmAddDeceased(); // Open the form to add a new deceased record
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadDeceasedData(); // Reload data after adding a new record
            }
        }

        private void btnEditDeceased_Click(object sender, EventArgs e)
        {
            if (dgvDeceased.SelectedRows.Count > 0)
            {
                int deceasedId = (int)dgvDeceased.SelectedRows[0].Cells["DeceasedID"].Value;
                FrmAddDeceased editForm = new FrmAddDeceased(deceasedId); // Pass the deceased ID to the editing form
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadDeceasedData(); // Reload data after editing a record
                }
            }
        }

        private void btnDeleteDeceased_Click(object sender, EventArgs e)
        {
            if (dgvDeceased.SelectedRows.Count > 0)
            {
                int deceasedId = (int)dgvDeceased.SelectedRows[0].Cells["DeceasedID"].Value;

                using (SqlConnection conn = GetConnection())
                {
                    string query = "DELETE FROM Deceased WHERE DeceasedID = @DeceasedID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@DeceasedID", deceasedId);
                    conn.Open();
                    cmd.ExecuteNonQuery(); // Execute delete query
                    LoadDeceasedData(); // Reload data after deletion
                }
            }
        }
    }
}
