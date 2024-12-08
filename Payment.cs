using Mini_Cs.PaymentServices;
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
    public partial class Payment : Form
    {
        private RegularServices regularServices;
        public Payment()
        {
            InitializeComponent();
            InitializeChildForms();
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }
        private void InitializeChildForms()
        {

            regularServices = new RegularServices(this);

            // Display it in the panel immediately
            LoadChildForm(regularServices);
        }
        private void LoadChildForm(Form childForm)
        {
            // Clear the panel before loading a new form
            panelChildForm.Controls.Clear();
            // Set the child form to fill the panel
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            // Add the child form to the panel
            panelChildForm.Controls.Add(childForm);
            // Display the child form
            childForm.Show();
        }
        private void btnRegularServices_Click(object sender, EventArgs e)
        {
            if (regularServices == null)
            {
                regularServices = new RegularServices(this); // Pass sharedData when initializing
            }
            LoadChildForm(regularServices);
        }

        private void btnSeniorCitizen_Click(object sender, EventArgs e)
        {
            LoadChildForm(new SeniorCitizenServices());
        }
    }
}
