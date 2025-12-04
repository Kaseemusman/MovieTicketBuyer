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
    public partial class frmWatchlist : Form
    {
        private User currentUser;
        private MovieTicketBuyer1DataSet dataSet = new MovieTicketBuyer1DataSet();
        private MovieTicketBuyer1DataSetTableAdapters.TicketsTableAdapter ticketsAdapter =
            new MovieTicketBuyer1DataSetTableAdapters.TicketsTableAdapter();
        private MovieTicketBuyer1DataSetTableAdapters.MoviesTableAdapter moviesAdapter =
            new MovieTicketBuyer1DataSetTableAdapters.MoviesTableAdapter();
        private MovieTicketBuyer1DataSetTableAdapters.TheatersTableAdapter theatersAdapter =
            new MovieTicketBuyer1DataSetTableAdapters.TheatersTableAdapter();

        public frmWatchlist(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void frmWatchlist_Load(object sender, EventArgs e)
        {
            LoadWatchlistFromDatabase();
        }

        /// <summary>
        /// Load watchlist from database
        /// </summary>
        private void LoadWatchlistFromDatabase()
        {
            try
            {
                // Clear current watchlist
                currentUser.Watchlist.Clear();

                // Load data from database
                ticketsAdapter.Fill(dataSet.Tickets);
                moviesAdapter.Fill(dataSet.Movies);
                theatersAdapter.Fill(dataSet.Theaters);

                // Create theaters dictionary
                Dictionary<int, Theater> theaters = new Dictionary<int, Theater>();
                foreach (var theaterRow in dataSet.Theaters)
                {
                    Theater theater = new Theater(
                        theaterRow.TheaterName,
                        theaterRow.Address
                    );
                    theaters.Add(theaterRow.TheaterID, theater);
                }

                // Create movies dictionary
                Dictionary<int, Movie> movies = new Dictionary<int, Movie>();
                foreach (var movieRow in dataSet.Movies)
                {
                    if (theaters.ContainsKey(movieRow.TheaterID))
                    {
                        Movie movie = new Movie(
                            movieRow.Title,
                            movieRow.Genre,
                            (double)movieRow.Price,
                            movieRow.ShowTime,
                            theaters[movieRow.TheaterID],
                            movieRow.IsDurationNull() ? 0 : movieRow.Duration,
                            movieRow.IsRatingNull() ? "Not Rated" : movieRow.Rating,
                            movieRow.IsDescriptionNull() ? "" : movieRow.Description
                        );
                        movies.Add(movieRow.MovieID, movie);
                    }
                }

                // Load watchlist tickets
                var watchlistTickets = dataSet.Tickets.Where(t => t.TicketStatus == "Watchlist");

                foreach (var ticketRow in watchlistTickets)
                {
                    if (movies.ContainsKey(ticketRow.MovieID))
                    {
                        Ticket ticket = new Ticket(
                            ticketRow.TicketID,
                            movies[ticketRow.MovieID],
                            ticketRow.SeatNumber
                        );
                        ticket.Status = ticketRow.TicketStatus;
                        currentUser.Watchlist.Add(ticket);
                    }
                }

                RefreshWatchlistTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading watchlist: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    Rating = ticket.Movie.Rating,
                    Theater = ticket.Movie.Theater.Name,
                    ShowTime = ticket.Movie.ShowTime,
                    Price = ticket.Movie.Price.ToString("C"),
                    Seat = ticket.SeatNumber,
                    Status = ticket.Status
                });
            }

            dgvWatchlist.DataSource = null;
            dgvWatchlist.DataSource = displayList;

            // Update count label
            lblCount.Text = $"Total Items: {currentUser.Watchlist.Count}";
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvWatchlist.CurrentRow == null)
                {
                    MessageBox.Show("Please select a ticket to buy.", "No Selection",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int ticketId = (int)dgvWatchlist.CurrentRow.Cells["TicketID"].Value;

                Ticket ticketToBuy = currentUser.Watchlist.Find(t => t.Id == ticketId);

                if (ticketToBuy != null)
                {
                    // Update in database
                    var ticketRow = dataSet.Tickets.FindByTicketID(ticketId);
                    if (ticketRow != null)
                    {
                        ticketRow.TicketStatus = "Sold";
                        ticketRow.PurchaseDate = DateTime.Now;
                        ticketsAdapter.Update(dataSet.Tickets);
                    }

                    // Update in memory
                    ticketToBuy.Status = "Sold";
                    currentUser.Purchased.Add(ticketToBuy);
                    currentUser.Watchlist.Remove(ticketToBuy);

                    MessageBox.Show("Ticket purchased successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    RefreshWatchlistTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error purchasing ticket: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvWatchlist.CurrentRow == null)
                {
                    MessageBox.Show("Please select a ticket to remove.", "No Selection",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int ticketId = (int)dgvWatchlist.CurrentRow.Cells["TicketID"].Value;

                // Find the real Ticket object
                Ticket ticketToRemove = currentUser.Watchlist.Find(t => t.Id == ticketId);

                if (ticketToRemove != null)
                {
                    // Confirm removal
                    var result = MessageBox.Show(
                        $"Remove '{ticketToRemove.Movie.Title}' from watchlist?",
                        "Confirm Removal",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Delete from database
                        var ticketRow = dataSet.Tickets.FindByTicketID(ticketId);
                        if (ticketRow != null)
                        {
                            ticketRow.Delete();
                            ticketsAdapter.Update(dataSet.Tickets);
                        }

                        // Remove from memory
                        currentUser.Watchlist.Remove(ticketToRemove);

                        MessageBox.Show("Removed from watchlist.", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        RefreshWatchlistTable();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error removing ticket: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}