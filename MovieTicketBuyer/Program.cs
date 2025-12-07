using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTicketBuyer
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            Login loginForm = new Login();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // Login successful - open main form with authenticated user
                FormMain mainForm = new FormMain(loginForm.AuthenticatedUser);
                Application.Run(mainForm);
            }
            else
            {
                // User cancelled login or closed the form
                Application.Exit();
            }
        }
        }
}
