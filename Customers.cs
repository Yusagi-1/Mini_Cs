using System;
using System.Numerics;
using System.Windows.Forms;

namespace Mini_Cs
{
    public partial class Customers : Form
    {
        private List<CustomerData> customerDataList = new List<CustomerData>();
        private CustomerInfo customerInfoForm;
        private Deceased deceasedForm;
        public CustomerData sharedData = new CustomerData();

        public Customers()
        {
            InitializeComponent();
            InitializeChildForms();

        }
        public void AddCustomerData(CustomerData data)
        {
            if (data != null)
            {
                // Prevent duplicates based on CustomerID
                if (customerDataList.Any(c => c.CustomerID == data.CustomerID))
                {
                    Console.WriteLine($"Duplicate CustomerID: {data.CustomerID} - Skipping.");
                    return;
                }

                customerDataList.Add(data);
                Console.WriteLine($"Added CustomerID: {data.CustomerID}");
            }
        }

        private void ClearAllControls(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
                else if (control is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }
                else if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                }
                else if (control is NumericUpDown numericUpDown)
                {
                    numericUpDown.Value = numericUpDown.Minimum;
                }
                else if (control.HasChildren)
                {
                    // Recursive call for container controls like Panel, GroupBox, etc.
                    ClearAllControls(control);
                }
            }
        }
        private void ClearChildForms()
        {
            if (customerInfoForm != null)
            {
                ClearAllControls(customerInfoForm);
            }
        }

        private void ResetDataClasses()
        {
            // Reset the shared data
            sharedData = new CustomerData();

            // Reset specific sub-objects in sharedData if needed
            sharedData.DeceasedInfo = new DeceasedInfoData();
            sharedData.ServiceDetails = new ServiceDetailsData();
            sharedData.DeathCertification = new DeathCertificationData();
            sharedData.VehiclesAssigned = new VehiclesAssignedData();
            sharedData.DispositionDetails = new DispositionDetailsData();
            sharedData.PlanDetails = new PlanDetailsData();
            sharedData.RepresentativeInfo = new RepresentativeInfoData();
            sharedData.PaymentDetails = new PaymentDetailsData();
            sharedData.SeniorPaymentDetails = new SeniorPaymentDetailsData();

            // Clear the list of customers if needed
            customerDataList.Clear();
        }
        private void ResetCustomerInfoData()
        {
            sharedData.ServiceType = string.Empty;
            sharedData.WithLifePlan = string.Empty;
            sharedData.LifePlanOtherDetails = string.Empty;
            sharedData.ServiceDate = DateTime.MinValue;
        }


        public void SaveAllData()
        {
            try
            {
                DatabaseManager dbManager = new DatabaseManager();

                foreach (var customerData in customerDataList)
                {
                    if (!IsFormComplete(customerData))
                    {
                        Console.WriteLine($"Skipping CustomerID: {customerData.CustomerID} due to incomplete form.");
                        continue;
                    }

                    Console.WriteLine($"Saving CustomerID: {customerData.CustomerID}");

                    dbManager.SaveCustomer(customerData);

                    if (customerData.DeceasedInfo != null && !string.IsNullOrEmpty(customerData.DeceasedInfo.Name))
                    {
                        customerData.DeceasedInfo.CustomerID = customerData.CustomerID;
                        dbManager.SaveDeceasedInfo(customerData.DeceasedInfo);
                    }

                    if (customerData.ServiceDetails != null && !string.IsNullOrEmpty(customerData.ServiceDetails.CasketCode))
                    {
                        customerData.ServiceDetails.CustomerID = customerData.CustomerID;
                        dbManager.SaveServiceDetails(customerData.ServiceDetails);
                    }

                    if (customerData.DeathCertification != null && !string.IsNullOrEmpty(customerData.DeathCertification.IssuedBy))
                    {
                        customerData.DeathCertification.CustomerID = customerData.CustomerID;
                        dbManager.SaveDeathCertification(customerData.DeathCertification);
                    }

                    if (customerData.VehiclesAssigned != null && !string.IsNullOrEmpty(customerData.VehiclesAssigned.VehicleType))
                    {
                        customerData.VehiclesAssigned.CustomerID = customerData.CustomerID;
                        dbManager.SaveVehiclesAssigned(customerData.VehiclesAssigned);
                    }

                    if (customerData.DispositionDetails != null && !string.IsNullOrEmpty(customerData.DispositionDetails.DispositionManner))
                    {
                        customerData.DispositionDetails.CustomerID = customerData.CustomerID;
                        dbManager.SaveDispositionDetails(customerData.DispositionDetails);
                    }

                    if (customerData.PlanDetails != null && !string.IsNullOrEmpty(customerData.PlanDetails.PlanHolderName))
                    {
                        customerData.PlanDetails.CustomerID = customerData.CustomerID;
                        dbManager.SavePlanDetails(customerData.PlanDetails);
                    }

                    if (customerData.RepresentativeInfo != null && !string.IsNullOrEmpty(customerData.RepresentativeInfo.PrimaryName))
                    {
                        customerData.RepresentativeInfo.CustomerID = customerData.CustomerID;
                        dbManager.SaveRepresentativeInfo(customerData.RepresentativeInfo);
                    }

                    if (customerData.PaymentDetails != null && customerData.PaymentDetails.GrossPrice > 0)
                    {
                        customerData.PaymentDetails.CustomerID = customerData.CustomerID;
                        dbManager.SaveRegularPaymentDetails(customerData.PaymentDetails);
                    }
                    else if (customerData.SeniorPaymentDetails != null && customerData.SeniorPaymentDetails.GrossPrice > 0)
                    {
                        customerData.SeniorPaymentDetails.CustomerID = customerData.CustomerID;
                        dbManager.SaveSeniorPaymentDetails(customerData.SeniorPaymentDetails);
                    }
                }
                customerDataList.Clear();
                MessageBox.Show("All data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in SaveAllData: {ex.Message}");
                MessageBox.Show($"An error occurred while saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }

        private bool IsFormComplete(CustomerData customerData)
        {
            if (customerData == null)
                return false;

            // Validate main customer details
            if (string.IsNullOrEmpty(customerData.ServiceType))
            {
                MessageBox.Show("Service Type is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validate deceased information
            if (customerData.DeceasedInfo == null || string.IsNullOrEmpty(customerData.DeceasedInfo.Name))
            {
                MessageBox.Show("Deceased Information is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validate service details
            if (customerData.ServiceDetails == null || string.IsNullOrEmpty(customerData.ServiceDetails.CasketCode))
            {
                MessageBox.Show("Service Details are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validate death certification
            if (customerData.DeathCertification == null || string.IsNullOrEmpty(customerData.DeathCertification.IssuedBy))
            {
                MessageBox.Show("Death Certification is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validate vehicles assigned
            if (customerData.VehiclesAssigned == null || string.IsNullOrEmpty(customerData.VehiclesAssigned.VehicleType))
            {
                MessageBox.Show("Vehicles Assigned are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validate disposition details
            if (customerData.DispositionDetails == null || string.IsNullOrEmpty(customerData.DispositionDetails.DispositionManner))
            {
                MessageBox.Show("Disposition Details are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validate plan details
            if (customerData.PlanDetails == null || string.IsNullOrEmpty(customerData.PlanDetails.PlanHolderName))
            {
                MessageBox.Show("Plan Details are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validate representative information
            if (customerData.RepresentativeInfo == null || string.IsNullOrEmpty(customerData.RepresentativeInfo.PrimaryName))
            {
                MessageBox.Show("Representative Information is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validate payment details
            if (customerData.PaymentDetails == null && customerData.SeniorPaymentDetails == null)
            {
                MessageBox.Show("Payment Details are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (customerData.PaymentDetails != null && customerData.PaymentDetails.GrossPrice <= 0 &&
                customerData.SeniorPaymentDetails != null && customerData.SeniorPaymentDetails.GrossPrice <= 0)
            {
                MessageBox.Show("A valid payment amount is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // If all validations pass
            return true;
        }


        private void InitializeChildForms()
        {
            customerInfoForm = new CustomerInfo(this, sharedData);
            OpenFormInPanel(customerInfoForm);
        }

        public void OpenFormInPanel(Form form)
        {
            panelChildForm.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(form);
            form.Show();
        }

        private void btnCustomerInfo_Click(object sender, EventArgs e)
        {
            if (customerInfoForm == null)
            {
                customerInfoForm = new CustomerInfo(this, sharedData);
            }
            OpenFormInPanel(customerInfoForm);
        }

        private void btnDeceasedInfo_Click(object sender, EventArgs e)
        {
            if (deceasedForm == null)
            {
                
                if (sharedData.DeceasedInfo == null)
                {
                    sharedData.DeceasedInfo = new DeceasedInfoData();
                }
                deceasedForm = new Deceased(this, sharedData.DeceasedInfo); // Pass the DeceasedInfoData object
            }
            OpenFormInPanel(deceasedForm);
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            if (sharedData.ServiceDetails == null)
            {
                sharedData.ServiceDetails = new ServiceDetailsData();
            }

            OpenFormInPanel(new Service(this, sharedData.ServiceDetails, sharedData.DeathCertification, sharedData.DispositionDetails, sharedData.VehiclesAssigned));

        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (sharedData.PaymentDetails == null)
            {
                sharedData.PaymentDetails = new PaymentDetailsData();
            }

            OpenFormInPanel(new Payment(sharedData));
        }

        private void btnPlan_Click(object sender, EventArgs e)
        {
            if (sharedData.PlanDetails == null)
            {
                sharedData.PlanDetails = new PlanDetailsData();
            }

            OpenFormInPanel(new Plan(this, sharedData.PlanDetails));

        }

        private void btnRepresentative_Click(object sender, EventArgs e)
        {
            // Ensure sharedData.RepresentativeInfo is initialized
            if (sharedData.RepresentativeInfo == null)
            {
                sharedData.RepresentativeInfo = new RepresentativeInfoData();
            }

            // Pass the parent form (this) and the shared RepresentativeInfoData to the Representative form
            OpenFormInPanel(new Representative(this, sharedData.RepresentativeInfo));
        }


        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            if (customerDataList == null || customerDataList.Count == 0)
            {
                MessageBox.Show("No customer data available to save.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (var customerData in customerDataList)
            {
                if (!IsFormComplete(customerData))
                {
                    MessageBox.Show("Some forms are incomplete. Please complete all required fields before saving.",
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            SaveAllData();
            ClearAllControls(this);
            ClearChildForms();
            ResetDataClasses();
            ResetCustomerInfoData();
            customerDataList.Clear();

            MessageBox.Show("Form cleared and data reset successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
