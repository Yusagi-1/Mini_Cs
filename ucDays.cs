using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace Mini_Cs
{

    public partial class ucDays : UserControl
    {
        string _day, date, weekdays;
        private DateTime? foundDispositionDateTime;
        private List<DateTime> validDispositionDates = new List<DateTime>();


        public ucDays(string day)
        {
            InitializeComponent();
            _day = day;
            label1.Text = day;
            checkBox1.Hide();
            date = Home._month + "/" + _day + "/" + Home._year;
            LoadDispositionDateForToday();


        }
        private void LoadDispositionDateForToday()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["RecordKeepingConnection"].ConnectionString;

            // SQL query to get the DispositionDateTime for today
            string query = @"
            SELECT DispositionDateTime 
            FROM DispositionDetails 
            WHERE DispositionDateTime IS NOT NULL;"; ; // Filter for today's date

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        bool dateFound = false;

                        while (reader.Read())
                        {
                            if (reader["DispositionDateTime"] != DBNull.Value)
                            {
                                DateTime dispositionDateTime = Convert.ToDateTime(reader["DispositionDateTime"]);
                                string dateToCheck = $"{Home._month}/{_day}/{Home._year}"; // Format the date

                                // Compare with the current date
                                if (dispositionDateTime.ToString("M/d/yyyy") == dateToCheck)
                                {
                                    validDispositionDates.Add(dispositionDateTime);
                                    DisplayDispositionDate(dispositionDateTime);
                                    foundDispositionDateTime = dispositionDateTime;
                                    dateFound = true;
                                    label1.ForeColor = Color.White;
                                   
                                }
                            }
                        }

                        if (!dateFound)
                        {
                            bunifuLabel1.Visible = false; // Hide the label if no matching date is found
                            
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error retrieving dates: {ex.Message}");
                }
            }
        }
        private void DisplayDispositionDate(DateTime dispositionDateTime)
        {

            bunifuLabel1.Text = "Service/s of this Day"; // Display the date in short format
            bunifuLabel1.Visible = true; // Make the label visible
            bunifuLabel1.Enabled = true; // Enable the label
            bunifuPanel1.BackColor = Color.Red;
            

            // Highlight logic
            if (dispositionDateTime.Date == DateTime.Today)
            {
                label1.BackColor = Color.FromArgb(0, 90, 156); // Highlight today's date
            }
            else
            {
                label1.ForeColor = Color.FromArgb(64, 64, 64); // Default color for other days
            }

            
        }

       

        private void Sundays()
        {
            try
            {

                DateTime day = DateTime.Parse(date);
                weekdays = day.ToString("ddd");
                if (weekdays == "Sun")
                {
                    label1.ForeColor = Color.FromArgb(255, 128, 128);
                }
                else
                {
                    label1.ForeColor = Color.FromArgb(64, 64, 64);
                }
                if (day.Date == DateTime.Today)
                {
                    // Change the color to indicate today
                    this.BackColor = Color.FromArgb(0, 90, 156); // Green for today
                    label1.ForeColor = Color.White;
                }
                else
                {
                    // Change the color to a default color for other days
                    this.BackColor = Color.White;
                }
                

            }
            catch (Exception) { }
        }



        private void ucDays_Load(object sender, EventArgs e)
        {
            Sundays();



        }


        private void bunifuPanel1_Click(object sender, EventArgs e)
        {
            DateTime day = DateTime.Parse(date);
            if (checkBox1.Checked == false)
            {
                checkBox1.Checked = true;
                this.BackColor = Color.FromArgb(255, 150, 79);
            }
            else
            {
                checkBox1.Checked = false;
                if (day.Date == DateTime.Today)
                {
                    this.BackColor = Color.FromArgb(0, 90, 156);

                }
                else
                {
                    this.BackColor = Color.White;
                }
            }



        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {
            DisplayInfoCalendar form2 = new DisplayInfoCalendar(validDispositionDates);
            form2.StartPosition = FormStartPosition.CenterScreen;
            form2.LoadDataBasedOnSelection(foundDispositionDateTime.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            form2.ShowDialog(); // Use ShowDialog to open as a modal dialog
        }

    }
}