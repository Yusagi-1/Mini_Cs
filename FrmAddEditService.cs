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
    public partial class FrmAddEditService : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["RecordKeepingConnection"].ConnectionString;
        private int? serviceId;
        public FrmAddEditService()
        {
            InitializeComponent();
            LoadCreatedByUsers();
        }
        public FrmAddEditService(int serviceId) : this() // Call the default constructor
        {
            this.serviceId = serviceId;
            LoadServiceData(serviceId); // Load service data for editing
        }
        private void LoadCreatedByUsers()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT UserID, Username FROM Users";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable usersTable = new DataTable();
                adapter.Fill(usersTable);
                cmbCreatedBy.DataSource = usersTable;
                cmbCreatedBy.DisplayMember = "Username";
                cmbCreatedBy.ValueMember = "UserID";
            }
        }
        private void LoadServiceData(int serviceId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT ServiceName, Description, Price, DurationDays, CreatedBy, 
                                IncludesChapel, IncludesCasket, WithAircon, IncludesEmbalming, 
                                IsPresidential, IsFreeChapel 
                                FROM Services WHERE ServiceID = @ServiceID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ServiceID", serviceId);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtServiceName.Text = reader["ServiceName"].ToString();
                    txtDescription.Text = reader["Description"].ToString();
                    txtPrice.Text = reader["Price"].ToString();
                    numDuration.Value = Convert.ToDecimal(reader["DurationDays"]);
                    cmbCreatedBy.SelectedValue = reader["CreatedBy"];

                    cbIncludesChapel.Checked = Convert.ToBoolean(reader["IncludesChapel"]);
                    cbCasket.Checked = Convert.ToBoolean(reader["IncludesCasket"]);
                    cbAircon.Checked = Convert.ToBoolean(reader["WithAircon"]);
                    cbEmbalming.Checked = Convert.ToBoolean(reader["IncludesEmbalming"]);
                    cbPresidential.Checked = Convert.ToBoolean(reader["IsPresidential"]);
                    cbFreeChapel.Checked = Convert.ToBoolean(reader["IsFreeChapel"]);
                }
            }
        }
        private void txtServiceName_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query;

                if (serviceId.HasValue) // Update existing service
                {
                    query = @"UPDATE Services 
                              SET ServiceName = @ServiceName, Description = @Description, Price = @Price, 
                                  DurationDays = @DurationDays, CreatedBy = @CreatedBy, 
                                  IncludesChapel = @IncludesChapel, IncludesCasket = @IncludesCasket, 
                                  WithAircon = @WithAircon, IncludesEmbalming = @IncludesEmbalming, 
                                  IsPresidential = @IsPresidential, IsFreeChapel = @IsFreeChapel 
                              WHERE ServiceID = @ServiceID";
                }
                else // Add new service
                {
                    query = @"INSERT INTO Services 
                              (ServiceName, Description, Price, DurationDays, CreatedBy, 
                               IncludesChapel, IncludesCasket, WithAircon, IncludesEmbalming, 
                               IsPresidential, IsFreeChapel) 
                              VALUES 
                              (@ServiceName, @Description, @Price, @DurationDays, @CreatedBy, 
                               @IncludesChapel, @IncludesCasket, @WithAircon, @IncludesEmbalming, 
                               @IsPresidential, @IsFreeChapel)";
                }

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ServiceName", txtServiceName.Text);
                cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                cmd.Parameters.AddWithValue("@Price", decimal.Parse(txtPrice.Text));
                cmd.Parameters.AddWithValue("@DurationDays", (int)numDuration.Value);
                cmd.Parameters.AddWithValue("@CreatedBy", cmbCreatedBy.SelectedValue);

                // Checkbox values
                cmd.Parameters.AddWithValue("@IncludesChapel", cbIncludesChapel.Checked);
                cmd.Parameters.AddWithValue("@IncludesCasket", cbCasket.Checked);
                cmd.Parameters.AddWithValue("@WithAircon", cbAircon.Checked);
                cmd.Parameters.AddWithValue("@IncludesEmbalming", cbEmbalming.Checked);
                cmd.Parameters.AddWithValue("@IsPresidential", cbPresidential.Checked);
                cmd.Parameters.AddWithValue("@IsFreeChapel", cbFreeChapel.Checked);

                if (serviceId.HasValue)
                    cmd.Parameters.AddWithValue("@ServiceID", serviceId);

                cmd.ExecuteNonQuery();
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbFreeChapel_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbPresidential_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbEmbalming_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbAircon_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbCasket_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbIncludesChapel_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
