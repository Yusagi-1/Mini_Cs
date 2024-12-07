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
    public partial class Deceased : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["RecordKeepingConnection"].ConnectionString;

        public Deceased()
        {
            InitializeComponent();
        }

        private void txtName_Click(object sender, EventArgs e)
        {

        }

        private void txtAddress_Click(object sender, EventArgs e)
        {

        }

        private void cbCivilStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPwd_Click(object sender, EventArgs e)
        {

        }

        private void dpBirthdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dpDateofDeath_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    
                    string query = @"
                        INSERT INTO DeceasedInfo (Name, Address, Gender, CivilStatus, Birthdate, OSCAPWDID, DateOfDeath) 
                        VALUES (@Name, @Address, @Gender, @CivilStatus, @Birthdate, @OSCAPWDID, @DateOfDeath)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                      
                        command.Parameters.AddWithValue("@Name", txtName.Text);
                        command.Parameters.AddWithValue("@Address", txtAddress.Text);
                        command.Parameters.AddWithValue("@Gender", cbGender.SelectedItem?.ToString());
                        command.Parameters.AddWithValue("@CivilStatus", cbCivilStatus.SelectedItem?.ToString());
                        command.Parameters.AddWithValue("@Birthdate", dpBirthdate.Value);
                        command.Parameters.AddWithValue("@OSCAPWDID", txtPwd.Text);
                        command.Parameters.AddWithValue("@DateOfDeath", dpDateofDeath.Value);

                       
                        connection.Open();
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Deceased information saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to save deceased information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
