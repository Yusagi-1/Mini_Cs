using System;
using System.Windows.Forms;

namespace Mini_Cs
{
    public partial class CustomerInfo : Form
    {
        private Customers parentForm;
        private CustomerData customerData;
        

        public CustomerInfo(Customers parent, CustomerData sharedData)
        {
            InitializeComponent();
            parentForm = parent;
            customerData = sharedData;
            dpDate.Value = DateTime.Today;
            customerData.ServiceDate = dpDate.Value;
        }

        private void UpdateServiceType()
        {
            if (checkBoxFullService.Checked)
            {
                customerData.ServiceType = "Full Service";
                LockOtherCheckboxes(checkBoxFullService);
            }
            else if (checkBoxFullServiceCremation.Checked)
            {
                customerData.ServiceType = "Full Service with Cremation";
                LockOtherCheckboxes(checkBoxFullServiceCremation);
            }
            else if (checkBoxCremationOnly.Checked)
            {
                customerData.ServiceType = "Cremation Only";
                LockOtherCheckboxes(checkBoxCremationOnly);
            }
            else
            {
                UnlockAllCheckboxes();
            }
        }
        private void UnlockAllCheckboxes()
        {
            checkBoxFullService.Enabled = true;
            checkBoxFullServiceCremation.Enabled = true;
            checkBoxCremationOnly.Enabled = true;
        }
        private void LockOtherCheckboxes(CheckBox selectedCheckbox)
        {
            checkBoxFullService.Enabled = selectedCheckbox == checkBoxFullService;
            checkBoxFullServiceCremation.Enabled = selectedCheckbox == checkBoxFullServiceCremation;
            checkBoxCremationOnly.Enabled = selectedCheckbox == checkBoxCremationOnly;
        }
        private void UpdateLifePlanSelection()
        {
            if (checkBoxYes.Checked)
            {
                customerData.WithLifePlan = "Yes";
                LockLifePlanCheckboxes(checkBoxYes);
                txtBoxOthers.Enabled = false; 
            }
            else if (checkBoxNo.Checked)
            {
                customerData.WithLifePlan = "No";
                LockLifePlanCheckboxes(checkBoxNo);
                txtBoxOthers.Enabled = false; 
            }
            else if (checkBoxOther.Checked)
            {
                customerData.WithLifePlan = "Others";
                LockLifePlanCheckboxes(checkBoxOther);
                txtBoxOthers.Enabled = true; 
            }
            else
            {
                UnlockAllLifePlanCheckboxes();
                txtBoxOthers.Enabled = false;
            }
        }

        private void LockLifePlanCheckboxes(CheckBox selectedCheckbox)
        {
            checkBoxYes.Enabled = selectedCheckbox == checkBoxYes;
            checkBoxNo.Enabled = selectedCheckbox == checkBoxNo;
            checkBoxOther.Enabled = selectedCheckbox == checkBoxOther;
        }

        private void UnlockAllLifePlanCheckboxes()
        {
            checkBoxYes.Enabled = true;
            checkBoxNo.Enabled = true;
            checkBoxOther.Enabled = true;
        }

        private void btnProceed_Click_1(object sender, EventArgs e)
        {
            if (checkBoxOther.Checked)
            {
                customerData.LifePlanOtherDetails = txtBoxOthers.Text; 
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
                MessageBox.Show("Customer data saved successfully. Proceeding to Deceased form...");
                Deceased deceasedForm = new Deceased(parentForm, customerData.DeceasedInfo); // Pass shared data

                parentForm.OpenFormInPanel(deceasedForm);
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
            UpdateLifePlanSelection();
            
        }

        private void checkBoxNo_CheckedChanged_1(object sender, EventArgs e)
        {
            UpdateLifePlanSelection();
            
        }

        private void checkBoxOther_CheckedChanged_1(object sender, EventArgs e)
        {
            UpdateLifePlanSelection();
            
        }

        private void txtBoxOthers_Click_1(object sender, EventArgs e)
        {
            if (checkBoxOther.Checked)
            {
                customerData.LifePlanOtherDetails = txtBoxOthers.Text; 
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
                customerData.LifePlanOtherDetails = txtBoxOthers.Text; 
            }
        }
    }
}
