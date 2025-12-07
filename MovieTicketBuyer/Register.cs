using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTicketBuyer
{
    public partial class Register : Form
    {
        private MovieTicketBuyer1DataSet dataSet = new MovieTicketBuyer1DataSet();
        private MovieTicketBuyer1DataSetTableAdapters.UsersTableAdapter usersAdapter =
            new MovieTicketBuyer1DataSetTableAdapters.UsersTableAdapter();
        public Register()


        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            txtConfirmPassword.PasswordChar = '*';

           
            lblPasswordsDontMatch.Visible = false;




            lblPasswordsDontMatch.ForeColor = System.Drawing.Color.Red;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhonenumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPasswordsDontMatch_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text.Trim();
                string email = txtEmail.Text.Trim();
                string phoneNumber = txtPhonenumber.Text.Trim();
                string password = txtPassword.Text;
                string confirmPassword = txtConfirmPassword.Text;

                // Validate username
                if (string.IsNullOrEmpty(username))
                {
                    MessageBox.Show("Username is required.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsername.Focus();
                    return;
                }

                if (username.Length < 3)
                {
                    MessageBox.Show("Username must be at least 3 characters long.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsername.Focus();
                    return;
                }

                // Validate email
                if (string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Email is required.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return;
                }

                if (!IsValidEmail(email))
                {
                    MessageBox.Show("Please enter a valid email address.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return;
                }

                // Validate password
                if (string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Password is required.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Focus();
                    return;
                }

                if (password.Length < 6)
                {
                    MessageBox.Show("Password must be at least 6 characters long.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Focus();
                    return;
                }

                if (password != confirmPassword)
                {
                    MessageBox.Show("Passwords do not match.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtConfirmPassword.Focus();
                    return;
                }

                // Load existing users and check for duplicates
                dataSet.Users.Clear();
                usersAdapter.Fill(dataSet.Users);

                var existingUser = dataSet.Users.FirstOrDefault(u =>
                    u.UserName.Equals(username, StringComparison.OrdinalIgnoreCase));

                if (existingUser != null)
                {
                    MessageBox.Show("Username already exists. Please choose a different username.",
                        "Registration Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Focus();
                    return;
                }

                // Create new user
                var newUserRow = dataSet.Users.NewUsersRow();
                newUserRow.UserName = username;
                newUserRow.Email = email;
                newUserRow.PhoneNumber = string.IsNullOrEmpty(phoneNumber) ? "" : phoneNumber;
                newUserRow.Password = password;
                newUserRow.DateJoined = DateTime.Now;

                dataSet.Users.AddUsersRow(newUserRow);

                // Save to database
                int rowsAffected = usersAdapter.Update(dataSet.Users);

                if (rowsAffected > 0)
                {
                    MessageBox.Show($"Account created successfully!\n\nUsername: {username}\n\nYou can now login.",
                        "Registration Successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to create account. Please try again.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while creating your account:\n\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

    
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}