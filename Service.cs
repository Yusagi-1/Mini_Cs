using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Mini_Cs
{
    public partial class Service : Form
    {
        private Customers parentForm;
        private ServiceDetailsData serviceDetails;
        private DeathCertificationData deathCertification;
        private DispositionDetailsData dispositionDetails;
        private VehiclesAssignedData assignedVehicles;
        public Service(Customers parent, ServiceDetailsData details, DeathCertificationData deathCert, DispositionDetailsData disposition, VehiclesAssignedData vehicles)
        {
            InitializeComponent();
            parentForm = parent;
            serviceDetails = details;
            deathCertification = deathCert;
            dispositionDetails = disposition;
            assignedVehicles = vehicles;
            LoadFormData();

            
        }
        private void LoadFormData()
        {
            tbCasketCode.Text = serviceDetails.CasketCode ?? string.Empty;
            tbUrnCode.Text = serviceDetails.UrnCode ?? string.Empty;
            tbViewingPlace.Text = serviceDetails.ViewingPlace ?? string.Empty;
            tbEmbalmingDays.Text = serviceDetails.EmbalmingDays.ToString();

            checkBoxAutopsyYes.Checked = serviceDetails.Autopsy;
            checkBoxAutopsyNo.Checked = !serviceDetails.Autopsy;
            checkboxPrivatePhysiscian.Checked = deathCertification.IssuedBy == "Private Physician";
            checkBoxHospitalAuthority.Checked = deathCertification.IssuedBy == "Hospital Authority";
            checkBoxPublicHealthOfficer.Checked = deathCertification.IssuedBy == "Public Health Officer";
            checkBoxDcOthers.Checked = deathCertification.IssuedBy == "Others";
            tbDcOthers.Text = deathCertification.OthersDetails ?? string.Empty;

            // Load Disposition Manner Data
            checkBoxBurial.Checked = dispositionDetails.DispositionManner == "Burial";
            checkBoxCremation.Checked = dispositionDetails.DispositionManner == "Cremation";
            checkBoxTransfer.Checked = dispositionDetails.DispositionManner == "Transfer";
            checkBoxDmOthers.Checked = dispositionDetails.DispositionManner == "Others";
            tbDmOthers.Text = dispositionDetails.DispositionOtherDetails ?? string.Empty;
            tbDpAddress.Text = dispositionDetails.DispositionPlace ?? string.Empty;
            if (dispositionDetails.DispositionDateTime.HasValue)
            {
                dDpPickDate.Value = dispositionDetails.DispositionDateTime.Value;
                tbDpTime.Text = dispositionDetails.DispositionDateTime.Value.ToString("HH:mm");
            }
            else
            {
                dDpPickDate.Value = DateTime.Now; // Default to now if null
                tbDpTime.Text = DateTime.Now.ToString("HH:mm");
            }


            // Load Assigned Vehicles Data
            checkBoxFamilyCar.Checked = assignedVehicles.VehicleType == "Family Car";
            checkBoxHearse.Checked = assignedVehicles.VehicleType == "Hearse";
            checkBoxFlowerCar.Checked = assignedVehicles.VehicleType == "Flower Car";
            checkBoxAvOthers.Checked = assignedVehicles.VehicleType == "Others";
            tbAvOthers.Text = assignedVehicles.VehicleOtherDetails ?? string.Empty;
            dpDateRecievedByRep.Value = assignedVehicles.DateReceivedByRepresentative ?? DateTime.Now; // Default to now if null

        }

        // Save form data to `ServiceDetailsData` object
        private void SaveFormData()
        {
            // Save Service Details
            serviceDetails.CasketCode = tbCasketCode.Text;
            serviceDetails.UrnCode = tbUrnCode.Text;
            serviceDetails.ViewingPlace = tbViewingPlace.Text;
            dispositionDetails.DispositionPlace = tbDpAddress.Text;
            var selectedDate = dDpPickDate.Value;
            if (TimeSpan.TryParse(tbDpTime.Text, out TimeSpan selectedTime))
            {
                dispositionDetails.DispositionDateTime = selectedDate.Date.Add(selectedTime);
            }
            else
            {
                // Handle invalid time input if needed (optional)
                dispositionDetails.DispositionDateTime = null; // or some default value
            }
            if (int.TryParse(tbEmbalmingDays.Text, out int embalmingDays))
            {
                serviceDetails.EmbalmingDays = embalmingDays;
            }

            serviceDetails.Autopsy = checkBoxAutopsyYes.Checked;

            // Save Death Certificate Data
            if (checkboxPrivatePhysiscian.Checked)
                deathCertification.IssuedBy = "Private Physician";
            else if (checkBoxHospitalAuthority.Checked)
                deathCertification.IssuedBy = "Hospital Authority";
            else if (checkBoxPublicHealthOfficer.Checked)
                deathCertification.IssuedBy = "Public Health Officer";
            else if (checkBoxDcOthers.Checked)
            {
                deathCertification.IssuedBy = "Others";
                deathCertification.OthersDetails = tbDcOthers.Text;
            }

            // Save Disposition Manner Data
            if (checkBoxBurial.Checked)
                dispositionDetails.DispositionManner = "Burial";
            else if (checkBoxCremation.Checked)
                dispositionDetails.DispositionManner = "Cremation";
            else if (checkBoxTransfer.Checked)
                dispositionDetails.DispositionManner = "Transfer";
            else if (checkBoxDmOthers.Checked)
            {
                dispositionDetails.DispositionManner = "Others";
                dispositionDetails.DispositionOtherDetails = tbDmOthers.Text;
            }

            // Save Assigned Vehicles Data
            if (checkBoxFamilyCar.Checked)
                assignedVehicles.VehicleType = "Family Car";
            else if (checkBoxHearse.Checked)
                assignedVehicles.VehicleType = "Hearse";
            else if (checkBoxFlowerCar.Checked)
                assignedVehicles.VehicleType = "Flower Car";
            else if (checkBoxAvOthers.Checked)
            {
                assignedVehicles.VehicleType = "Others";
                assignedVehicles.VehicleOtherDetails = tbAvOthers.Text;
            }
        }
        private void tbCasketCode_TextChanged(object sender, EventArgs e)
        {
            serviceDetails.CasketCode = tbCasketCode.Text;
        }

        private void tbUrnCode_TextChanged(object sender, EventArgs e)
        {
            serviceDetails.UrnCode = tbUrnCode.Text;
        }

        private void tbEmbalmingDays_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tbEmbalmingDays.Text, out int embalmingDays))
            {
                serviceDetails.EmbalmingDays = embalmingDays;
            }
        }

        private void checkBoxAutopsyYes_CheckedChanged(object sender, EventArgs e)
        {
            serviceDetails.Autopsy = checkBoxAutopsyYes.Checked;
        }

        private void checkBoxAutopsyNo_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void tbViewingPlace_TextChanged(object sender, EventArgs e)
        {
            serviceDetails.ViewingPlace = tbViewingPlace.Text;
        }

        private void dpDateRecievedByRep_ValueChanged(object sender, EventArgs e)
        {
            assignedVehicles.DateReceivedByRepresentative = dpDateRecievedByRep.Value;

        }

        private void checkboxPrivatePhysiscian_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxHospitalAuthority_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxPublicHealthOfficer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxDcOthers_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tbDcOthers_TextChanged(object sender, EventArgs e)
        {
            if (checkBoxDcOthers.Checked)
                deathCertification.OthersDetails = tbDcOthers.Text;
        }

        private void checkBoxBurial_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxCremation_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxTransfer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxDmOthers_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tbDmOthers_TextChanged(object sender, EventArgs e)
        {
            if (checkBoxDmOthers.Checked)
                dispositionDetails.DispositionOtherDetails = tbDmOthers.Text;

        }

        private void checkBoxFamilyCar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxHearse_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxFlowerCar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxAvOthers_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tbAvOthers_TextChanged(object sender, EventArgs e)
        {
            if (checkBoxAvOthers.Checked)
                assignedVehicles.VehicleOtherDetails = tbAvOthers.Text;

        }

        private void tbDpAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void dDpPickDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbDpTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            // Check if required fields are filled
            if (string.IsNullOrEmpty(tbCasketCode.Text) ||
                string.IsNullOrEmpty(tbUrnCode.Text) ||
                string.IsNullOrEmpty(tbViewingPlace.Text) ||
                string.IsNullOrEmpty(tbEmbalmingDays.Text) ||
                string.IsNullOrEmpty(tbDpAddress.Text) ||
                string.IsNullOrEmpty(tbDpTime.Text) ||
                string.IsNullOrEmpty(tbAvOthers.Text) && checkBoxAvOthers.Checked)
            {
                MessageBox.Show("Please fill out all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmation Message before proceeding
            DialogResult result = MessageBox.Show("Are you sure you want to proceed with saving the service details and move to the next step?",
                                                  "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    SaveFormData(); // Save form data to respective objects

                    // Ensure PlanDetails is initialized in sharedData if it's null
                    if (parentForm.sharedData.PlanDetails == null)
                    {
                        parentForm.sharedData.PlanDetails = new PlanDetailsData();
                    }

                    // Create an instance of the Plan form
                    Plan planForm = new Plan(parentForm, parentForm.sharedData.PlanDetails);

                    // Open the Plan form in the parent form's panel
                    parentForm.OpenFormInPanel(planForm);

                    MessageBox.Show("Service details saved successfully. Proceeding to the Plan form...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while saving service data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // User canceled the action
                MessageBox.Show("Proceeding has been canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
