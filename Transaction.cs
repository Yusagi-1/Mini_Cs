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
    public partial class Transaction : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["RecordKeepingConnection"].ConnectionString;

        public Transaction()
        {
            InitializeComponent();
        }
        private void Transaction_Load(object sender, EventArgs e)
        {
            LoadStatusComboBox();
            LoadCustomerIDs();
            LoadModeOfPaymentComboBox();
        }
        private void LoadModeOfPaymentComboBox()
        {
            cbModeOfPayment.Items.Clear();
            cbModeOfPayment.Items.Add("Cash");
            cbModeOfPayment.Items.Add("Check");
            cbModeOfPayment.Items.Add("Credit Card");
            cbModeOfPayment.Items.Add("Bank Transfer");
            cbModeOfPayment.SelectedIndex = 0;  // Default to the first option
        }
        private void LoadStatusComboBox()
        {

            cbStatus.Items.Clear();
            cbStatus.Items.Add("Pending");
            cbStatus.Items.Add("Partially Paid");
            cbStatus.Items.Add("Paid");
            cbStatus.SelectedIndex = 0;
        }

        private void cbCustomerId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCustomerId.SelectedItem != null)
            {
                int customerId = Convert.ToInt32(cbCustomerId.SelectedItem);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"SELECT 
                                RI.PrimaryName AS CustomerName, 
                                COALESCE(RPD.ContractPrice, SPD.ContractPrice) AS ContractPrice
                             FROM Customers C
                             LEFT JOIN RepresentativeInfo RI ON C.CustomerID = RI.CustomerID
                             LEFT JOIN RegularPaymentDetails RPD ON C.CustomerID = RPD.CustomerID
                             LEFT JOIN SeniorPaymentDetails SPD ON C.CustomerID = SPD.CustomerID
                             WHERE C.CustomerID = @CustomerID;";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@CustomerID", customerId);

                    try
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            lblCustomerName.Text = reader["CustomerName"].ToString();
                            txtContractPrice.Text = reader["ContractPrice"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No customer details found.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
        private void LoadCustomerIDs()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT C.CustomerID 
            FROM Customers C
            LEFT JOIN RegularPaymentDetails RPD ON C.CustomerID = RPD.CustomerID
            LEFT JOIN SeniorPaymentDetails SPD ON C.CustomerID = SPD.CustomerID
            WHERE COALESCE(RPD.ContractPrice, SPD.ContractPrice) > 0
            ORDER BY C.CustomerID;";

                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    cbCustomerId.Items.Clear();  // Clear existing items

                    while (reader.Read())
                    {
                        cbCustomerId.Items.Add(reader["CustomerID"].ToString());
                    }

                    if (cbCustomerId.Items.Count > 0)
                        cbCustomerId.SelectedIndex = 0;
                    else
                        MessageBox.Show("No eligible customers found.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading Customer IDs: " + ex.Message);
                }
            }
        }

        private void txtContractPrice_Click(object sender, EventArgs e){ }
        private void lblCustomerName_Click(object sender, EventArgs e){ }
        private void txtAmountPaid_Click(object sender, EventArgs e) 
        {
            if (decimal.TryParse(txtContractPrice.Text, out decimal contractPrice) &&
            decimal.TryParse(txtAmountPaid.Text, out decimal amountPaid))
            {
                decimal remainingBalance = contractPrice - amountPaid;
                lblRemainingBalance.Text = remainingBalance.ToString("F2");
            }
            else
            {
                lblRemainingBalance.Text = "0.00";
            }

        }
        private void lblRemainingBalance_Click(object sender, EventArgs e) { }
        private void dpPaymentDate_ValueChanged(object sender, EventArgs e) { }
        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cbModeOfPayment_SelectedIndexChanged(object sender, EventArgs e) { }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbCustomerId.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtContractPrice.Text) ||
                string.IsNullOrWhiteSpace(txtAmountPaid.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int customerId = Convert.ToInt32(cbCustomerId.SelectedItem);
            decimal contractPrice = Convert.ToDecimal(txtContractPrice.Text);
            decimal paymentAmount = Convert.ToDecimal(txtAmountPaid.Text);
            decimal remainingBalance = contractPrice - paymentAmount;
            string status = cbStatus.SelectedItem.ToString();
            string modeOfPayment = cbModeOfPayment.SelectedItem.ToString();
            DateTime paymentDate = dpPaymentDate.Value;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string insertQuery = @"INSERT INTO TransactionDetails 
                                (CustomerID, ContractPrice, PaymentAmount, PaymentDate, Status, ModeOfPayment) 
                                VALUES (@CustomerID, @ContractPrice, @PaymentAmount, @PaymentDate, @Status, @ModeOfPayment);";

                string updateQuery = @"UPDATE RegularPaymentDetails
                               SET ContractPrice = @RemainingBalance 
                               WHERE CustomerID = @CustomerID 
                               AND ContractPrice = @CurrentContractPrice;

                               UPDATE SeniorPaymentDetails
                               SET ContractPrice = @RemainingBalance 
                               WHERE CustomerID = @CustomerID 
                               AND ContractPrice = @CurrentContractPrice;";

                SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                SqlCommand updateCmd = new SqlCommand(updateQuery, conn);

                insertCmd.Parameters.AddWithValue("@CustomerID", customerId);
                insertCmd.Parameters.AddWithValue("@ContractPrice", contractPrice);
                insertCmd.Parameters.AddWithValue("@PaymentAmount", paymentAmount);
                insertCmd.Parameters.AddWithValue("@PaymentDate", paymentDate);
                insertCmd.Parameters.AddWithValue("@Status", status);
                insertCmd.Parameters.AddWithValue("@ModeOfPayment", modeOfPayment);

                updateCmd.Parameters.AddWithValue("@CustomerID", customerId);
                updateCmd.Parameters.AddWithValue("@RemainingBalance", remainingBalance);
                updateCmd.Parameters.AddWithValue("@CurrentContractPrice", contractPrice);

                try
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();
                    insertCmd.Transaction = transaction;
                    updateCmd.Transaction = transaction;

                    int insertResult = insertCmd.ExecuteNonQuery();
                    int updateResult = updateCmd.ExecuteNonQuery();

                    if (insertResult > 0 && updateResult > 0)
                    {
                        transaction.Commit();
                        MessageBox.Show("Transaction successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                    }
                    else
                    {
                        transaction.Rollback();
                        MessageBox.Show("Failed to add transaction.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearForm()
        {
            cbCustomerId.SelectedIndex = 0;
            txtContractPrice.Text = "0.00";
            txtAmountPaid.Text = "0.00";
            lblRemainingBalance.Text = "0.00";
            cbStatus.SelectedIndex = 0;
            cbModeOfPayment.SelectedIndex = 0;
            dpPaymentDate.Value = DateTime.Now;
        }

    }
}
