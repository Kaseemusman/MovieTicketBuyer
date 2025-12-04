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

        private User currentUser;
        private MovieTicketBuyer1DataSet dataSet = new MovieTicketBuyer1DataSet();
        private MovieTicketBuyer1DataSetTableAdapters.TicketsTableAdapter ticketsAdapter =
            new MovieTicketBuyer1DataSetTableAdapters.TicketsTableAdapter();
        private MovieTicketBuyer1DataSetTableAdapters.MoviesTableAdapter moviesAdapter =
            new MovieTicketBuyer1DataSetTableAdapters.MoviesTableAdapter();
        private MovieTicketBuyer1DataSetTableAdapters.TheatersTableAdapter theatersAdapter =
            new MovieTicketBuyer1DataSetTableAdapters.TheatersTableAdapter();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
