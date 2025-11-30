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

using MovieTicketBuyer.Models;   // IMPORTANT to use elements from Models folder

namespace MovieTicketBuyer
{
    public partial class frmWatchlist : Form
    {
        private User currentUser;

        public frmWatchlist(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void frmWatchlist_Load(object sender, EventArgs e)
        {
            RefreshWatchlistTable();
        }

        private void RefreshWatchlistTable()
        {
            // Prepare a simple list for display (anonymous objects)
            var displayList = new List<object>();

            foreach (var ticket in currentUser.Watchlist)
            {
                displayList.Add(new
                {
                    TicketID = ticket.Id,
                    MovieTitle = ticket.Movie.Title,
                    Genre = ticket.Movie.Genre,
                    Theater = ticket.Movie.Theater.Name,
                    ShowTime = ticket.Movie.ShowTime,
                    Price = ticket.Movie.Price,
                    Seat = ticket.SeatNumber,
                    Status = ticket.Status
                });
            }

            dgvWatchlist.DataSource = null;
            dgvWatchlist.DataSource = displayList;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (dgvWatchlist.CurrentRow != null)
            {
                int ticketId = (int)dgvWatchlist.CurrentRow.Cells["TicketID"].Value;

                Ticket ticketToBuy = currentUser.Watchlist
                    .Find(t => t.Id == ticketId);

                if (ticketToBuy != null)
                {
                    ticketToBuy.Status = "Sold";
                    currentUser.Purchased.Add(ticketToBuy);
                    currentUser.Watchlist.Remove(ticketToBuy);

                    MessageBox.Show("Ticket purchased successfully!");
                }

                RefreshWatchlistTable();
            }
            else
            {
                MessageBox.Show("Please select a ticket to buy.");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvWatchlist.CurrentRow != null)
            {
                int ticketId = (int)dgvWatchlist.CurrentRow.Cells["TicketID"].Value;

                // Find the real Ticket object
                Ticket ticketToRemove = currentUser.Watchlist
                    .Find(t => t.Id == ticketId);

                if (ticketToRemove != null)
                {
                    currentUser.Watchlist.Remove(ticketToRemove);
                }

                RefreshWatchlistTable();
            }
            else
            {
                MessageBox.Show("Please select a ticket to remove.");
            }
        }
    }
}
