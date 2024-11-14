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
                string query = "SELECT ServiceID, ServiceName, Description, Price, DurationDays, Username AS CreatedBy FROM Services JOIN Users ON Services.CreatedBy = Users.UserID";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable servicesTable = new DataTable();
                adapter.Fill(servicesTable);
                dgvServices.DataSource = servicesTable;
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
