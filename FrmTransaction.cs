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

    public partial class FrmTransaction : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["RecordKeepingConnection"].ConnectionString;

        public FrmTransaction()
        {
            InitializeComponent();
            LoadTransactions();
        }
        private void LoadTransactions()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT TransactionID, FullName AS Client, ServiceName AS Service, TransactionDate AS Date, Amount, Username AS CreatedBy " +
                               "FROM Transactions " +
                               "JOIN Clients ON Transactions.ClientID = Clients.ClientID " +
                               "JOIN Services ON Transactions.ServiceID = Services.ServiceID " +
                               "JOIN Users ON Transactions.CreatedBy = Users.UserID";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable transactionsTable = new DataTable();
                adapter.Fill(transactionsTable);
                dgvTransactions.DataSource = transactionsTable;
            }
        }

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            FrmAddEditTransaction addTransactionForm = new FrmAddEditTransaction();
            if (addTransactionForm.ShowDialog() == DialogResult.OK)
            {
                LoadTransactions();
            }
        }


        private void btnEditTransaction_Click(object sender, EventArgs e)
        {
            if (dgvTransactions.SelectedRows.Count > 0)
            {
                int transactionId = (int)dgvTransactions.SelectedRows[0].Cells["TransactionID"].Value;
                FrmAddEditTransaction editTransactionForm = new FrmAddEditTransaction(transactionId);
                if (editTransactionForm.ShowDialog() == DialogResult.OK)
                {
                    LoadTransactions();
                }
            }
        }

        private void btnDeleteTransaction_Click(object sender, EventArgs e)
        {
            if (dgvTransactions.SelectedRows.Count > 0)
            {
                int transactionId = (int)dgvTransactions.SelectedRows[0].Cells["TransactionID"].Value;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Transactions WHERE TransactionID = @TransactionID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TransactionID", transactionId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                LoadTransactions();
            }
        }
    }
}
