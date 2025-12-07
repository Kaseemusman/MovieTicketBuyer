using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MovieTicketBuyer.Models;

namespace MovieTicketBuyer
{
    public partial class frmPurchase : Form
    {
       
        private Ticket selectedTicket;
        private User currentUser;

        
        public frmPurchase(Ticket ticket, User user)
        {
            InitializeComponent();
            selectedTicket = ticket;
            currentUser = user;
        }

      
        private void frmPurchase_Load(object sender, EventArgs e)
        {
            // display
            lblMovie.Text = selectedTicket.Movie.Title;
            lblGenre.Text = selectedTicket.Movie.Genre;
            lblTheater.Text = selectedTicket.Movie.Theater.Name;
            lblShowTime.Text = selectedTicket.Movie.ShowTime;
            lblPrice.Text = "$" + selectedTicket.Movie.Price.ToString("0.00");
            lblSeat.Text = selectedTicket.SeatNumber;
            lblRating.Text = selectedTicket.Movie.Rating;
            lblDuration.Text = selectedTicket.Movie.Duration + " minutes";
        }

        
        private void btnConfirm_Click(object sender, EventArgs e)
        {
         
            selectedTicket.Status = "Sold";

           
            currentUser.Purchased.Add(selectedTicket);

            
            currentUser.Watchlist.Remove(selectedTicket);

            MessageBox.Show("Ticket purchased successfully!", "Success");

            this.Close();
        }

       
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Genre_Click(object sender, EventArgs e)
        {

        }

        private void lblTheater_Click(object sender, EventArgs e)
        {

        }

        private void lblMovieTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
