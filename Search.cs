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
using FontAwesome.Sharp;
using Color = System.Drawing.Color;
using Bunifu.UI.WinForms;
using System.Data.Common;
using System.Text.RegularExpressions;

namespace Mini_Cs
{
    public partial class Search : Form
    {

        string connectionString = ConfigurationManager.ConnectionStrings["RecordKeepingConnection"].ConnectionString;


        public Search()
        {
            InitializeComponent();
            LoadTableNames();
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }
        private void LoadTableNames()
        {
            // Populate ComboBox with table names
            comboBox1.Items.Add("Customers");
            comboBox1.Items.Add("DeceasedInfo");
            comboBox1.Items.Add("ServiceDetails");
            comboBox1.Items.Add("DeathCertification");
            comboBox1.Items.Add("DispositionDetails");
            comboBox1.Items.Add("VehiclesAssigned");
            comboBox1.Items.Add("PlanDetails");
            comboBox1.Items.Add("RegularPaymentDetails");
            comboBox1.Items.Add("SeniorPaymentDetails");
            comboBox1.Items.Add("RepresentativeInfo");
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string selectedTable = comboBox1.SelectedItem.ToString();
                MessageBox.Show($"Loading data from: {selectedTable}"); // Debug message
                LoadData(selectedTable);
            }
        }

        private void LoadData(string tableName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // This query selects all rows and columns from the selected table
                string query = $"SELECT * FROM [{tableName}]"; // Use brackets for safety
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    dataAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        bunifuDataGridView1.DataSource = dataTable; // Bind the data to the DataGridView
                    }
                    else
                    {
                        MessageBox.Show("No data found in the selected table.");
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show($"SQL Error: {sqlEx.Message} \nQuery: {query}"); // Show the query
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading data: {ex.Message}");
                }
            }
        }


        private void materialButton1_Click(object sender, EventArgs e)
        {
            string selectedTable = comboBox1.SelectedItem?.ToString() ?? "DeceasedInfo";
            LoadData(selectedTable);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string deceasedName = bunifuTextBox1.Text.Trim();
            string customerId = bunifuTextBox1.Text.Trim();
            SearchDeceasedDetails(deceasedName, customerId);
        }
        private void SearchDeceasedDetails(string name, string customerId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // SQL query to join tables and filter by the deceased's name or CustomerID
                string query = @"
        SELECT 
            d.CustomerID, d.Name, d.Address, d.Gender, d.CivilStatus, d.Birthdate, 
            dd.DispositionManner, dd.DispositionPlace, dd.DispositionDateTime,
            pd.PlanHolderName, pd.PlanNo, pd.Company, pd.PlanType
        FROM 
            DeceasedInfo d
        LEFT JOIN 
            DispositionDetails dd ON d.CustomerID = dd.CustomerID
        LEFT JOIN 
            PlanDetails pd ON d.CustomerID = pd.CustomerID
        WHERE 
            d.Name LIKE @Name OR d.CustomerID = @CustomerID";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@Name", "%" + name + "%");
                int customerIDValue;
                if (int.TryParse(customerId, out customerIDValue))
                {
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@CustomerID", customerIDValue);
                }
                else
                {
                    // Handle the case where customerId is not a valid integer
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@CustomerID", DBNull.Value);
                }

                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    dataAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        bunifuDataGridView1.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("No records found for the specified criteria.");
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show($"SQL Error: {sqlEx.Message} \nQuery: {query}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading data: {ex.Message}");
                }
            }
        }

        private void Search_Load(object sender, EventArgs e)
        {
            LoadInitialData();
        }
        private void LoadInitialData()
        {
            LoadData("DeceasedInfo");
        }

        private void bunifuDataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Get the updated value from the cell

        }

        private void bunifuDataGridView1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadTableData(string tableName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = $"SELECT * FROM {tableName}"; // Query to select all data from the specified table
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Set the DataGridView's data source to the retrieved DataTable
                    bunifuDataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading data: {ex.Message}");
                }
            }
        }
        private void materialButton2_Click_1(object sender, EventArgs e)
        {
            {
                string customerId = bunifuTextBox1.Text.Trim();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Check if CustomerID exists in the DeceasedInfo table
                    string query = "SELECT COUNT(*) FROM DeceasedInfo WHERE CustomerID = @CustomerID";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CustomerID", customerId);

                    try
                    {
                        connection.Open();
                        int count = (int)command.ExecuteScalar();

                        if (string.IsNullOrWhiteSpace(bunifuTextBox1.Text))
                        {
                            MessageBox.Show("Please enter a valid CustomerID.");
                        }
                        else if (!Regex.IsMatch(bunifuTextBox1.Text, @"^\d+$")) // Check for numeric input only
                        {
                            MessageBox.Show("Please enter a valid CustomerID (numeric values only).");
                        }
                        else if (count > 0) // Ensure 'count' is defined earlier in your code
                        {
                            // Open Form2 and pass the CustomerID
                            Edit form2 = new Edit(customerId);
                            form2.StartPosition = FormStartPosition.CenterScreen;
                            form2.Show();
                        }
                        else
                        {
                            MessageBox.Show("No customer found with the provided CustomerID.");
                        }
                    }
                    catch (SqlException sqlEx)
                    {
                        MessageBox.Show("Please enter a valid CustomerID (numeric values only).");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading data: {ex.Message}");
                    }
                }
            }
        }

        private void bunifuDataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
