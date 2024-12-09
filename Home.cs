using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsTimer = System.Windows.Forms.Timer;

namespace Mini_Cs
{
    public partial class Home : Form
    {
        private bool isColonVisible = true; // Track colon visibility
        private bool showSeconds = true;
        public static int _year, _month;
        public Home()
        {
            InitializeComponent();
            UpdateTime();
            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick; // Attach the Tick event
            timer1.Start(); // Start the timer


        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UpdateTime()
        {
            DateTime currentTime = DateTime.Now;
            label1.Text = DateTime.Now.ToString("hh:mm:ss");
            string amPm = currentTime.ToString("tt");
            label2.Text = $"{amPm}";
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("hh:mm:ss");
            timer1.Start();
        }
        private void showDays(int month, int year)
        {
            flowLayoutPanel1.Controls.Clear();
            _year = year;
            _month = month;
            try
            {
                string monthName = new DateTimeFormatInfo().GetMonthName(month);
                label10.Text = monthName.ToUpper() + " " + year;
                DateTime startonTheMonth = new DateTime(year, month, 1);
                int day = DateTime.DaysInMonth(year, month);
                int week = Convert.ToInt32(startonTheMonth.DayOfWeek.ToString("d")) + 1;
                for (int i = 1; i < week; i++)
                {
                    ucDays uc = new ucDays("");
                    flowLayoutPanel1.Controls.Add(uc);
                }
                for (int i = 1; i <= day; i++)
                {
                    ucDays uc = new ucDays(i + "");
                    flowLayoutPanel1.Controls.Add(uc);
                }
            }
            catch (Exception) { }
        }

        private void Home_Load_1(object sender, EventArgs e)
        {
            showDays(DateTime.Now.Month, DateTime.Now.Year);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            _month -= 1;
            if (_month < 1)
            {
                _month = 12;
                _year -= 1;
            }
            showDays(_month, _year);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            _month += 1;
            if (_month == 12)
            {
                _month = 1;
                _year += 1;
            }
            showDays(_month, _year);
        }
    }

}

