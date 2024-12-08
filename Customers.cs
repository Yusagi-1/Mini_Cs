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
                customerDataList.Add(data);
                Console.WriteLine($"Added CustomerID: {data.CustomerID}");
            }
        }

        public void SaveAllData()
        {
            try
            {
                DatabaseManager dbManager = new DatabaseManager();

                foreach (var customerData in customerDataList)
                {
                    Console.WriteLine($"Saving CustomerID: {customerData.CustomerID}"); // Log CustomerID for debugging

                    // Save customer data
                    dbManager.SaveCustomer(customerData);

                    // Save deceased info if available
                    if (customerData.DeceasedInfo != null)
                    {
                        customerData.DeceasedInfo.CustomerID = customerData.CustomerID;
                        dbManager.SaveDeceasedInfo(customerData.DeceasedInfo);
                    }

                    // Save service details if available
                    if (customerData.ServiceDetails != null)
                    {
                        customerData.ServiceDetails.CustomerID = customerData.CustomerID;
                        dbManager.SaveServiceDetails(customerData.ServiceDetails);
                    }
                    if (customerData.DeathCertification != null)
                    {
                        customerData.DeathCertification.CustomerID = customerData.CustomerID;
                        dbManager.SaveDeathCertification(customerData.DeathCertification);
                    }
                    if (customerData.VehiclesAssigned != null)
                    {
                        customerData.VehiclesAssigned.CustomerID = customerData.CustomerID;
                        dbManager.SaveVehiclesAssigned(customerData.VehiclesAssigned);
                    }
                    if (customerData.DispositionDetails != null)
                    {
                        customerData.DispositionDetails.CustomerID = customerData.CustomerID;
                        dbManager.SaveDispositionDetails(customerData.DispositionDetails);
                    }
                }

                MessageBox.Show("All data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in SaveAllData: {ex.Message}"); // Log the error for debugging
                MessageBox.Show($"An error occurred while saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void InitializeChildForms()
        {
            // Initialize the CustomerInfo form with sharedData
            customerInfoForm = new CustomerInfo(this, sharedData);

            // Display it in the panel immediately
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
                customerInfoForm = new CustomerInfo(this, sharedData); // Pass sharedData when initializing
            }
            OpenFormInPanel(customerInfoForm);
        }

        private void btnDeceasedInfo_Click(object sender, EventArgs e)
        {
            if (deceasedForm == null)
            {
                // Ensure sharedData.DeceasedInfo is initialized
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
            OpenFormInPanel(new Payment());
        }

        private void btnPlan_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Plan());
        }

        private void btnRepresentative_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Representative());
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {
            // Optionally handle painting or background tasks
        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            if (customerDataList == null || customerDataList.Count == 0)
            {
                MessageBox.Show("No customer data available to save.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveAllData();
        }
    }
}
