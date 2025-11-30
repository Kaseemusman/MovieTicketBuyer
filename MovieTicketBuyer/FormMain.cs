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
    public partial class FormMain : Form
    {
        private MovieController controller = new MovieController();
        private User currentUser = new User("Kaseem");

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            controller.LoadSampleData();
            LoadMovies(controller.Movies);

            // THEATER DROPDOWN
            cboTheater.Items.Add("All");

            foreach (Movie m in controller.Movies)
            {
                bool found = false;

                for (int i = 0; i < cboTheater.Items.Count; i++)
                {
                    if (cboTheater.Items[i].ToString() == m.Theater.Name)
                    {
                        found = true;
                    }
                }

                if (found == false)
                {
                    cboTheater.Items.Add(m.Theater.Name);
                }
            }

            cboTheater.SelectedIndex = 0;

            // GENRE DROPDOWN
            cboGenre.Items.Add("All");

            foreach (Movie m in controller.Movies)
            {
                bool found = false;

                for (int i = 0; i < cboGenre.Items.Count; i++)
                {
                    if (cboGenre.Items[i].ToString() == m.Genre)
                    {
                        found = true;
                    }
                }

                if (found == false)
                {
                    cboGenre.Items.Add(m.Genre);
                }
            }

            cboGenre.SelectedIndex = 0;

            // PRICE DROPDOWN
            cboPrice.Items.Add("All");
            cboPrice.Items.Add("Under $10");
            cboPrice.Items.Add("$10 - $15");
            cboPrice.Items.Add("Over $15");
            cboPrice.SelectedIndex = 0;

            // TIME DROPDOWN
            cboTime.Items.Add("All");
            cboTime.Items.Add("Before 7 PM");
            cboTime.Items.Add("7 PM or Later");
            cboTime.SelectedIndex = 0;

            // SORT DROPDOWN
            cboSort.Items.Add("None");
            cboSort.Items.Add("Price: Low to High");
            cboSort.Items.Add("Price: High to Low");
            cboSort.Items.Add("Title A-Z");
            cboSort.Items.Add("Time: Earliest First");
            cboSort.SelectedIndex = 0;
        }

        // LOAD MOVIES
        private void LoadMovies(List<Movie> movies)
        {
            List<object> displayList = new List<object>();

            foreach (Movie m in movies)
            {
                displayList.Add(
                    new
                    {
                        Title = m.Title,
                        Genre = m.Genre,
                        Theater = m.Theater.Name,
                        ShowTime = m.ShowTime,
                        Price = m.Price
                    }
                );
            }

            dgvMovieList.DataSource = null;
            dgvMovieList.DataSource = displayList;
        }

        // CONVERT TIME
        private TimeSpan ConvertTime(string time)
        {
            DateTime dt = DateTime.Parse(time);
            return dt.TimeOfDay;
        }

        // FILTER
        private void btnFilter_Click(object sender, EventArgs e)
        {
            List<Movie> filtered = new List<Movie>();

            // START WITH ALL MOVIES
            for (int i = 0; i < controller.Movies.Count; i++)
            {
                filtered.Add(controller.Movies[i]);
            }

            // THEATER FILTER
            if (cboTheater.Text != "All")
            {
                List<Movie> tempList = new List<Movie>();

                for (int i = 0; i < filtered.Count; i++)
                {
                    Movie m = filtered[i];

                    if (m.Theater.Name == cboTheater.Text)
                    {
                        tempList.Add(m);
                    }
                }

                filtered = tempList;
            }

            // GENRE FILTER
            if (cboGenre.Text != "All")
            {
                List<Movie> tempList = new List<Movie>();

                for (int i = 0; i < filtered.Count; i++)
                {
                    Movie m = filtered[i];

                    if (m.Genre == cboGenre.Text)
                    {
                        tempList.Add(m);
                    }
                }

                filtered = tempList;
            }

            // PRICE FILTER
            List<Movie> filteredByPrice = new List<Movie>();

            for (int i = 0; i < filtered.Count; i++)
            {
                Movie m = filtered[i];

                if (cboPrice.Text == "Under $10")
                {
                    if (m.Price < 10)
                    {
                        filteredByPrice.Add(m);
                    }
                }
                else if (cboPrice.Text == "$10 - $15")
                {
                    if (m.Price >= 10 && m.Price <= 15)
                    {
                        filteredByPrice.Add(m);
                    }
                }
                else if (cboPrice.Text == "Over $15")
                {
                    if (m.Price > 15)
                    {
                        filteredByPrice.Add(m);
                    }
                }
                else
                {
                    filteredByPrice.Add(m);
                }
            }

            filtered = filteredByPrice;

            // TIME FILTER
            List<Movie> timeFiltered = new List<Movie>();

            for (int i = 0; i < filtered.Count; i++)
            {
                Movie m = filtered[i];
                TimeSpan t = ConvertTime(m.ShowTime);

                if (cboTime.Text == "Before 7 PM")
                {
                    if (t < new TimeSpan(19, 0, 0))
                    {
                        timeFiltered.Add(m);
                    }
                }
                else if (cboTime.Text == "7 PM or Later")
                {
                    if (t >= new TimeSpan(19, 0, 0))
                    {
                        timeFiltered.Add(m);
                    }
                }
                else
                {
                    timeFiltered.Add(m);
                }
            }

            filtered = timeFiltered;

            LoadMovies(filtered);
        }

        // SORT
        private void btnSort_Click(object sender, EventArgs e)
        {
            List<Movie> movies = new List<Movie>();

            // COPY MOVIES
            for (int i = 0; i < controller.Movies.Count; i++)
            {
                movies.Add(controller.Movies[i]);
            }

            // BUBBLE SORT
            for (int i = 0; i < movies.Count - 1; i++)
            {
                for (int j = 0; j < movies.Count - 1 - i; j++)
                {
                    bool shouldSwap = false;

                    if (cboSort.Text == "Price: Low to High")
                    {
                        if (movies[j].Price > movies[j + 1].Price)
                        {
                            shouldSwap = true;
                        }
                    }
                    else if (cboSort.Text == "Price: High to Low")
                    {
                        if (movies[j].Price < movies[j + 1].Price)
                        {
                            shouldSwap = true;
                        }
                    }
                    else if (cboSort.Text == "Title A-Z")
                    {
                        if (string.Compare(movies[j].Title, movies[j + 1].Title) > 0)
                        {
                            shouldSwap = true;
                        }
                    }
                    else if (cboSort.Text == "Time: Earliest First")
                    {
                        TimeSpan t1 = ConvertTime(movies[j].ShowTime);
                        TimeSpan t2 = ConvertTime(movies[j + 1].ShowTime);

                        if (t1 > t2)
                        {
                            shouldSwap = true;
                        }
                    }

                    if (shouldSwap == true)
                    {
                        Movie temp = movies[j];
                        movies[j] = movies[j + 1];
                        movies[j + 1] = temp;
                    }
                }
            }

            LoadMovies(movies);
        }

        // ADD TO WATCHLIST
        private void btnAddWatchlist_Click(object sender, EventArgs e)
        {
            if (dgvMovieList.CurrentRow == null)
            {
                MessageBox.Show("Select a movie first.");
                return;
            }

            string title = dgvMovieList.CurrentRow.Cells["Title"].Value.ToString();
            Movie selectedMovie = null;

            // MANUAL SEARCH
            for (int i = 0; i < controller.Movies.Count; i++)
            {
                if (controller.Movies[i].Title == title)
                {
                    selectedMovie = controller.Movies[i];
                }
            }

            if (selectedMovie != null)
            {
                Ticket ticket = new Ticket(
                    currentUser.Watchlist.Count + currentUser.Purchased.Count + 1,
                    selectedMovie,
                    "A1"
                );

                ticket.Status = "Watchlist";
                currentUser.Watchlist.Add(ticket);

                MessageBox.Show("Added to watchlist.");
            }
        }

        // BUY TICKET
        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (dgvMovieList.CurrentRow == null)
            {
                MessageBox.Show("Select a movie first.");
                return;
            }

            string title = dgvMovieList.CurrentRow.Cells["Title"].Value.ToString();
            Movie selectedMovie = null;

            for (int i = 0; i < controller.Movies.Count; i++)
            {
                if (controller.Movies[i].Title == title)
                {
                    selectedMovie = controller.Movies[i];
                }
            }

            if (selectedMovie != null)
            {
                Ticket ticket = new Ticket(
                    currentUser.Watchlist.Count + currentUser.Purchased.Count + 1,
                    selectedMovie,
                    "A1"
                );

                frmPurchase purchaseForm = new frmPurchase(ticket, currentUser);
                purchaseForm.ShowDialog();
            }
        }

        // OPEN WATCHLIST
        private void btnOpenWatchlist_Click(object sender, EventArgs e)
        {
            frmWatchlist watchlistForm = new frmWatchlist(currentUser);
            watchlistForm.ShowDialog();
        }
    }
}

