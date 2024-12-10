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
    public partial class UpdateTransac : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["RecordKeepingConnection"].ConnectionString;
        public UpdateTransac()
        {
            InitializeComponent();
            cbTransactionID.SelectedIndexChanged += cbTransactionID_SelectedIndexChanged; // Hook up the event
            cbTransactionID.KeyPress += cbTransactionID_KeyPress;
        }

        private void cbTransactionID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTransactionID.SelectedItem != null)
            {
                int selectedTransactionID = Convert.ToInt32(cbTransactionID.SelectedItem);
                LoadTransactionDetails(selectedTransactionID);
            }
        }
        private void LoadTransactionDetails(int transactionId)
        {
            string query = @"
    SELECT td.*, ri.PrimaryName 
    FROM TransactionDetails td
    LEFT JOIN RepresentativeInfo ri ON td.CustomerID = ri.CustomerID
    WHERE td.TransactionID = @TransactionID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TransactionID", transactionId);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        txtContractPrice.Text = reader["ContractPrice"].ToString();
                        txtPaymentAmount.Text = reader["PaymentAmount"].ToString();

                        // Update Status ComboBox
                        string status = reader["Status"].ToString();
                        if (cbStatus.Items.Contains(status))
                        {
                            cbStatus.SelectedItem = status;
                        }
                        else
                        {
                            cbStatus.SelectedItem = null;
                        }

                        // Force ComboBox refresh
                        cbStatus.Refresh();

                        // Update ModeOfPayment ComboBox
                        string modeOfPayment = reader["ModeOfPayment"] == DBNull.Value ? string.Empty : reader["ModeOfPayment"].ToString();
                        if (cbModeOfPayment.Items.Contains(modeOfPayment))
                        {
                            cbModeOfPayment.SelectedItem = modeOfPayment;
                        }
                        else
                        {
                            cbModeOfPayment.SelectedItem = null; // Clear selection if no match
                        }

                        // Force ComboBox refresh
                        cbModeOfPayment.Refresh();

                        lblCustomerName.Text = reader["PrimaryName"].ToString();
                    }
                }
            }
        }


        private void lblCustomerName_Click(object sender, EventArgs e)
        {

        }

        private void txtContractPrice_Click(object sender, EventArgs e)
        {

        }

        private void txtPaymentAmount_Click(object sender, EventArgs e)
        {

        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbModeOfPayment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbTransactionID.SelectedItem != null)
            {
                if (int.TryParse(cbTransactionID.SelectedItem.ToString(), out int transactionId) &&
                    decimal.TryParse(txtPaymentAmount.Text, out decimal paymentAmount) && paymentAmount >= 0)
                {
                    // Get the selected status
                    string selectedStatus = cbStatus.SelectedItem?.ToString();

                    if (string.IsNullOrEmpty(selectedStatus))
                    {
                        MessageBox.Show("Please select a valid status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Get the selected mode of payment
                    string selectedModeOfPayment = cbModeOfPayment.SelectedItem?.ToString();

                    if (string.IsNullOrEmpty(selectedModeOfPayment))
                    {
                        MessageBox.Show("Please select a valid mode of payment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Update the database
                    UpdateTransactionDetails(transactionId, paymentAmount, selectedStatus, selectedModeOfPayment);

                    MessageBox.Show("Transaction updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Close the form after saving
                }
                else
                {
                    MessageBox.Show("Please enter a valid payment amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateTransactionDetails(int transactionId, decimal paymentAmount, string status, string modeOfPayment)
        {
            string query = @"
        UPDATE TransactionDetails 
        SET PaymentAmount = @PaymentAmount, 
            Status = @Status, 
            ModeOfPayment = @ModeOfPayment 
        WHERE TransactionID = @TransactionID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PaymentAmount", paymentAmount);
                    command.Parameters.AddWithValue("@Status", status);
                    command.Parameters.AddWithValue("@ModeOfPayment", modeOfPayment);
                    command.Parameters.AddWithValue("@TransactionID", transactionId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private void UpdatePaymentAmount(int transactionId, decimal paymentAmount)
        {
            string query = "UPDATE TransactionDetails SET PaymentAmount = @PaymentAmount WHERE TransactionID = @TransactionID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PaymentAmount", paymentAmount);
                    command.Parameters.AddWithValue("@TransactionID", transactionId);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private void cbTransactionID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the Enter key is pressed
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (int.TryParse(cbTransactionID.Text, out int selectedTransactionID))
                {
                    LoadTransactionDetails(selectedTransactionID);

                    // Optional: Update ComboBox selection visually
                    cbTransactionID.SelectedItem = selectedTransactionID.ToString();
                }
                e.Handled = true; // Prevent the beep sound on Enter
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateTransac_Load(object sender, EventArgs e)
        {
            PopulateTransactionIDs();
            PopulateStatusAndPaymentMode();

            // Auto-select the first TransactionID if available
            if (cbTransactionID.Items.Count > 0)
            {
                cbTransactionID.SelectedIndex = 0;
                int firstTransactionID = Convert.ToInt32(cbTransactionID.SelectedItem);
                LoadTransactionDetails(firstTransactionID);
            }
        }

        private void PopulateStatusAndPaymentMode()
        {
            cbStatus.Items.Clear();
            cbModeOfPayment.Items.Clear();

            string queryStatus = "SELECT DISTINCT Status FROM TransactionDetails";
            string queryModeOfPayment = "SELECT DISTINCT ModeOfPayment FROM TransactionDetails WHERE ModeOfPayment IS NOT NULL";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Load Status values
                using (SqlCommand command = new SqlCommand(queryStatus, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        cbStatus.Items.Add(reader["Status"].ToString());
                    }
                    reader.Close();
                }

                // Load ModeOfPayment values
                using (SqlCommand command = new SqlCommand(queryModeOfPayment, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        cbModeOfPayment.Items.Add(reader["ModeOfPayment"].ToString());
                    }
                    reader.Close();
                }
            }
        }


        private void PopulateTransactionIDs()
        {
            string query = "SELECT TransactionID FROM TransactionDetails";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        cbTransactionID.Items.Add(reader["TransactionID"].ToString());
                    }
                }
            }
        }
    }
}
