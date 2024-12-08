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
        private CustomerData sharedData = new CustomerData();
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
                    dbManager.SaveCustomer(customerData);

                    if (customerData.DeceasedInfo != null)
                    {
                        customerData.DeceasedInfo.CustomerID = customerData.CustomerID;
                        dbManager.SaveDeceasedInfo(customerData.DeceasedInfo);
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
                deceasedForm = new Deceased(this, sharedData.DeceasedInfo);
            }
            OpenFormInPanel(deceasedForm);
        }


        private void btnService_Click(object sender, EventArgs e)
        {
            if (sharedData.DeceasedInfo == null)
            {
                MessageBox.Show("No deceased information available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OpenFormInPanel(new Service(this, sharedData.DeceasedInfo));

        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Payment());
        }

        private void btnPlan_Click(object sender, EventArgs e)
        {
            //OpenFormInPanel(new Plan());
        }

        private void btnRepresentative_Click(object sender, EventArgs e)
        {
            //OpenFormInPanel(new Representative());
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
