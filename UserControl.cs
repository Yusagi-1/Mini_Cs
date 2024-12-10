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
using System.Security.Cryptography;
using MaterialSkin.Controls;

namespace Mini_Cs
{
    public partial class UserControl : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["RecordKeepingConnection"].ConnectionString;
        public UserControl()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(UserControl));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            materialComboBox1 = new MaterialComboBox();
            bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            bunifuDataGridView1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            materialButton1 = new MaterialButton();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            materialButton2 = new MaterialButton();
            textBox3 = new TextBox();
            materialButton3 = new MaterialButton();
            ((ISupportInitialize)bunifuDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // materialComboBox1
            // 
            materialComboBox1.AutoResize = false;
            materialComboBox1.BackColor = Color.FromArgb(255, 255, 255);
            materialComboBox1.Depth = 0;
            materialComboBox1.DrawMode = DrawMode.OwnerDrawVariable;
            materialComboBox1.DropDownHeight = 174;
            materialComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBox1.DropDownWidth = 121;
            materialComboBox1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBox1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialComboBox1.IntegralHeight = false;
            materialComboBox1.ItemHeight = 43;
            materialComboBox1.Items.AddRange(new object[] { "Admin", "Staff" });
            materialComboBox1.Location = new Point(243, 154);
            materialComboBox1.MaxDropDownItems = 4;
            materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialComboBox1.Name = "materialComboBox1";
            materialComboBox1.Size = new Size(121, 49);
            materialComboBox1.StartIndex = 0;
            materialComboBox1.TabIndex = 0;
            // 
            // bunifuLabel1
            // 
            bunifuLabel1.AllowParentOverrides = false;
            bunifuLabel1.AutoEllipsis = false;
            bunifuLabel1.CursorType = Cursors.Default;
            bunifuLabel1.Font = new Font("Poppins Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bunifuLabel1.Location = new Point(142, 70);
            bunifuLabel1.Name = "bunifuLabel1";
            bunifuLabel1.RightToLeft = RightToLeft.No;
            bunifuLabel1.Size = new Size(78, 26);
            bunifuLabel1.TabIndex = 0;
            bunifuLabel1.Text = "Username:";
            bunifuLabel1.TextAlignment = ContentAlignment.TopLeft;
            bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            bunifuLabel1.Click += bunifuLabel1_Click;
            // 
            // bunifuLabel2
            // 
            bunifuLabel2.AllowParentOverrides = false;
            bunifuLabel2.AutoEllipsis = false;
            bunifuLabel2.CursorType = Cursors.Default;
            bunifuLabel2.Font = new Font("Poppins Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bunifuLabel2.Location = new Point(142, 121);
            bunifuLabel2.Name = "bunifuLabel2";
            bunifuLabel2.RightToLeft = RightToLeft.No;
            bunifuLabel2.Size = new Size(79, 28);
            bunifuLabel2.TabIndex = 1;
            bunifuLabel2.Text = "Password:";
            bunifuLabel2.TextAlignment = ContentAlignment.TopLeft;
            bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel3
            // 
            bunifuLabel3.AllowParentOverrides = false;
            bunifuLabel3.AutoEllipsis = false;
            bunifuLabel3.CursorType = Cursors.Default;
            bunifuLabel3.Font = new Font("Poppins Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bunifuLabel3.Location = new Point(95, 175);
            bunifuLabel3.Name = "bunifuLabel3";
            bunifuLabel3.RightToLeft = RightToLeft.No;
            bunifuLabel3.Size = new Size(142, 28);
            bunifuLabel3.TabIndex = 2;
            bunifuLabel3.Text = "User Access Level:";
            bunifuLabel3.TextAlignment = ContentAlignment.TopLeft;
            bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuDataGridView1
            // 
            bunifuDataGridView1.AllowCustomTheming = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(248, 251, 255);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            bunifuDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            bunifuDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bunifuDataGridView1.BorderStyle = BorderStyle.None;
            bunifuDataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            bunifuDataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(24, 115, 204);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            bunifuDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            bunifuDataGridView1.ColumnHeadersHeight = 40;
            bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.BackColor = Color.FromArgb(248, 251, 255);
            bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(210, 232, 255);
            bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            bunifuDataGridView1.CurrentTheme.BackColor = Color.White;
            bunifuDataGridView1.CurrentTheme.GridColor = Color.FromArgb(221, 238, 255);
            bunifuDataGridView1.CurrentTheme.HeaderStyle.BackColor = Color.DodgerBlue;
            bunifuDataGridView1.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            bunifuDataGridView1.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            bunifuDataGridView1.CurrentTheme.HeaderStyle.SelectionBackColor = Color.FromArgb(24, 115, 204);
            bunifuDataGridView1.CurrentTheme.HeaderStyle.SelectionForeColor = Color.White;
            bunifuDataGridView1.CurrentTheme.Name = null;
            bunifuDataGridView1.CurrentTheme.RowsStyle.BackColor = Color.White;
            bunifuDataGridView1.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            bunifuDataGridView1.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            bunifuDataGridView1.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(210, 232, 255);
            bunifuDataGridView1.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            bunifuDataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            bunifuDataGridView1.EnableHeadersVisualStyles = false;
            bunifuDataGridView1.GridColor = Color.FromArgb(221, 238, 255);
            bunifuDataGridView1.HeaderBackColor = Color.DodgerBlue;
            bunifuDataGridView1.HeaderBgColor = Color.Empty;
            bunifuDataGridView1.HeaderForeColor = Color.White;
            bunifuDataGridView1.Location = new Point(39, 271);
            bunifuDataGridView1.Name = "bunifuDataGridView1";
            bunifuDataGridView1.RowHeadersVisible = false;
            bunifuDataGridView1.RowTemplate.Height = 40;
            bunifuDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            bunifuDataGridView1.Size = new Size(675, 150);
            bunifuDataGridView1.TabIndex = 3;
            bunifuDataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(641, 426);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(64, 36);
            materialButton1.TabIndex = 4;
            materialButton1.Text = "edit";
            materialButton1.Type = MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(243, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(274, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(243, 121);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(274, 23);
            textBox2.TabIndex = 7;
            // 
            // materialButton2
            // 
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(505, 221);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(115, 36);
            materialButton2.TabIndex = 8;
            materialButton2.Text = "Create User";
            materialButton2.Type = MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            materialButton2.Click += materialButton2_Click_1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(479, 434);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(57, 23);
            textBox3.TabIndex = 9;
            // 
            // materialButton3
            // 
            materialButton3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton3.Density = MaterialButton.MaterialButtonDensity.Default;
            materialButton3.Depth = 0;
            materialButton3.HighEmphasis = true;
            materialButton3.Icon = null;
            materialButton3.Location = new Point(543, 426);
            materialButton3.Margin = new Padding(4, 6, 4, 6);
            materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton3.Name = "materialButton3";
            materialButton3.NoAccentTextColor = Color.Empty;
            materialButton3.Size = new Size(90, 36);
            materialButton3.TabIndex = 10;
            materialButton3.Text = "Get Data";
            materialButton3.Type = MaterialButton.MaterialButtonType.Contained;
            materialButton3.UseAccentColor = false;
            materialButton3.UseVisualStyleBackColor = true;
            materialButton3.Click += materialButton3_Click;
            // 
            // UserControl
            // 
            ClientSize = new Size(758, 477);
            Controls.Add(materialButton3);
            Controls.Add(textBox3);
            Controls.Add(materialButton2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(materialComboBox1);
            Controls.Add(materialButton1);
            Controls.Add(bunifuDataGridView1);
            Controls.Add(bunifuLabel3);
            Controls.Add(bunifuLabel2);
            Controls.Add(bunifuLabel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserControl";
            ((ISupportInitialize)bunifuDataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuDataGridView bunifuDataGridView1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private TextBox textBox3;
        private MaterialButton materialButton3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;

        private void MaterialButton2_Click(object sender, EventArgs e)
        {

        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();

                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }

                return builder.ToString();
            }
        }

        private void LoadUsers()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Users", conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    bunifuDataGridView1.DataSource = dt;
                }
            }
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            string userId = textBox3.Text;
            string newUsername = textBox1.Text;
            string newPassword = textBox2.Text;
            string newRole = materialComboBox1.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(userId) && !string.IsNullOrEmpty(newUsername) && !string.IsNullOrEmpty(newRole))
            {
                UpdateUserData(userId, newUsername, newPassword, newRole);
            }
            else
            {
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void materialButton2_Click_1(object sender, EventArgs e)
        {
            string username = textBox1.Text; // Get this from a TextBox
            string password = textBox2.Text; // Get this from a TextBox
            string role = materialComboBox1.SelectedItem.ToString();

            string passwordHash = HashPassword(password);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Users (Username, PasswordHash, Role) VALUES (@Username, @PasswordHash, @Role)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@PasswordHash", passwordHash);
                    cmd.Parameters.AddWithValue("@Role", role);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User saved successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Error saving user. Please try again.");
                    }
                }
            }

            LoadUsers();
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            string userId = textBox3.Text;

            if (!string.IsNullOrEmpty(userId))
            {
                LoadUserData(userId);
            }
            else
            {
                MessageBox.Show("Please enter a User ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void LoadUserData(string userId)
        {
            string query = "SELECT Username, PasswordHash, Role FROM Users WHERE UserID = @UserID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Assuming you have textBoxUsername and textBoxPassword for user details
                                textBox1.Text = reader["Username"].ToString();
                                textBox2.Text = ""; // Clear password field for security
                                materialComboBox1.SelectedItem = reader["Role"].ToString(); // Assuming comboBoxRole has "Admin" and "Staff"
                            }
                            else
                            {
                                MessageBox.Show("User not found.", "Data Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void UpdateUserData(string userId, string username, string password, string role)
        {
            string query = "UPDATE Users SET Username = @Username, Role = @Role" +
                           (string.IsNullOrEmpty(password) ? "" : ", PasswordHash = @PasswordHash") +
                           " WHERE UserID = @UserID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userId);
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Role", role);

                        if (!string.IsNullOrEmpty(password))
                        {
                            // Assuming HashPassword is a method that hashes the password
                            command.Parameters.AddWithValue("@PasswordHash", HashPassword(password));
                        }

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No changes were made.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
