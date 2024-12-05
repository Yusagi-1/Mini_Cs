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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Mini_Cs.PaymentServices
{
    public partial class RegularServices : Form
    {
        private Payment parentForm;
        private PaymentDetailsData paymentDetails;
        private CustomerData sharedData;

        public RegularServices(Payment parent, PaymentDetailsData details, CustomerData data)
        {
            InitializeComponent();
            parentForm = parent;
            sharedData = data ?? new CustomerData();
            paymentDetails = details ?? new PaymentDetailsData();
            InitializePaymentDetails();
        }
        private void InitializePaymentDetails()
        {
            if (paymentDetails != null)
            {
                txtGrossPrice.Text = paymentDetails.GrossPrice > 0 ? paymentDetails.GrossPrice.ToString("0.00") : string.Empty;
                txtPlanValue.Text = paymentDetails.PlanValue > 0 ? paymentDetails.PlanValue.ToString("0.00") : string.Empty;
                txtExtraCharges.Text = paymentDetails.ExtraCharges > 0 ? paymentDetails.ExtraCharges.ToString("0.00") : string.Empty;
                txtDiscount.Text = paymentDetails.Discount.ToString("0.00");
                txtVatableSales.Text = paymentDetails.VATableSales.ToString("0.00");
                txtVAT.Text = paymentDetails.VAT.ToString("0.00");
                txtContractPrice.Text = paymentDetails.ContractPrice.ToString("0.00");
            }
        }
        private void UpdatePaymentDetails()
        {
            paymentDetails.GrossPrice = decimal.TryParse(txtGrossPrice.Text, out var grossPrice) ? grossPrice : 0;
            paymentDetails.PlanValue = decimal.TryParse(txtPlanValue.Text, out var planValue) ? planValue : 0;
            paymentDetails.ExtraCharges = decimal.TryParse(txtExtraCharges.Text, out var extraCharges) ? extraCharges : 0;
            paymentDetails.Discount = decimal.TryParse(txtDiscount.Text, out var discount) ? discount : 0;
            paymentDetails.VATableSales = decimal.TryParse(txtVatableSales.Text, out var vatableSales) ? vatableSales : 0;
            paymentDetails.VAT = decimal.TryParse(txtVAT.Text, out var vat) ? vat : 0;
            paymentDetails.ContractPrice = decimal.TryParse(txtContractPrice.Text, out var contractPrice) ? contractPrice : 0;
        }

        private void CalculateTotals()
        {
            decimal grossPrice = decimal.TryParse(txtGrossPrice.Text, out grossPrice) ? grossPrice : 0;
            decimal planValue = decimal.TryParse(txtPlanValue.Text, out planValue) ? planValue : 0;
            decimal extraCharges = decimal.TryParse(txtExtraCharges.Text, out extraCharges) ? extraCharges : 0;
            decimal discount = decimal.TryParse(txtDiscount.Text, out discount) ? discount : 0;

            decimal vatExemptTotal = grossPrice - planValue + extraCharges - discount;
            decimal vatAmount = vatExemptTotal * 0.12m; 

            decimal contractPrice = vatExemptTotal + vatAmount;

            txtVatableSales.Text = vatExemptTotal.ToString("0.00");
            txtVAT.Text = vatAmount.ToString("0.00");
            txtContractPrice.Text = contractPrice.ToString("0.00");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

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

        private void btnProceed_Click(object sender, EventArgs e)
        {
                UpdatePaymentDetails();
                parentForm.sharedData.PaymentDetails = paymentDetails;

                MessageBox.Show("Payment details saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
    }
}
