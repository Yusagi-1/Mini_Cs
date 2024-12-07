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

namespace Mini_Cs.PaymentServices
{
    public partial class RegularServices : Form
    {   private Payment parentForm;
        public RegularServices(Payment parent)
        {
            InitializeComponent();
            parentForm = parent;
        }
        private void CalculateTotals()
        {
            decimal grossPrice = decimal.TryParse(txtGrossPrice.Text, out grossPrice) ? grossPrice : 0;
            decimal planValue = decimal.TryParse(txtPlanValue.Text, out planValue) ? planValue : 0;
            decimal extraCharges = decimal.TryParse(txtExtraCharges.Text, out extraCharges) ? extraCharges : 0;
            decimal discount = decimal.TryParse(txtDiscount.Text, out discount) ? discount : 0;

            // Calculate the Vatable Sales
            decimal vatExemptTotal = grossPrice - planValue + extraCharges - discount;
            decimal vatAmount = vatExemptTotal * 0.12m; // 12% VAT

            // Calculate the Contract Price
            decimal contractPrice = vatExemptTotal + vatAmount;

            // Display calculated values
            txtVatableSales.Text = vatExemptTotal.ToString("0.00");
            txtVAT.Text = vatAmount.ToString("0.00");
            txtContractPrice.Text = contractPrice.ToString("0.00");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Retrieve input values from the form
            decimal grossPrice = decimal.TryParse(txtGrossPrice.Text, out grossPrice) ? grossPrice : 0;
            decimal planValue = decimal.TryParse(txtPlanValue.Text, out planValue) ? planValue : 0;
            decimal extraCharges = decimal.TryParse(txtExtraCharges.Text, out extraCharges) ? extraCharges : 0;
            decimal discount = decimal.TryParse(txtDiscount.Text, out discount) ? discount : 0;
            decimal vat = decimal.TryParse(txtVAT.Text, out vat) ? vat : 0;
            decimal vatableSales = decimal.TryParse(txtVatableSales.Text, out vatableSales) ? vatableSales : 0;
            decimal contractPrice = decimal.TryParse(txtContractPrice.Text, out contractPrice) ? contractPrice : 0;

            // Connection string from app.config
            string connectionString = ConfigurationManager.ConnectionStrings["RecordKeepingConnection"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                        INSERT INTO RegularPaymentDetails (CustomerID, GrossPrice, PlanValue, ExtraCharges, Discount, VAT, VatableSales, ContractPrice)
                        VALUES (@CustomerID, @GrossPrice, @PlanValue, @ExtraCharges, @Discount, @VAT, @VatableSales, @ContractPrice)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to the command
                        command.Parameters.AddWithValue("@CustomerID", 1); // Modify as needed to get the actual CustomerID
                        command.Parameters.AddWithValue("@GrossPrice", grossPrice);
                        command.Parameters.AddWithValue("@PlanValue", planValue);
                        command.Parameters.AddWithValue("@ExtraCharges", extraCharges);
                        command.Parameters.AddWithValue("@Discount", discount);
                        command.Parameters.AddWithValue("@VAT", vat);
                        command.Parameters.AddWithValue("@VatableSales", vatableSales);
                        command.Parameters.AddWithValue("@ContractPrice", contractPrice);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No records were inserted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void txtGrossPrice_Click(object sender, EventArgs e)
        {
            CalculateTotals();
        }

        private void txtDiscount_Click(object sender, EventArgs e)
        {
            CalculateTotals();
        }

        private void txtPlanValue_Click(object sender, EventArgs e)
        {
            CalculateTotals();
        }

        private void txtContractPrice_Click(object sender, EventArgs e)
        {

        }

        private void txtExtraCharges_Click(object sender, EventArgs e)
        {
            CalculateTotals();
        }

        private void txtVAT_Click(object sender, EventArgs e)
        {
            CalculateTotals();
        }

        private void txtVatableSales_Click(object sender, EventArgs e)
        {

        }


    }
}
