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
    public partial class SeniorCitizenServices : Form
    {
        public SeniorCitizenServices()
        {
            InitializeComponent();
        }
        private void CalculateTotals()
        {
            decimal grossPrice = decimal.TryParse(txtGrossPrice.Text, out grossPrice) ? grossPrice : 0;
            decimal planValue = decimal.TryParse(txtPlanValue.Text, out planValue) ? planValue : 0;
            decimal extraCharges = decimal.TryParse(txtExtraCharges.Text, out extraCharges) ? extraCharges : 0;
            decimal discount20 = decimal.TryParse(txt20Discount.Text, out discount20) ? discount20 : 0;
            decimal addDiscount = decimal.TryParse(txtAddDiscount.Text, out addDiscount) ? addDiscount : 0;

            // Calculate the VAT-exempt total
            decimal vatExemptTotal = grossPrice - planValue + extraCharges;

            // Calculate the 20% Senior Citizen discount
            decimal calculated20Discount = vatExemptTotal * 0.20m; // 20% of VAT-exempt total

            // Display the calculated 20% discount if the user hasn't entered a value
            if (discount20 == 0)
            {
                txt20Discount.Text = calculated20Discount.ToString("0.00");
            }

            // Calculate the final contract price
            decimal contractPrice = vatExemptTotal - calculated20Discount - addDiscount;

            // Display the calculated values
            txtTotalVATExempt.Text = vatExemptTotal.ToString("0.00");
            txtVatableSales.Text = contractPrice.ToString("0.00");
        }

        private void txtGrossPrice_Click(object sender, EventArgs e)
        {
            CalculateTotals();
        }

        private void txtPlanValue_Click(object sender, EventArgs e)
        {
            CalculateTotals();
        }

        private void txtExtraCharges_Click(object sender, EventArgs e)
        {
            CalculateTotals();
        }

        private void txtTotalVATExempt_Click(object sender, EventArgs e)
        {
            
        }

        private void txt20Discount_Click(object sender, EventArgs e)
        {
            CalculateTotals();
        }

        private void txtAddDiscount_Click(object sender, EventArgs e)
        {
            CalculateTotals();
        }

        private void txtVatableSales_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Retrieve input values from the form
            decimal grossPrice = decimal.TryParse(txtGrossPrice.Text, out grossPrice) ? grossPrice : 0;
            decimal planValue = decimal.TryParse(txtPlanValue.Text, out planValue) ? planValue : 0;
            decimal extraCharges = decimal.TryParse(txtExtraCharges.Text, out extraCharges) ? extraCharges : 0;
            decimal totalVATExempt = decimal.TryParse(txtTotalVATExempt.Text, out totalVATExempt) ? totalVATExempt : 0;
            decimal discount20 = decimal.TryParse(txt20Discount.Text, out discount20) ? discount20 : 0;
            decimal addDiscount = decimal.TryParse(txtAddDiscount.Text, out addDiscount) ? addDiscount : 0;
            decimal vatableSales = decimal.TryParse(txtVatableSales.Text, out vatableSales) ? vatableSales : 0;

            // Connection string from app.config
            string connectionString = ConfigurationManager.ConnectionStrings["RecordKeepingConnection"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                        INSERT INTO SeniorPaymentDetails (CustomerID, GrossPrice, PlanValue, ExtraCharges, TotalVATExempt, SCDiscount, AdditionalDiscount, ContractPrice)
                        VALUES (@CustomerID, @GrossPrice, @PlanValue, @ExtraCharges, @TotalVATExempt, @SCDiscount, @AdditionalDiscount, @ContractPrice)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to the command
                        command.Parameters.AddWithValue("@CustomerID", 1); // Modify as needed to get the actual CustomerID
                        command.Parameters.AddWithValue("@GrossPrice", grossPrice);
                        command.Parameters.AddWithValue("@PlanValue", planValue);
                        command.Parameters.AddWithValue("@ExtraCharges", extraCharges);
                        command.Parameters.AddWithValue("@TotalVATExempt", totalVATExempt);
                        command.Parameters.AddWithValue("@SCDiscount", discount20);
                        command.Parameters.AddWithValue("@AdditionalDiscount", addDiscount);
                        command.Parameters.AddWithValue("@ContractPrice", vatableSales);

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
    }
}
