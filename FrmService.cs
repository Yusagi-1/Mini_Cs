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
    public partial class FrmService : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["RecordKeepingConnection"].ConnectionString;

        public FrmService()
        {
            InitializeComponent();
            LoadServices();
        }
        private void LoadServices()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Exclude CreatedAt and CreatedBy columns
                string query = @"
            SELECT 
                ServiceID AS [ID], 
                ServiceName AS [Service Name], 
                Description AS [Description], 
                Price AS [Price (₱)], 
                DurationDays AS [Duration (Days)], 
                IncludesChapel AS [Chapel], 
                IncludesCasket AS [Casket], 
                WithAircon AS [Air Conditioning], 
                IncludesEmbalming AS [Embalming], 
                IsPresidential AS [Presidential], 
                IsFreeChapel AS [Free Chapel] 
            FROM Services";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable servicesTable = new DataTable();
                adapter.Fill(servicesTable);

                // Bind the DataTable to the DataGridView
                dgvServices.DataSource = servicesTable;

                // Optional: Set AutoSize mode for better display
                dgvServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }


        private void btnAddService_Click(object sender, EventArgs e)
        {
            FrmAddEditService addServiceForm = new FrmAddEditService();
            if (addServiceForm.ShowDialog() == DialogResult.OK)
            {
                LoadServices();
            }
        }

        private void btnEditService_Click(object sender, EventArgs e)
        {
            if (dgvServices.SelectedRows.Count > 0)
            {
                int serviceId = (int)dgvServices.SelectedRows[0].Cells["ServiceID"].Value;
                FrmAddEditService editServiceForm = new FrmAddEditService(serviceId);
                if (editServiceForm.ShowDialog() == DialogResult.OK)
                {
                    LoadServices();
                }
            }
        }

        private void btnDeleteServices_Click(object sender, EventArgs e)
        {
            if (dgvServices.SelectedRows.Count > 0)
            {
                int serviceId = (int)dgvServices.SelectedRows[0].Cells["ServiceID"].Value;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Services WHERE ServiceID = @ServiceID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ServiceID", serviceId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                LoadServices();
            }
        }
    }
}
