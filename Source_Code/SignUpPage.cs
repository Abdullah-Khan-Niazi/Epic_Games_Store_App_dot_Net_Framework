using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_LAB_PROJECT_GunaUI
{
    public partial class SignUpPage : UserControl
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            string firstName = FirstNameTextbox.Text.Trim();
            string lastName = LastNameTextBox.Text.Trim();
            string username = UsernameTextBox.Text.Trim();
            string email = emailTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();
            string confirmPassword = confirmPasswordTextBox.Text.Trim();
            string profileImagePath = profileImagePathTextBox.Text.Trim(); // Optional

            // Validate required fields
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            // Check password confirmation
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            // Attempt account creation
            bool success = CreateAccount(firstName, lastName, username, email, password, profileImagePath);
            if (success)
            {
                MessageBox.Show("Account created successfully!");
                ClearFields();
            }
            else
            {
                MessageBox.Show("Account creation failed. Username or email may already be in use.");
            }
        }

        private bool CreateAccount(string firstName, string lastName, string username, string email, string password, string profileImagePath)
        {
            string connectionString = Form1.connectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query;
                    if (string.IsNullOrEmpty(profileImagePath))
                    {
                        query = @"
                         INSERT INTO Users (FirstName, LastName, Username, Email, PasswordHash, Role)
                        VALUES (@FirstName, @LastName, @Username, @Email, @PasswordHash, 'Customer')";
                    }
                    else
                    {
                        query = @"
                        INSERT INTO Users (FirstName, LastName, Username, Email, PasswordHash, Role, ProfileImagePath)
                        VALUES (@FirstName, @LastName, @Username, @Email, @PasswordHash, 'Customer', @ProfileImagePath)";
                    }

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@PasswordHash", password); // Use hashed passwords in production
                    if (!string.IsNullOrEmpty(profileImagePath))
                        cmd.Parameters.AddWithValue("@ProfileImagePath", profileImagePath);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("SQL Error: " + ex.Message);
                    return false;
                }
                conn.Close();  
            }
        }

        private void ClearFields()
        {
            FirstNameTextbox.Clear();
            LastNameTextBox.Clear();
            UsernameTextBox.Clear();
            emailTextBox.Clear();
            passwordTextBox.Clear();
            confirmPasswordTextBox.Clear();
            profileImagePathTextBox.Clear();
        }
    }
}
