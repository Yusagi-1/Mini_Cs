using System;
using System.Windows.Forms;

namespace Mini_Cs
{
    public partial class CustomerInfo : Form
    {
        private Customers parentForm;
        private CustomerData customerData;
        private DatabaseManager dbManager;

        public CustomerInfo(Customers parent, CustomerData sharedData)
        {
            InitializeComponent();
            parentForm = parent;
            customerData = sharedData;
            dbManager = new DatabaseManager();
        }

        private void UpdateServiceType()
        {
            if (checkBoxFullService.Checked)
            {
                customerData.ServiceType = "Full Service";
            }
            else if (checkBoxFullServiceCremation.Checked)
            {
                customerData.ServiceType = "Full Service with Cremation";
            }
            else if (checkBoxCremationOnly.Checked)
            {
                customerData.ServiceType = "Cremation Only";
            }
        }
        private void ToggleLifePlanDetails()
        {
            txtBoxOthers.Enabled = checkBoxOther.Checked;
            if (!checkBoxOther.Checked)
            {
                txtBoxOthers.Text = string.Empty; // Clear text if "Other" is not checked
                customerData.LifePlanOtherDetails = string.Empty; // Clear shared data
            }
        }


        private void btnProceed_Click_1(object sender, EventArgs e)
        {
            if (checkBoxOther.Checked)
            {
                customerData.LifePlanOtherDetails = txtBoxOthers.Text; // Ensure latest value
            }
            Console.WriteLine($"Proceeding with CustomerID: {customerData.CustomerID}");
            parentForm.AddCustomerData(customerData);
            if (parentForm == null)
            {
                MessageBox.Show("Parent form is not set. Unable to proceed.");
                return;
            }

            try
            {
                //MessageBox.Show("Attempting to save customer data...");
                //dbManager.SaveCustomer(customerData); // Save data

                MessageBox.Show("Customer data saved successfully. Proceeding to Deceased form...");
                Deceased deceasedForm = new Deceased(parentForm, customerData.DeceasedInfo); // Pass shared data

                parentForm.OpenFormInPanel(deceasedForm); // Transition to Deceased form
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving customer data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBoxFullService_CheckedChanged_1(object sender, EventArgs e)
        {
            UpdateServiceType();
        }

        private void checkBoxFullServiceCremation_CheckedChanged_1(object sender, EventArgs e)
        {
            UpdateServiceType();
        }

        private void checkBoxCremationOnly_CheckedChanged_1(object sender, EventArgs e)
        {
            UpdateServiceType();
        }

        private void checkBoxYes_CheckedChanged_1(object sender, EventArgs e)
        {
            ToggleLifePlanDetails();
            customerData.WithLifePlan = "Yes";
        }

        private void checkBoxNo_CheckedChanged_1(object sender, EventArgs e)
        {
            ToggleLifePlanDetails();
            customerData.WithLifePlan = "No";
        }

        private void checkBoxOther_CheckedChanged_1(object sender, EventArgs e)
        {
            ToggleLifePlanDetails();
            customerData.WithLifePlan = "Others";
        }

        private void txtBoxOthers_Click_1(object sender, EventArgs e)
        {
            if (checkBoxOther.Checked)
            {
                customerData.LifePlanOtherDetails = txtBoxOthers.Text; // Update shared data
            }
        }

        private void dpDate_ValueChanged_1(object sender, EventArgs e)
        {
            customerData.ServiceDate = dpDate.Value;
        }

        private void txtBoxOthers_TextChanged(object sender, EventArgs e)
        {
            if (checkBoxOther.Checked)
            {
                customerData.LifePlanOtherDetails = txtBoxOthers.Text; // Update shared data
            }
        }
    }
}
