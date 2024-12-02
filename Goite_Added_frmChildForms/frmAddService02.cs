using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Security.Policy;
using System.Windows.Media;

namespace Mini_Cs.Goite_Added_frmChildForms
{ 
    public partial class frmAddService02 : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["RecordKeepingConnection"].ConnectionString;
        public frmAddService02()
        {
            InitializeComponent();
            
            cbServiceList.Items.Clear(); 
            cbServiceList.Items.Add("Service Package 1");
            cbServiceList.Items.Add("Service Package 2");
            cbServiceList.Items.Add("Service Package 3");
            cbServiceList.Items.Add("Custom Service Package");
        }

        private void serviceData()
        {
            // Make all checkboxes visible
            cbserviceDetail1.Visible = true;
            cbserviceDetail2.Visible = true;
            cbserviceDetail3.Visible = true;
            cbserviceDetail4.Visible = true;
            cbserviceDetail5.Visible = true;
            cbserviceDetail6.Visible = true;
            cbServiceDetail7.Visible = true;

            // Ensure valid selection
            if (cbServiceList.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid service package.");
                return;
            }

            // Reset checkboxes before setting new values
            ResetCheckboxes();

            // Update details based on selected index
            switch (cbServiceList.SelectedIndex)
            {
                case 0: // Service Package 1
                    SetDetails(new[] { "Claim of Deceased", "Embalm", "Casket", "Airconditioning", "Chapel", "Presidential Chapel", "Cremation" },
                               new[] { true, true, true, false, true, false, false },
                               new[] { true, true, true, false, true, false, false });
                    break;

                case 1: // Service Package 2
                    SetDetails(new[] { "Claim of Deceased", "Embalm", "Casket", "Airconditioning", "Chapel", "Presidential Chapel", "Cremation" },
                               new[] { true, true, true, true, true, false, true },
                               new[] { true, true, true, true, true, false, true });
                    break;

                case 2: // Service Package 3
                    SetDetails(new[] { "Claim of Deceased", "Embalm", "Casket", "Airconditioning", "Chapel", "Presidential Chapel", "Cremation" },
                               new[] { true, true, true, true, false, true, true },
                               new[] { true, true, true, true, false, true, true });
                    break;

                case 3: // Custom Service Package
                    EnableCustomDetails();
                    break;

                default:
                    MessageBox.Show("Unexpected selection.");
                    break;
            }
        }

        private void ResetCheckboxes()
        {
            // Reset visibility, checked state, and enable state
            var allCheckboxes = new CheckBox[] { cbserviceDetail1, cbserviceDetail2, cbserviceDetail3, cbserviceDetail4, cbserviceDetail5, cbserviceDetail6, cbServiceDetail7 };
            foreach (var checkbox in allCheckboxes)
            {
                checkbox.Visible = false;
                checkbox.Checked = false;
                checkbox.Enabled = false;
            }
        }

        private void SetDetails(string[] labels, bool[] checkedStates, bool[] enabledStates)
        {
            // Set details for predefined packages
            var allCheckboxes = new CheckBox[] { cbserviceDetail1, cbserviceDetail2, cbserviceDetail3, cbserviceDetail4, cbserviceDetail5, cbserviceDetail6, cbServiceDetail7 };
            for (int i = 0; i < labels.Length; i++)
            {
                allCheckboxes[i].Text = labels[i];
                allCheckboxes[i].Checked = checkedStates[i];
                allCheckboxes[i].Enabled = enabledStates[i];
                allCheckboxes[i].Visible = true;
            }
        }

        private void EnableCustomDetails()
        {
            // Enable toggling for all checkboxes
            var allCheckboxes = new CheckBox[] { cbserviceDetail1, cbserviceDetail2, cbserviceDetail3, cbserviceDetail4, cbserviceDetail5, cbserviceDetail6, cbServiceDetail7 };
            foreach (var checkbox in allCheckboxes)
            {
                checkbox.Visible = true;
                checkbox.Enabled = true;
                checkbox.Checked = false; 
            }
        }

        private void cbServiceList_SelectedIndexChanged(object sender, EventArgs e)
        {
            serviceData();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            if (cbServiceList.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a service package.");
                return;
            }

            // Fetch the selected package name
            string selectedPackage = cbServiceList.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedPackage))
            {
                MessageBox.Show("Selected service package is invalid.");
                return;
            }

            List<string> selectedServices = new List<string>();

            // Add services for checked items
            if (cbserviceDetail1.Visible && cbserviceDetail1.Checked) selectedServices.Add(cbserviceDetail1.Text);
            if (cbserviceDetail2.Visible && cbserviceDetail2.Checked) selectedServices.Add(cbserviceDetail2.Text);
            if (cbserviceDetail3.Visible && cbserviceDetail3.Checked) selectedServices.Add(cbserviceDetail3.Text);
            if (cbserviceDetail4.Visible && cbserviceDetail4.Checked) selectedServices.Add(cbserviceDetail4.Text);
            if (cbserviceDetail5.Visible && cbserviceDetail5.Checked) selectedServices.Add(cbserviceDetail5.Text);
            if (cbserviceDetail6.Visible && cbserviceDetail6.Checked) selectedServices.Add(cbserviceDetail6.Text);
            if (cbServiceDetail7.Visible && cbServiceDetail7.Checked) selectedServices.Add(cbServiceDetail7.Text);

            // Validate services
            if (selectedServices.Count == 0)
            {
                MessageBox.Show("No services selected. Please select at least one service.");
                return;
            }

            string serviceDetails = string.Join(", ", selectedServices);

            DateTime bookDate = dtpBookDate.Value;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "INSERT INTO Service_Sample (ServicePackage, ServiceDetails, BookedDate) VALUES (@ServicePackage, @ServiceDetails, @bookDate)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ServicePackage", selectedPackage);
                        cmd.Parameters.AddWithValue("@ServiceDetails", serviceDetails);
                        cmd.Parameters.AddWithValue("@BookDate", bookDate);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Service Have Been Booked Succesfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding services: " + ex.Message);
            }
        }
    }
}
