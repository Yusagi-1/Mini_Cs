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
            deceasedData = data ?? new DeceasedInfoData();
            BindDataToControls();

        }

        private void txtName_Click(object sender, EventArgs e)
        {
            deceasedData.Name = txtName.Text;
        }

        private void txtAddress_Click(object sender, EventArgs e)
        {
            deceasedData.Address = txtAddress.Text;
        }

        private void cbCivilStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            deceasedData.CivilStatus = cbCivilStatus.SelectedItem?.ToString();

        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            deceasedData.Gender = cbGender.SelectedItem?.ToString();
        }

        private void txtPwd_Click(object sender, EventArgs e)
        {
            deceasedData.OSCAPWDID = txtPwd.Text;
        }

        private void dpBirthdate_ValueChanged(object sender, EventArgs e)
        {
            deceasedData.Birthdate = dpBirthdate.Value;
        }

        private void dpDateofDeath_ValueChanged(object sender, EventArgs e)
        {
            deceasedData.DateOfDeath = dpDateofDeath.Value;
        }
        private void BindDataToControls()
        {
            txtName.Text = deceasedData.Name;
            txtAddress.Text = deceasedData.Address;
            cbCivilStatus.SelectedItem = deceasedData.CivilStatus;
            cbGender.SelectedItem = deceasedData.Gender;
            dpBirthdate.Value = deceasedData.Birthdate.GetValueOrDefault(DateTime.Now);
            dpDateofDeath.Value = deceasedData.DateOfDeath.GetValueOrDefault(DateTime.Now);
            txtPwd.Text = deceasedData.OSCAPWDID;
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Please fill out all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Populate deceased data from form fields
            deceasedData.Name = txtName.Text;
            deceasedData.Address = txtAddress.Text;
            deceasedData.CivilStatus = cbCivilStatus.SelectedItem?.ToString();
            deceasedData.Gender = cbGender.SelectedItem?.ToString();
            deceasedData.Birthdate = dpBirthdate.Value;
            deceasedData.DateOfDeath = dpDateofDeath.Value;
            deceasedData.OSCAPWDID = txtPwd.Text;

            // Ensure ServiceDetails is initialized in sharedData if it's null
            if (parentForm.sharedData.ServiceDetails == null)
            {
                parentForm.sharedData.ServiceDetails = new ServiceDetailsData();
            }

            // Now pass the ServiceDetailsData to the Service form
            Service serviceForm = new Service(
                                    parentForm,
                                    parentForm.sharedData.ServiceDetails,
                                    parentForm.sharedData.DeathCertification,
                                    parentForm.sharedData.DispositionDetails,
                                    parentForm.sharedData.VehiclesAssigned
                                );

            parentForm.OpenFormInPanel(serviceForm);
        }

    }
}
