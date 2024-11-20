using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using Microsoft.Data.SqlClient;
using System.Configuration;
using FontAwesome.Sharp;
using Color = System.Drawing.Color;

namespace Mini_Cs
{
    public partial class HomePage : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        string connectionString = ConfigurationManager.ConnectionStrings["RecordKeepingConnection"].ConnectionString;
        public HomePage()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelNavBar.Controls.Add(leftBorderBtn);

        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(246, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);


        }
        private void ActivatedButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();

                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //left Border Button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.Transparent;
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            ActivatedButton(sender, RGBColors.color1);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ActivatedButton(sender, RGBColors.color5);
            Application.Exit();
        }

        private void btnAuditLog_Click(object sender, EventArgs e)
        {
            ActivatedButton(sender, RGBColors.color4);
            FrmAuditLog auditLogForm = new FrmAuditLog();
            auditLogForm.TopLevel = false;
            auditLogForm.FormBorderStyle = FormBorderStyle.None;
            auditLogForm.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(auditLogForm);
            auditLogForm.Show();
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            ActivatedButton(sender, RGBColors.color3);
            FrmUserManagement userManagementForm = new FrmUserManagement();
            userManagementForm.TopLevel = false;
            userManagementForm.FormBorderStyle = FormBorderStyle.None;
            userManagementForm.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(userManagementForm);
            userManagementForm.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ActivatedButton(sender, RGBColors.color2);
            FrmReport reportsForm = new FrmReport();
            reportsForm.TopLevel = false;
            reportsForm.FormBorderStyle = FormBorderStyle.None;
            reportsForm.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(reportsForm);
            reportsForm.Show();
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            ActivatedButton(sender, RGBColors.color1);
            FrmTransaction transactionForm = new FrmTransaction();
            transactionForm.TopLevel = false;
            transactionForm.FormBorderStyle = FormBorderStyle.None;
            transactionForm.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(transactionForm);
            transactionForm.Show();
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            ActivatedButton(sender, RGBColors.color5);
            FrmService serviceForm = new FrmService();
            serviceForm.TopLevel = false;
            serviceForm.FormBorderStyle = FormBorderStyle.None;
            serviceForm.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(serviceForm);
            serviceForm.Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            ActivatedButton(sender, RGBColors.color3);
            FrmClient clientForm = new FrmClient();
            clientForm.TopLevel = false;
            clientForm.FormBorderStyle = FormBorderStyle.None;
            clientForm.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(clientForm);
            clientForm.Show();
        }

        private void btnDeceased_Click(object sender, EventArgs e)
        {
            ActivatedButton(sender, RGBColors.color3);
            FrmDeceased deceasedForm = new FrmDeceased();
            deceasedForm.TopLevel = false;
            deceasedForm.FormBorderStyle = FormBorderStyle.None;
            deceasedForm.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(deceasedForm);
            deceasedForm.Show();
        }
    }
}
