using MaterialSkin.Controls;
using System.Configuration;

using System.Security.Cryptography; // Ensure this using directive is present
using System.Text;
using Microsoft.Data.SqlClient;


namespace Mini_Cs
{
    public partial class LoginForm : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["RecordKeepingConnection"].ConnectionString;

        public LoginForm()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(LoginForm_KeyDown);

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
//AddUser("123", "123", "Manager");
            tbUsername.Focus();
            tbPassword.PasswordChar = '*';
        }
        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();  // Simulate button click
            }
        }

        //ADD USER METHOD USE ONLY IF NO USERS IN DATABASE



        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            var userRole = GetUserRole(username, password);

            if (userRole != null)
            {
                // If valid user, proceed to home page based on role
                HomePage homePage = new HomePage(userRole);
                this.Hide();
                homePage.ShowDialog();
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Function to check if the user exists in the database and get their role
        private string GetUserRole(string username, string password)
        {
            string role = null;
            string query = "SELECT PasswordHash, Role FROM Users WHERE Username = @Username";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Use parameterized query to avoid SQL injection
                        command.Parameters.AddWithValue("@Username", username);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string storedPasswordHash = reader["PasswordHash"].ToString();
                                string enteredPasswordHash = HashPassword(password);
                                role = reader["Role"].ToString();

                                if (storedPasswordHash == enteredPasswordHash)
                                {
                                    return role; // Return the role if the password matches
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return null; // Return null if not valid
        }

        // Hash the entered password using SHA256
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                tbPassword.PasswordChar = '\0';
            }
            else
            {
                tbPassword.PasswordChar = '*';
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}