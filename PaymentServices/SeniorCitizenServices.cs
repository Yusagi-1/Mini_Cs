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
        private Payment parentForm;
        private SeniorPaymentDetailsData seniorPaymentDetails;
        private CustomerData sharedData;

        public SeniorCitizenServices(Payment parent, SeniorPaymentDetailsData details, CustomerData data)
        {
            InitializeComponent();
            parentForm = parent;
            sharedData = data ?? new CustomerData();
            seniorPaymentDetails = details ?? new SeniorPaymentDetailsData();
            InitializePaymentDetails();
        }
        private void InitializePaymentDetails()
        {
            if (seniorPaymentDetails != null)
            {
                txtGrossPrice.Text = seniorPaymentDetails.GrossPrice > 0 ? seniorPaymentDetails.GrossPrice.ToString("0.00") : string.Empty;
                txtPlanValue.Text = seniorPaymentDetails.PlanValue > 0 ? seniorPaymentDetails.PlanValue.ToString("0.00") : string.Empty;
                txtExtraCharges.Text = seniorPaymentDetails.ExtraCharges > 0 ? seniorPaymentDetails.ExtraCharges.ToString("0.00") : string.Empty;
                txt20Discount.Text = seniorPaymentDetails.SCDiscount.ToString("0.00");
                txtAddDiscount.Text = seniorPaymentDetails.AdditionalDiscount.ToString("0.00");
                txtTotalVATExempt.Text = seniorPaymentDetails.TotalVATExempt.ToString("0.00");
                txtVatableSales.Text = seniorPaymentDetails.ContractPrice.ToString("0.00");
            }
        }

        private void UpdatePaymentDetails()
        {
            seniorPaymentDetails.GrossPrice = decimal.TryParse(txtGrossPrice.Text, out var grossPrice) ? grossPrice : 0;
            seniorPaymentDetails.PlanValue = decimal.TryParse(txtPlanValue.Text, out var planValue) ? planValue : 0;
            seniorPaymentDetails.ExtraCharges = decimal.TryParse(txtExtraCharges.Text, out var extraCharges) ? extraCharges : 0;
            seniorPaymentDetails.SCDiscount = decimal.TryParse(txt20Discount.Text, out var discount20) ? discount20 : 0;
            seniorPaymentDetails.AdditionalDiscount = decimal.TryParse(txtAddDiscount.Text, out var addDiscount) ? addDiscount : 0;
            seniorPaymentDetails.TotalVATExempt = decimal.TryParse(txtTotalVATExempt.Text, out var vatExemptTotal) ? vatExemptTotal : 0;
            seniorPaymentDetails.ContractPrice = decimal.TryParse(txtVatableSales.Text, out var vatableSales) ? vatableSales : 0;
        }
        private void CalculateTotals()
        {
            decimal grossPrice = decimal.TryParse(txtGrossPrice.Text, out grossPrice) ? grossPrice : 0;
            decimal planValue = decimal.TryParse(txtPlanValue.Text, out planValue) ? planValue : 0;
            decimal extraCharges = decimal.TryParse(txtExtraCharges.Text, out extraCharges) ? extraCharges : 0;
            decimal addDiscount = decimal.TryParse(txtAddDiscount.Text, out addDiscount) ? addDiscount : 0;

            // Recalculate VAT Exempt Total
            decimal vatExemptTotal = grossPrice - planValue + extraCharges;
            txtTotalVATExempt.Text = vatExemptTotal.ToString("0.00");

            // Always recalculate 20% Discount
            decimal calculated20Discount = vatExemptTotal * 0.20m;
            txt20Discount.Text = calculated20Discount.ToString("0.00");

            // Recalculate Contract Price
            decimal contractPrice = vatExemptTotal - calculated20Discount - addDiscount;
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

        private void btnProceed_Click(object sender, EventArgs e)
        {
            try
            {
                UpdatePaymentDetails();
                parentForm.sharedData.SeniorPaymentDetails = seniorPaymentDetails;

                MessageBox.Show("Senior payment details saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
