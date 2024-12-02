using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Edukacija
{
    public partial class Login : Form
    {
        public static class CurrentUser
        {
            public static string Role { get; set; }
            public static string Username { get; set; }
        }

        public Login()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GLK4IKI\SQLEXPRESS;Initial Catalog=Edukacija;Integrated Security=SSPI");

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void long_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = long_showPassword.Checked ? '\0' : '*';
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string username = login_username.Text;
            string password = login_password.Text;

            try
            {
                conn.Open();

                string query = @"
            SELECT Role 
            FROM Login_table
            WHERE username = @username AND password = @password
            UNION
            SELECT Role
            FROM AddDeleteLecturer
            WHERE username = @username AND password = @password
            UNION
            SELECT Role
            FROM AddDeleteStudent
            WHERE username = @username AND password = @password";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string role = reader["Role"].ToString();

                    // Store role and username globally
                    CurrentUser.Role = role;
                    CurrentUser.Username = username;

                    this.Hide();

                    // Navigate based on the role
                    switch (role)
                    {
                        case "admin":
                            AdminPanel adminPanel = new AdminPanel();
                            adminPanel.Show();
                            break;

                        case "lecturer":
                            LecturerPanel lecturerPanel = new LecturerPanel();
                            lecturerPanel.Show();
                            break;

                        case "student":
                            StudentPanel studentPanel = new StudentPanel();
                            studentPanel.Show();
                            break;

                        default:
                            MessageBox.Show("Unknown role. Access denied.");
                            this.Show();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }

    }
}