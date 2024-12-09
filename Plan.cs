using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Cs
{
    public partial class Plan : Form
    {
        private Customers parentForm;
        private PlanDetailsData planDetails;
        public Plan(Customers parent, PlanDetailsData details)
        {
            InitializeComponent();
            parentForm = parent;
            planDetails = details;
            InitializePlanDetails();

        }
        private void InitializePlanDetails()
        {
            if (planDetails != null)
            {
                txtPlanHolderName.Text = planDetails.PlanHolderName;
                txtPlanNo.Text = planDetails.PlanNo;
                txtCompany.Text = planDetails.Company;
                txtPlanType.Text = planDetails.PlanType;
            }
        }
        private void UpdatePlanDetails()
        {
            planDetails.PlanHolderName = txtPlanHolderName.Text.Trim();
            planDetails.PlanNo = txtPlanNo.Text.Trim();
            planDetails.Company = txtCompany.Text.Trim();
            planDetails.PlanType = txtPlanType.Text.Trim();
        }
        private void btnProceed_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPlanHolderName.Text) ||
                string.IsNullOrEmpty(txtPlanNo.Text) ||
                string.IsNullOrEmpty(txtCompany.Text) ||
                string.IsNullOrEmpty(txtPlanType.Text))
            {
                MessageBox.Show("Please fill out all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to proceed with saving the plan details and move to the next step?",
                                                  "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    UpdatePlanDetails();
                    parentForm.sharedData.PlanDetails = planDetails; 

                    MessageBox.Show("Plan details saved successfully. Proceeding to the Payment form...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    Payment paymentForm = new Payment(parentForm.sharedData); 
                    parentForm.OpenFormInPanel(paymentForm);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while saving plan details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Proceeding has been canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void txtPlanHolderName_Click(object sender, EventArgs e)
        {
            planDetails.PlanHolderName = txtPlanHolderName.Text.Trim();
        }

        private void txtPlanNo_Click(object sender, EventArgs e)
        {
            planDetails.PlanNo = txtPlanNo.Text.Trim();
        }

        private void txtCompany_Click(object sender, EventArgs e)
        {
            planDetails.Company = txtCompany.Text.Trim();
        }

        private void txtPlanType_Click(object sender, EventArgs e)
        {
            planDetails.PlanType = txtPlanType.Text.Trim();
        }
    }
}
