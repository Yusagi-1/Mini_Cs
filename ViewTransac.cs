using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace Mini_Cs.TransacDetails
{
    public partial class ViewTransac : Form
    {
        private readonly string connectionString;
        public ViewTransac()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["RecordKeepingConnection"].ConnectionString;

            
        }
        private void LoadTransactionDetails()
        {
            string query = "SELECT * FROM dbo.GetTransactionDetailsWithPrimaryName()";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dgvTransacDetails.DataSource = dataTable;
                            dgvTransacDetails.Columns["PaymentPercentage"].DefaultCellStyle.Format = "N2";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnExist_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTransacDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void View_Load(object sender, EventArgs e)
        {
            LoadTransactionDetails();
        }
    }
}
