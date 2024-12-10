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

    public partial class Edit : Form
    {
        private string customerId;
        private string selectedTable;
        string connectionString = ConfigurationManager.ConnectionStrings["RecordKeepingConnection"].ConnectionString;
        public Edit(string customerId)
        {
            InitializeComponent();
            LoadComboBoxItems();
            this.StartPosition = FormStartPosition.CenterScreen;
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            this.customerId = customerId;
            this.selectedTable = selectedTable;
            PreLoadData(customerId);
            LoadData(customerId);
        }
        private void LoadComboBoxItems()
        {
            // Add table names to the ComboBox
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
        private void LoadData(string customerId)
        {
            // Load initial data based on the CustomerID
            if (comboBox1.SelectedItem != null)
            {
                string selectedTable = comboBox1.SelectedItem.ToString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = $"SELECT * FROM {selectedTable} WHERE CustomerID = @customerId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@customerId", customerId);
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            // Populate textboxes based on the selected table
                            PopulateTextBoxes(selectedTable, reader);
                        }
                    }
                }
            }
        }

        private void PopulateTextBoxes(string selectedTable, SqlDataReader reader)
        {
            switch (selectedTable)
            {
                case "DeceasedInfo":
                    textBox1.Text = reader["CustomerID"].ToString();
                    textBox2.Text = reader["Name"].ToString();
                    textBox3.Text = reader["Address"].ToString();
                    textBox4.Text = reader["Gender"].ToString();
                    textBox5.Text = reader["CivilStatus"].ToString();
                    textBox6.Text = reader["Birthdate"].ToString();
                    textBox7.Text = reader["OSCAPWDID"].ToString();
                    textBox8.Text = reader["DateOfDeath"].ToString();
                    break;
                case "ServiceDetails":
                    textBox1.Text = reader["CustomerID"].ToString();
                    textBox2.Text = reader["CasketCode"].ToString();
                    textBox3.Text = reader["Autopsy"].ToString();
                    textBox4.Text = reader["UrnCode"].ToString();
                    textBox5.Text = reader["ViewingPlace"].ToString();
                    textBox6.Text = reader["EmbalmingDays"].ToString();
                    break;
                case "DeathCertification":
                    textBox1.Text = reader["CustomerID"].ToString();
                    textBox2.Text = reader["IssuedBy"].ToString();
                    break;
                case "DispositionDetails":
                    textBox1.Text = reader["CustomerID"].ToString();
                    textBox2.Text = reader["DispositionManner"].ToString();
                    textBox3.Text = reader["DispositionPlace"].ToString();
                    textBox4.Text = reader["DispositionDateTime"].ToString();
                    break;
                case "VehiclesAssigned":
                    textBox1.Text = reader["CustomerID"].ToString();
                    textBox2.Text = reader["VehicleType"].ToString();
                    textBox3.Text = reader["DateReceivedByRepresentative"].ToString();
                    break;
                case "PlanDetails":
                    textBox1.Text = reader["CustomerID"].ToString();
                    textBox2.Text = reader["PlanHolderName"].ToString();
                    textBox3.Text = reader["PlanNo"].ToString();
                    textBox4.Text = reader["Company"].ToString();
                    textBox5.Text = reader["PlanType"].ToString();
                    break;
                case "RegularPaymentDetails":
                    textBox1.Text = reader["CustomerID"].ToString();
                    textBox2.Text = reader["GrossPrice"].ToString();
                    textBox3.Text = reader["PlanValue"].ToString();
                    textBox4.Text = reader["ExtraCharges"].ToString();
                    textBox5.Text = reader["Discount"].ToString();
                    textBox6.Text = reader["ContractPrice"].ToString();
                    textBox7.Text = reader["VAT"].ToString();
                    textBox8.Text = reader["VATableSales"].ToString();
                    break;
                case "SeniorPaymentDetails":
                    textBox1.Text = reader["CustomerID"].ToString();
                    textBox2.Text = reader["GrossPrice"].ToString();
                    textBox3.Text = reader["PlanValue"].ToString();
                    textBox4.Text = reader["ExtraCharges"].ToString();
                    textBox5.Text = reader["TotalVATExempt"].ToString();
                    textBox6.Text = reader["SCDiscount"].ToString();
                    textBox7.Text = reader["AdditionalDiscount"].ToString();
                    textBox8.Text = reader["ContractPrice"].ToString();
                    break;
                case "RepresentativeInfo":
                    textBox1.Text = reader["CustomerID"].ToString();
                    textBox2.Text = reader["PrimaryName"].ToString();
                    textBox3.Text = reader["PrimaryRelationship"].ToString();
                    textBox4.Text = reader["PrimaryAddress"].ToString();
                    textBox5.Text = reader["PrimaryTelMobile"].ToString();
                    textBox6.Text = reader["PrimaryEmail"].ToString();
                    textBox7.Text = reader["PrimaryDate"].ToString();
                    textBox8.Text = reader["SecondaryName"].ToString();
                    textBox9.Text = reader["SecondaryRelationship"].ToString();
                    textBox10.Text = reader["SecondaryAddress"].ToString();
                    textBox11.Text = reader["SecondaryTelMobile"].ToString();
                    textBox12.Text = reader["SecondaryEmail"].ToString();
                    textBox13.Text = reader["SecondaryDate"].ToString();
                    break;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void HideAllControls()
        {
            for (int i = 1; i <= 13; i++)
            {
                this.Controls["bunifuLabel" + i].Visible = false;
                this.Controls["textBox" + i].Visible = false;
            }
        }

        private void ShowControls(Control[] controls)
        {
            foreach (var control in controls)
            {
                control.Visible = true;
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData(customerId);
            // Hide all labels and textboxes initially
            HideAllControls();

            // Set labels and show controls based on the selected table
            switch (comboBox1.SelectedItem.ToString())
            {
                case "DeceasedInfo":
                    SetLabels(new[] { "Customer ID", "Name", "Address", "Gender", "Civil Status", "Birthdate", "OSCAPWD ID", "Date of Death" });
                    ShowControls(new Control[] { bunifuLabel1, textBox1, bunifuLabel2, textBox2, bunifuLabel3, textBox3, bunifuLabel4, textBox4, bunifuLabel5, textBox5, bunifuLabel6, textBox6, bunifuLabel7, textBox7, bunifuLabel8, textBox8 });
                    break;
                case "ServiceDetails":
                    SetLabels(new[] { "Customer ID", "Casket Code", "Autopsy", "Urn Code", "Viewing Place", "Embalming Days" });
                    ShowControls(new Control[] { bunifuLabel1, textBox1, bunifuLabel2, textBox2, bunifuLabel3, textBox3, bunifuLabel4, textBox4, bunifuLabel5, textBox5, textBox6 });
                    break;
                case "DeathCertification":
                    SetLabels(new[] { "Customer ID", "Issued By" });
                    ShowControls(new Control[] { bunifuLabel1, textBox1, bunifuLabel2, textBox2 });
                    break;
                case "DispositionDetails":
                    SetLabels(new[] { "Customer ID", "Disposition Manner", "Disposition Place", "Disposition D/T" });
                    ShowControls(new Control[] { bunifuLabel1, textBox1, bunifuLabel2, textBox2, bunifuLabel3, textBox3, textBox4 });
                    break;
                case "VehiclesAssigned":
                    SetLabels(new[] { "Customer ID", "Vehicle Type", "Date Received" });
                    ShowControls(new Control[] { bunifuLabel1, textBox1, bunifuLabel2, textBox2, textBox3 });
                    break;
                case "PlanDetails":
                    SetLabels(new[] { "Customer ID", "Plan Holder Name", "Plan No", "Company", "Plan Type" });
                    ShowControls(new Control[] { bunifuLabel1, textBox1, bunifuLabel2, textBox2, bunifuLabel3, textBox3, bunifuLabel4, textBox4, textBox5 });
                    break;
                case "RegularPaymentDetails":
                    SetLabels(new[] { "Customer ID", "Gross Price", "Plan Value", "Extra Charges", "Discount", "Contract Price", "VAT", "VATable Sales" });
                    ShowControls(new Control[] { bunifuLabel1, textBox1, bunifuLabel2, textBox2, bunifuLabel3, textBox3, bunifuLabel4, textBox4, bunifuLabel5, textBox5, bunifuLabel6, textBox6, textBox7, textBox8 });
                    break;
                case "SeniorPaymentDetails":
                    SetLabels(new[] { "Customer ID", "Gross Price", "Plan Value", "Extra Charges", "Total VAT Exempt", "SC Discount", "Additional Discount", "Contract Price" });
                    ShowControls(new Control[] { bunifuLabel1, textBox1, bunifuLabel2, textBox2, bunifuLabel3, textBox3, bunifuLabel4, textBox4, bunifuLabel5, textBox5, textBox6, textBox7, textBox8 });
                    break;
                case "RepresentativeInfo":
                    SetLabels(new[] { "Customer ID", "Primary Name", "Primary Relationship", "Primary Address", "Primary Tel/Mobile", "Primary Email", "Primary Date", "Secondary Name", "Secondary R/S", "Secondary Address", "Secondary Tel/Mobile", "Secondary Email", "Secondary Date" });
                    ShowControls(new Control[] { bunifuLabel1, textBox1, bunifuLabel2, textBox2, bunifuLabel3, textBox3, bunifuLabel4, textBox4, bunifuLabel5, textBox5, bunifuLabel6, textBox6, bunifuLabel7, textBox7, bunifuLabel8, textBox8, textBox9, textBox10, textBox11, textBox12, textBox13 });
                    break;
            }


        }

        private void SetLabels(string[] labels)
        {
            for (int i = 0; i < labels.Length; i++)
            {
                this.Controls["bunifuLabel" + (i + 1)].Text = labels[i];
                this.Controls["bunifuLabel" + (i + 1)].Visible = true;
            }
        }

        private void PreLoadData(string customerId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM DeceasedInfo WHERE CustomerID = @CustomerID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustomerID", customerId);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Set the text boxes based on the data read
                        SetTextBoxes(new[]
                        {
                        reader["CustomerID"].ToString(),
                        reader["Name"].ToString(),
                        reader["Address"].ToString(),
                        reader["Gender"].ToString(),
                        reader["CivilStatus"].ToString(),
                        reader["Birthdate"].ToString(),
                        reader["OSCAPWDID"].ToString(),
                        reader["DateOfDeath"].ToString()
                    });

                        // Show the text boxes
                        ShowControls(new Control[]
                        {
                        textBox1,
                        textBox2,
                        textBox3,
                        textBox4,
                        textBox5,
                        textBox6,
                        textBox7,
                        textBox8
                        });
                    }
                    else
                    {
                        MessageBox.Show("No data found for the specified CustomerID.");
                    }

                    reader.Close();
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show($"SQL Error: {sqlEx.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading data: {ex.Message}");
                }
            }
        }

        private void SetTextBoxes(string[] values)
        {
            if (values.Length >= 8)
            {
                // Assuming textBox1 to textBox8 are the TextBoxes for display
                textBox1.Text = values[0]; // Customer ID
                textBox2.Text = values[1]; // Name
                textBox3.Text = values[2]; // Address
                textBox4.Text = values[3]; // Gender
                textBox5.Text = values[4]; // Civil Status
                textBox6.Text = values[5]; // Birthdate
                textBox7.Text = values[6]; // OSCAPWD ID
                textBox8.Text = values[7]; // Date of Death
            }
        }


        private void materialButton1_Click(object sender, EventArgs e)
        {
            // Check if a table is selected
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a table from the ComboBox to update data.");
                return;
            }

            string selectedTable = comboBox1.SelectedItem.ToString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = $"UPDATE {selectedTable} SET ";

                // Build the update query based on the selected table
                switch (selectedTable)
                {
                    case "DeceasedInfo":
                        query += $"Name = @name, Address = @address, Gender = @gender, CivilStatus = @civilStatus, " +
                                  $"Birthdate = @birthdate, OSCAPWDID = @oscapwdid, DateOfDeath = @dateOfDeath " +
                                  $"WHERE CustomerID = @customerId";
                        break;
                    case "ServiceDetails":
                        query += $"CasketCode = @casketCode, Autopsy = @autopsy, UrnCode = @urnCode, " +
                                  $"ViewingPlace = @viewingPlace, EmbalmingDays = @embalmingDays " +
                                  $"WHERE CustomerID = @customerId";
                        break;
                    case "DeathCertification":
                        query += $"IssuedBy = @issuedBy WHERE CustomerID = @customerId";
                        break;
                    case "DispositionDetails":
                        query += $"DispositionManner = @dispositionManner, DispositionPlace = @dispositionPlace, " +
                                  $"DispositionDateTime = @dispositionDateTime WHERE CustomerID = @customerId";
                        break;
                    case "VehiclesAssigned":
                        query += $"VehicleType = @vehicleType, DateReceivedByRepresentative = @dateReceived WHERE CustomerID = @customerId";
                        break;
                    case "PlanDetails":
                        query += $"PlanHolderName = @planHolderName, PlanNo = @planNo, Company = @company, " +
                                  $"PlanType = @planType WHERE CustomerID = @customerId";
                        break;
                    case "RegularPaymentDetails":
                        query += $"GrossPrice = @grossPrice, PlanValue = @planValue, ExtraCharges = @extraCharges, " +
                                  $"Discount = @discount, ContractPrice = @contractPrice, VAT = @vat, " +
                                  $"VATableSales = @vatableSales WHERE CustomerID = @customerId";
                        break;
                    case "SeniorPaymentDetails":
                        query += $"GrossPrice = @grossPrice, PlanValue = @planValue, ExtraCharges = @extraCharges, " +
                                  $"TotalVATExempt = @totalVATExempt, SCDiscount = @scDiscount, " +
                                  $"AdditionalDiscount = @additionalDiscount, ContractPrice = @contractPrice " +
                                  $"WHERE CustomerID = @customerId";
                        break;
                    case "RepresentativeInfo":
                        query += $"PrimaryName = @primaryName, PrimaryRelationship = @primaryRelationship, " +
                                  $"PrimaryAddress = @primaryAddress, PrimaryTelMobile = @primaryTelMobile, " +
                                  $"PrimaryEmail = @primaryEmail, PrimaryDate = @primaryDate, " +
                                  $"SecondaryName = @secondaryName, SecondaryRelationship = @secondaryRelationship, " +
                                  $"SecondaryAddress = @secondaryAddress, SecondaryTelMobile = @secondaryTelMobile, " +
                                  $"SecondaryEmail = @secondaryEmail, SecondaryDate = @secondaryDate " +
                                  $"WHERE CustomerID = @customerId";
                        break;
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters based on the selected table
                    command.Parameters.AddWithValue("@customerId", customerId);
                    switch (selectedTable)
                    {
                        case "DeceasedInfo":
                            command.Parameters.AddWithValue("@name", textBox2.Text);
                            command.Parameters.AddWithValue("@address", textBox3.Text);
                            command.Parameters.AddWithValue("@gender", textBox4.Text);
                            command.Parameters.AddWithValue("@civilStatus", textBox5.Text);
                            command.Parameters.AddWithValue("@birthdate", textBox6.Text);
                            command.Parameters.AddWithValue("@oscapwdid", textBox7.Text);
                            command.Parameters.AddWithValue("@dateOfDeath", textBox8.Text);
                            break;
                        case "ServiceDetails":
                            command.Parameters.AddWithValue("@casketCode", textBox2.Text);
                            command.Parameters.AddWithValue("@autopsy", textBox3.Text);
                            command.Parameters.AddWithValue("@urnCode", textBox4.Text);
                            command.Parameters.AddWithValue("@viewingPlace", textBox5.Text);
                            command.Parameters.AddWithValue("@embalmingDays", textBox6.Text);
                            break;
                        case "DeathCertification":
                            command.Parameters.AddWithValue("@issuedBy", textBox2.Text);
                            break;
                        case "DispositionDetails":
                            command.Parameters.AddWithValue("@dispositionManner", textBox2.Text);
                            command.Parameters.AddWithValue("@dispositionPlace", textBox3.Text);
                            command.Parameters.AddWithValue("@dispositionDateTime", textBox4.Text);
                            break;
                        case "VehiclesAssigned":
                            command.Parameters.AddWithValue("@vehicleType", textBox2.Text);
                            command.Parameters.AddWithValue("@dateReceived", textBox3.Text);
                            break;
                        case "PlanDetails":
                            command.Parameters.AddWithValue("@planHolderName", textBox2.Text);
                            command.Parameters.AddWithValue("@planNo", textBox3.Text);
                            command.Parameters.AddWithValue("@company", textBox4.Text);
                            command.Parameters.AddWithValue("@planType", textBox5.Text);
                            break;
                        case "RegularPaymentDetails":
                            command.Parameters.AddWithValue("@grossPrice", textBox2.Text);
                            command.Parameters.AddWithValue("@planValue", textBox3.Text);
                            command.Parameters.AddWithValue("@extraCharges", textBox4.Text);
                            command.Parameters.AddWithValue("@discount", textBox5.Text);
                            command.Parameters.AddWithValue("@contractPrice", textBox6.Text);
                            command.Parameters.AddWithValue("@vat", textBox7.Text);
                            command.Parameters.AddWithValue("@vatableSales", textBox8.Text);
                            break;
                        case "SeniorPaymentDetails":
                            command.Parameters.AddWithValue("@grossPrice", textBox2.Text);
                            command.Parameters.AddWithValue("@planValue", textBox3.Text);
                            command.Parameters.AddWithValue("@extraCharges", textBox4.Text);
                            command.Parameters.AddWithValue("@totalVATExempt", textBox5.Text);
                            command.Parameters.AddWithValue("@scDiscount", textBox6.Text);
                            command.Parameters.AddWithValue("@additionalDiscount", textBox7.Text);
                            command.Parameters.AddWithValue("@contractPrice", textBox8.Text);
                            break;
                        case "RepresentativeInfo":
                            command.Parameters.AddWithValue("@primaryName", textBox2.Text);
                            command.Parameters.AddWithValue("@primaryRelationship", textBox3.Text);
                            command.Parameters.AddWithValue("@primaryAddress", textBox4.Text);
                            command.Parameters.AddWithValue("@primaryTelMobile", textBox5.Text);
                            command.Parameters.AddWithValue("@primaryEmail", textBox6.Text);
                            command.Parameters.AddWithValue("@primaryDate", textBox7.Text);
                            command.Parameters.AddWithValue("@secondaryName", textBox8.Text);
                            command.Parameters.AddWithValue("@secondaryRelationship", textBox9.Text);
                            command.Parameters.AddWithValue("@secondaryAddress", textBox10.Text);
                            command.Parameters.AddWithValue("@secondaryTelMobile", textBox11.Text);
                            command.Parameters.AddWithValue("@secondaryEmail", textBox12.Text);
                            command.Parameters.AddWithValue("@secondaryDate", textBox13.Text);
                            break;
                    }

                    // Execute the update command
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Data updated successfully.");
        }




        private void Edit_Load_1(object sender, EventArgs e)
        {

            HideAllControls();
            SetLabels(new[] { "Customer ID", "Name", "Address", "Gender", "Civil Status", "Birthdate", "OSCAPWD ID", "Date of Death" });
            ShowControls(new Control[] { bunifuLabel1, textBox1, bunifuLabel2, textBox2, bunifuLabel3, textBox3, bunifuLabel4, textBox4, bunifuLabel5, textBox5, bunifuLabel6, textBox6, bunifuLabel7, textBox7, bunifuLabel8, textBox8 });
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
