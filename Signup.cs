using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DP_Project
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void buttonSignup_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text;
            string confirmPassword = textBoxConfirmPassword.Text;
            // Validation
            if (string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                labelError.Text = "All fields are required!";
                return;
            }

            if (password != confirmPassword)
            {
                labelError.Text = "Passwords do not match!";
                return;
            }

            if (password.Length < 6)
            {
                labelError.Text = "Password must be at least 6 characters!";
                return;
            }
            SaveUser();
           
        }
        public async void SaveUser()
        {
            try
            {
                var db = DatabaseConn.Instance;

                // Check if username exists
                var checkParams = new Dictionary<string, object>
                {
                    ["@username"] = textBoxUsername.Text
                };

                int userCount = (int)(await db.ExecuteScalarAsync(
                    "SELECT COUNT(*) FROM User_Table WHERE User_Name = @username",
                    checkParams));

                if (userCount > 0)
                {
                    labelError.Text = "Username already exists!";
                    return;
                }

                // Insert new user
                var insertParams = new Dictionary<string, object>
                {
                    ["@username"] = textBoxUsername.Text,
                    ["@password"] = textBoxPassword.Text
                };

                int rowsAffected = await db.ExecuteNonQueryAsync(
                    @"INSERT INTO User_Table (User_Name, User_Password) 
              VALUES (@username, @password)",
                    insertParams);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Account created successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    Login login = new Login();
                    login.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                await DatabaseConn.Instance.CloseConnectionAsync();
            }
        }
    }
}
