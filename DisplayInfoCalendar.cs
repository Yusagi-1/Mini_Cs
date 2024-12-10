using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Configuration;


namespace Mini_Cs
{
    public partial class DisplayInfoCalendar : Form
    {
        private List<DateTime> validDispositionDates = new List<DateTime>();
        public DisplayInfoCalendar(List<DateTime> validDispositionDates)
        {
            InitializeComponent();
            this.validDispositionDates = validDispositionDates;
            LoadDispositionDateTimes();

        }
        private void LoadDispositionDateTimes()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["RecordKeepingConnection"].ConnectionString;

            string query = @"
            SELECT DISTINCT dd.DispositionDateTime
            FROM DispositionDetails dd
            JOIN DeceasedInfo di ON di.DeceasedId = dd.DispositionID;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    HashSet<DateTime> uniqueDates = new HashSet<DateTime>(validDispositionDates); // Use HashSet for fast lookup
                    while (reader.Read())
                    {
                        DateTime dispositionDateTime = Convert.ToDateTime(reader["DispositionDateTime"]);

                        // Only add to comboBox1 if the date is in the validDates list
                        if (uniqueDates.Contains(dispositionDateTime))
                        {
                            comboBox1.Items.Add(dispositionDateTime.ToString("g")); // Add the valid date to the comboBox
                        }
                    }
                }
            }
        }
        public void LoadDataBasedOnSelection(string selectedDateTime)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["RecordKeepingConnection"].ConnectionString;

            string query = @"
SELECT 
    di.Name,
    di.Address,
    di.Gender,
    di.Birthdate,
    di.DateOfDeath,
    dd.DispositionManner,
    dd.DispositionPlace,
    dd.DispositionDateTime,
    pd.PlanType,
    td.Status,
    ri.PrimaryTelMobile,  -- Added PrimaryTelMobile
    ri.SecondaryTelMobile  -- Added SecondaryTelMobile
FROM 
    DeceasedInfo di
JOIN 
    DispositionDetails dd ON di.DeceasedID = dd.CustomerID  -- Ensure correct foreign key relationship
JOIN 
    PlanDetails pd ON di.DeceasedID = pd.CustomerID  -- Ensure correct foreign key relationship
JOIN 
    TransactionDetails td ON di.DeceasedID = td.CustomerID  -- Join with TransactionDetails
JOIN 
    RepresentativeInfo ri ON di.DeceasedID = ri.CustomerID  -- Join with RepresentativeInfo
WHERE 
    dd.DispositionDateTime = @DispositionDateTime;";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DispositionDateTime", Convert.ToDateTime(selectedDateTime)); // Add parameter to prevent SQL injection
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Assigning values to the labels
                        label11.Text = reader["Name"].ToString();
                        label12.Text = reader["Address"].ToString();
                        label13.Text = reader["Gender"].ToString();
                        label14.Text = Convert.ToDateTime(reader["Birthdate"]).ToShortDateString();
                        label15.Text = reader["DateOfDeath"] is DBNull ? "" : Convert.ToDateTime(reader["DateOfDeath"]).ToShortDateString();
                        label16.Text = reader["PlanType"].ToString();
                        label17.Text = reader["DispositionManner"].ToString();
                        label18.Text = reader["DispositionPlace"].ToString();
                        label19.Text = Convert.ToDateTime(reader["DispositionDateTime"]).ToString("g"); // General date/time pattern
                        label21.Text = reader["Status"].ToString();
                        label23.Text = reader["PrimaryTelMobile"].ToString(); // Assign PrimaryTelMobile to label23
                        label25.Text = reader["SecondaryTelMobile"].ToString(); // Assign SecondaryTelMobile to label25

                    }
                    else
                    {
                        MessageBox.Show("No data found for the selected Disposition DateTime.");
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataBasedOnSelection(comboBox1.Text.ToString());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DisplayInfoCalendar_Load(object sender, EventArgs e)
        {
        }
    }
}
