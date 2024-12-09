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
        public CustomerData sharedData;
        public Payment(CustomerData data)
        {
            InitializeComponent();
            sharedData = data ?? new CustomerData();
            InitializeChildForms();
           
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }
        private void InitializeChildForms()
        {
            //PaymentDetailsData paymentDetails = sharedData.PaymentDetails ?? new PaymentDetailsData();
           // regularServices = new RegularServices(this, paymentDetails, sharedData); // Ensure all parameters are passed

            //LoadChildForm(regularServices);
            regularServices = new RegularServices(this, sharedData.PaymentDetails, sharedData);
            LoadChildForm(regularServices);

        }
        private void LoadChildForm(Form childForm)
        {
            panelChildForm.Controls.Clear();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            childForm.Show();
        }

        private void btnSeniorCitizen_Click(object sender, EventArgs e)
        {
            LoadChildForm(new SeniorCitizenServices(this, sharedData.SeniorPaymentDetails, sharedData));

        }

        private void btnRegularServices_Click(object sender, EventArgs e)
        {
            //PaymentDetailsData paymentDetails = sharedData.PaymentDetails ?? new PaymentDetailsData();
            //RegularServices regularServices = new RegularServices(this, paymentDetails, sharedData);
            //LoadChildForm(regularServices);
            LoadChildForm(new RegularServices(this, sharedData.PaymentDetails, sharedData));


        }
        public void OpenFormInPanel(Form childForm)
        {
            panelChildForm.Controls.Clear();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            childForm.Show();
        }

    }
}
