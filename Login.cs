using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DP_Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void linkLabelSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
            this.Hide();
        }

        private async Task Implementation()
        {
            try
            {
                string username = textBoxUserName.Text.Trim();
                string password = textBoxPassword.Text;

                // Validate inputs
                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Please enter both username and password.", "Validation Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var db = DatabaseConn.Instance;
                var parameters = new Dictionary<string, object>
                {
                    ["@username"] = username,
                    ["@password"] = password
                };

                // Execute query through adapter
                var result = await db.ExecuteScalarAsync(
                    "SELECT COUNT(*) FROM User_Table WHERE User_Name = @username AND User_Password = @password",
                    parameters);

                int userCount = Convert.ToInt32(result);

                if (userCount > 0)
                {
                    MessageBox.Show("Login successful!", "Success",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);

                    var dashboard = new HomePage { Username = username };
                    textBoxUserName.Clear();
                    textBoxPassword.Clear();

                    this.Hide();
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during login: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            await Implementation();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}