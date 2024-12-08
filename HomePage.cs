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
using Mini_Cs.Goite_Added_frmChildForms;

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
            public static Color colorb = Color.FromArgb(0, 0, 0);


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
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Black;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            ActivatedButton(sender, RGBColors.color1);
            Home home = new Home();
            home.TopLevel = false;
            home.FormBorderStyle = FormBorderStyle.None;
            home.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(home);
            home.Show();

        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            ActivatedButton(sender, RGBColors.color5);
            Application.Exit();
        }

        private void btnCustomer_Click_1(object sender, EventArgs e)
        {
            ActivatedButton(sender, RGBColors.color1);
            Customers customer = new Customers();
            customer.TopLevel = false;
            customer.FormBorderStyle = FormBorderStyle.None;
            customer.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(customer);
            customer.Show();


        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
