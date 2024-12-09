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
    public partial class Representative : Form
    {
        private Customers parentForm;
        private RepresentativeInfoData representativeDetails;
        public Representative(Customers parent, RepresentativeInfoData details)
        {
            InitializeComponent();
            parentForm = parent;
            representativeDetails = details;

            BindDataToControls();
        }
        private void BindDataToControls()
        {
            txtPrimaryName.Text = representativeDetails.PrimaryName;
            txtPrimaryRelationship.Text = representativeDetails.PrimaryRelationship;
            txtPrimaryAddress.Text = representativeDetails.PrimaryAddress;
            txtPrimaryMobileNo.Text = representativeDetails.PrimaryTelMobile;
            txtPrimaryEmail.Text = representativeDetails.PrimaryEmail;
            dpPrimaryDate.Value = representativeDetails.PrimaryDate.GetValueOrDefault(DateTime.Now);

            txtSecondaryName.Text = representativeDetails.SecondaryName;
            txtSecondaryRelationship.Text = representativeDetails.SecondaryRelationship;
            txtSecondaryAddress.Text = representativeDetails.SecondaryAddress;
            txtSecondaryMobileNo.Text = representativeDetails.SecondaryTelMobile;
            txtSecondaryEmail.Text = representativeDetails.SecondaryEmail;
            dpSecondaryDate.Value = representativeDetails.SecondaryDate.GetValueOrDefault(DateTime.Now);
        }

        private void UpdateRepresentativeDetails()
        {
            representativeDetails.PrimaryName = txtPrimaryName.Text;
            representativeDetails.PrimaryRelationship = txtPrimaryRelationship.Text;
            representativeDetails.PrimaryAddress = txtPrimaryAddress.Text;
            representativeDetails.PrimaryTelMobile = txtPrimaryMobileNo.Text;
            representativeDetails.PrimaryEmail = txtPrimaryEmail.Text;
            representativeDetails.PrimaryDate = dpPrimaryDate.Value;

            representativeDetails.SecondaryName = txtSecondaryName.Text;
            representativeDetails.SecondaryRelationship = txtSecondaryRelationship.Text;
            representativeDetails.SecondaryAddress = txtSecondaryAddress.Text;
            representativeDetails.SecondaryTelMobile = txtSecondaryMobileNo.Text;
            representativeDetails.SecondaryEmail = txtSecondaryEmail.Text;
            representativeDetails.SecondaryDate = dpSecondaryDate.Value;
        }
        private void btnFinish_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrEmpty(txtPrimaryName.Text) || string.IsNullOrEmpty(txtPrimaryRelationship.Text))
            {
                MessageBox.Show("Please fill out the required fields for the primary representative.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UpdateRepresentativeDetails();

            // Temporary data is saved in the representativeDetails object
            MessageBox.Show("Data has been temporarily saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Optionally, you can close the form or proceed to another form here
            this.Close();
        }

        private void txtPrimaryName_Click(object sender, EventArgs e)
        {
            representativeDetails.PrimaryName = txtPrimaryName.Text;
        }

        private void txtPrimaryRelationship_Click(object sender, EventArgs e)
        {
            representativeDetails.PrimaryRelationship = txtPrimaryRelationship.Text;
        }

        private void txtPrimaryAddress_Click(object sender, EventArgs e)
        {
            representativeDetails.PrimaryAddress = txtPrimaryAddress.Text;
        }

        private void txtPrimaryMobileNo_Click(object sender, EventArgs e)
        {
            representativeDetails.PrimaryTelMobile = txtPrimaryMobileNo.Text;
        }

        private void txtPrimaryEmail_Click(object sender, EventArgs e)
        {
            representativeDetails.PrimaryEmail = txtPrimaryEmail.Text;
        }

        private void dpPrimaryDate_ValueChanged(object sender, EventArgs e)
        {
            representativeDetails.PrimaryDate = dpPrimaryDate.Value;
        }

        private void txtSecondaryName_Click(object sender, EventArgs e)
        {
            representativeDetails.SecondaryName = txtSecondaryName.Text;
        }

        private void txtSecondaryRelationship_Click(object sender, EventArgs e)
        {
            representativeDetails.SecondaryRelationship = txtSecondaryRelationship.Text;
        }

        private void txtSecondaryAddress_Click(object sender, EventArgs e)
        {
            representativeDetails.SecondaryAddress = txtSecondaryAddress.Text;
        }

        private void txtSecondaryMobileNo_Click(object sender, EventArgs e)
        {
            representativeDetails.SecondaryTelMobile = txtSecondaryMobileNo.Text;
        }

        private void txtSecondaryEmail_Click(object sender, EventArgs e)
        {
            representativeDetails.SecondaryEmail = txtSecondaryEmail.Text;
        }

        private void dpSecondaryDate_ValueChanged(object sender, EventArgs e)
        {
            representativeDetails.SecondaryDate = dpSecondaryDate.Value;
        }
    }
}
