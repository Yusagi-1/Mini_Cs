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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Mini_Cs
{
    public partial class Deceased : Form
    {
        private Customers parentForm; // Reference to parent form
        private DeceasedInfoData deceasedData; // Shared data object
        public Deceased(Customers parent, DeceasedInfoData data)
        {
            InitializeComponent();
            parentForm = parent;
            deceasedData = data;
            InitializeDeceasedInfo();

        }
        private void InitializeDeceasedInfo()
        {
            if (deceasedData != null)
            {
                txtName.Text = deceasedData.Name;
                txtAddress.Text = deceasedData.Address;
                cbCivilStatus.SelectedItem = deceasedData.CivilStatus;
                cbGender.SelectedItem = deceasedData.Gender;
                dpBirthdate.Value = deceasedData.Birthdate.GetValueOrDefault(DateTime.Now);
                dpDateofDeath.Value = deceasedData.DateOfDeath.GetValueOrDefault(DateTime.Now);
                txtPwd.Text = deceasedData.OSCAPWDID;
            }
        }
        private void UpdateDeceasedData()
        {
            deceasedData.Name = txtName.Text.Trim();
            deceasedData.Address = txtAddress.Text.Trim();
            deceasedData.CivilStatus = cbCivilStatus.SelectedItem?.ToString();
            deceasedData.Gender = cbGender.SelectedItem?.ToString();
            deceasedData.Birthdate = dpBirthdate.Value;
            deceasedData.DateOfDeath = dpDateofDeath.Value;
            deceasedData.OSCAPWDID = txtPwd.Text.Trim();
        }
        private void btnProceed_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Please fill out all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show(
                "Do you want to proceed with the entered deceased information?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    UpdateDeceasedData();
                    if (parentForm.sharedData.PlanDetails == null)
                    {
                        parentForm.sharedData.DeceasedInfo = deceasedData;
                    }
                    Service serviceForm = new Service(
                        parentForm,
                        parentForm.sharedData.ServiceDetails,
                        parentForm.sharedData.DeathCertification,
                        parentForm.sharedData.DispositionDetails,
                        parentForm.sharedData.VehiclesAssigned);

                    parentForm.OpenFormInPanel(serviceForm);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Proceeding has been canceled.", "Action Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtName_Click(object sender, EventArgs e)
        {
            
        }

        private void txtAddress_Click(object sender, EventArgs e)
        {
            
        }

        private void cbCivilStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPwd_Click(object sender, EventArgs e)
        {
            
        }

        private void dpBirthdate_ValueChanged(object sender, EventArgs e)
        {
        }

        private void dpDateofDeath_ValueChanged(object sender, EventArgs e)
        {
           
        }
        
        

        



    }
}
