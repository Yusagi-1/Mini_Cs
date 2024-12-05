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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            UpdateTime();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void UpdateTime()
        {
            // Get current system time
            DateTime currentTime = DateTime.Now;

            // Format the time to 12-hour format with AM/PM
            string formattedTime = currentTime.ToString("hh:mm tt");

            // Display the time in label1
            label1.Text = formattedTime;
            
        }
    }
}
