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
using FontAwesome.Sharp;
using Color = System.Drawing.Color;

namespace Mini_Cs
{
    public partial class HomePage : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;

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

        private void btnBookFuneral_Click(object sender, EventArgs e)
        {
            ActivatedButton(sender, RGBColors.color1);
        }

        private void btnPromo_Click(object sender, EventArgs e)
        {
            ActivatedButton(sender, RGBColors.color2);
        }

        private void btnCheckRecords_Click(object sender, EventArgs e)
        {
            ActivatedButton(sender, RGBColors.color3);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            ActivatedButton(sender, RGBColors.color4);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            ActivatedButton(sender, RGBColors.color5);
        }
    }
}
