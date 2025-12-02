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
        // Private fields to hold selected ticket and current user
        private Ticket selectedTicket;
        private User currentUser;

        // Constructor with parameters
        public frmPurchase(Ticket ticket, User user)
        {
            InitializeComponent();
            selectedTicket = ticket;
            currentUser = user;
        }

        // Form Load Event
        private void frmPurchase_Load(object sender, EventArgs e)
        {
            // Display movie details
            lblMovie.Text = selectedTicket.Movie.Title;
            lblGenre.Text = selectedTicket.Movie.Genre;
            lblTheater.Text = selectedTicket.Movie.Theater.Name;
            lblShowTime.Text = selectedTicket.Movie.ShowTime;
            lblPrice.Text = "$" + selectedTicket.Movie.Price.ToString("0.00");
            lblSeat.Text = selectedTicket.SeatNumber;
            lblRating.Text = selectedTicket.Movie.Rating;
            lblDuration.Text = selectedTicket.Movie.Duration + " minutes";
        }

        // Confirm purchase Button Click Event
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Update ticket status
            selectedTicket.Status = "Sold";

            // Add to user's purchased list
            currentUser.Purchased.Add(selectedTicket);

            // Remove from watchlist if present
            currentUser.Watchlist.Remove(selectedTicket);

            MessageBox.Show("Ticket purchased successfully!", "Success");

            this.Close();
        }

        // Cancel Button Click Event
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
