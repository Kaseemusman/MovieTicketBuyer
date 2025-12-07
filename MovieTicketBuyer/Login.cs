using MovieTicketBuyer.Models;
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
    public partial class Login : Form
    {

        public User AuthenticatedUser { get; private set; }


        
        private MovieTicketBuyer1DataSet dataSet = new MovieTicketBuyer1DataSet();
        private MovieTicketBuyer1DataSetTableAdapters.TicketsTableAdapter ticketsAdapter =
            new MovieTicketBuyer1DataSetTableAdapters.TicketsTableAdapter();
        private MovieTicketBuyer1DataSetTableAdapters.MoviesTableAdapter moviesAdapter =
            new MovieTicketBuyer1DataSetTableAdapters.MoviesTableAdapter();
        private MovieTicketBuyer1DataSetTableAdapters.TheatersTableAdapter theatersAdapter =
            new MovieTicketBuyer1DataSetTableAdapters.TheatersTableAdapter();
        private MovieTicketBuyer1DataSetTableAdapters.UsersTableAdapter usersAdapter =
            new MovieTicketBuyer1DataSetTableAdapters.UsersTableAdapter();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (txtPassword != null)
            {
                txtPassword.PasswordChar = '*';
            }

            this.AcceptButton = btnLogin;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text;

                if (string.IsNullOrEmpty(username))
                {
                    MessageBox.Show("Please enter a username.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsername.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please enter a password.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Focus();
                    return;
                }

               
                usersAdapter.Fill(dataSet.Users);

              
                var userRow = dataSet.Users.FirstOrDefault(u =>
                    u.UserName.Equals(username, StringComparison.OrdinalIgnoreCase) &&
                    !u.IsPasswordNull() &&
                    u.Password == password);

                if (userRow != null)
                {
                 
                    AuthenticatedUser = new User(userRow.UserName, userRow.Password);

                    MessageBox.Show($"Welcome, {userRow.UserName}!", "Login Successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                 
                    MessageBox.Show("Invalid username or password. Please try again.", "Login Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtPassword.Clear();
                    txtPassword.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during login: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            if (registerForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Registration successful! You can now login with your new account.",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
