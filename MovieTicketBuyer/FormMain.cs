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

        // DataSet and TableAdapters for database connection
        private MovieTicketBuyer1DataSet dataSet = new MovieTicketBuyer1DataSet();
        private MovieTicketBuyer1DataSetTableAdapters.MoviesTableAdapter moviesAdapter =
            new MovieTicketBuyer1DataSetTableAdapters.MoviesTableAdapter();
        private MovieTicketBuyer1DataSetTableAdapters.TheatersTableAdapter theatersAdapter =
            new MovieTicketBuyer1DataSetTableAdapters.TheatersTableAdapter();

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                // Load data from Access database
                theatersAdapter.Fill(dataSet.Theaters);
                moviesAdapter.Fill(dataSet.Movies);

                // Convert DataSet to Model objects
                LoadMoviesFromDataSet();

                MessageBox.Show($"Loaded {controller.Movies.Count} movies from database!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading from database: {ex.Message}\n\nUsing sample data.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                controller.LoadSampleData();
            }

            // Display movies in DataGridView
            LoadMovies(controller.Movies);

            // Populate Theater dropdown
            cboTheater.Items.Add("All");
            foreach (Movie m in controller.Movies)
            {
                bool found = false;
                for (int i = 0; i < cboTheater.Items.Count; i++)
                {
                    if (cboTheater.Items[i].ToString() == m.Theater.Name)
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    cboTheater.Items.Add(m.Theater.Name);
                }
            }
            cboTheater.SelectedIndex = 0;

            // Populate Genre dropdown
            cboGenre.Items.Add("All");
            foreach (Movie m in controller.Movies)
            {
                bool found = false;
                for (int i = 0; i < cboGenre.Items.Count; i++)
                {
                    if (cboGenre.Items[i].ToString() == m.Genre)
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    cboGenre.Items.Add(m.Genre);
                }
            }
            cboGenre.SelectedIndex = 0;

            // Populate Price dropdown
            cboPrice.Items.Add("All");
            cboPrice.Items.Add("Under $10");
            cboPrice.Items.Add("$10 - $14");
            cboPrice.Items.Add("Over $15");
            cboPrice.SelectedIndex = 0;

            // Populate Time dropdown
            cboTime.Items.Add("All");
            cboTime.Items.Add("Before 7 PM");
            cboTime.Items.Add("7 PM or Later");
            cboTime.SelectedIndex = 0;

            // Populate Sort dropdown
            cboSort.Items.Add("None");
            cboSort.Items.Add("Price: Low to High");
            cboSort.Items.Add("Price: High to Low");
            cboSort.Items.Add("Title A-Z");
            cboSort.Items.Add("Time: Earliest First");
            cboSort.SelectedIndex = 0;
        }

        /// <summary>
        /// Load movies from DataSet into the MovieController
        /// This converts database rows into Movie model objects
        /// </summary>
        private void LoadMoviesFromDataSet()
        {
            controller.Movies.Clear();

          
            Dictionary<int, Theater> theaters = new Dictionary<int, Theater>();
            foreach (var theaterRow in dataSet.Theaters)
            {
                Theater theater = new Theater(
                    theaterRow.TheaterName,
                    theaterRow.Address
                );
                theaters.Add(theaterRow.TheaterID, theater);
            }

            
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
                        movieRow.IsDurationNull() ? 0 : movieRow.Duration,  // Handle null duration
                        movieRow.IsRatingNull() ? "Not Rated" : movieRow.Rating,  // Handle null rating
                        movieRow.IsDescriptionNull() ? "" : movieRow.Description  // Handle null description
                    );
                    controller.Movies.Add(movie);
                }
            }
        }

        /// <summary>
        /// Display movies in the DataGridView
        /// </summary>
        private void LoadMovies(List<Movie> movies)
        {
            List<object> displayList = new List<object>();

            foreach (Movie m in movies)
            {
                displayList.Add(new
                {
                    Title = m.Title,
                    Genre = m.Genre,
                    Rating = m.Rating,
                    Duration = m.Duration > 0 ? $"{m.Duration} min" : "N/A",
                    Theater = m.Theater.Name,
                    ShowTime = m.ShowTime,
                    Price = m.Price.ToString("C") // changes format
                });
            }

            dgvMovieList.DataSource = null;
            dgvMovieList.DataSource = displayList;
        }

        /// <summary>
        /// Convert time string to TimeSpan for comparison
        /// </summary>
        private TimeSpan ConvertTime(string time)
        {
            DateTime dt = DateTime.Parse(time);
            return dt.TimeOfDay;
        }

        /// <summary>
        /// Filter movies based on selected criteria
        /// </summary>
        private void btnFilter_Click(object sender, EventArgs e)
        {
            List<Movie> filtered = new List<Movie>();

            // Start with all movies
            for (int i = 0; i < controller.Movies.Count; i++)
            {
                filtered.Add(controller.Movies[i]);
            }

            // Filter by Theater
            if (cboTheater.Text != "All")
            {
                List<Movie> tempList = new List<Movie>();
                for (int i = 0; i < filtered.Count; i++)
                {
                    if (filtered[i].Theater.Name == cboTheater.Text)
                    {
                        tempList.Add(filtered[i]);
                    }
                }
                filtered = tempList;
            }

            // Filter by Genre
            if (cboGenre.Text != "All")
            {
                List<Movie> tempList = new List<Movie>();
                for (int i = 0; i < filtered.Count; i++)
                {
                    if (filtered[i].Genre == cboGenre.Text)
                    {
                        tempList.Add(filtered[i]);
                    }
                }
                filtered = tempList;
            }

            // Filter by Price
            List<Movie> filteredByPrice = new List<Movie>();
            for (int i = 0; i < filtered.Count; i++)
            {
                Movie m = filtered[i];

                if (cboPrice.Text == "Under $10")
                {
                    if (m.Price < 10)
                        filteredByPrice.Add(m);
                }
                else if (cboPrice.Text == "$10 - $14")
                {
                    if (m.Price >= 10 && m.Price <= 14)
                        filteredByPrice.Add(m);
                }
                else if (cboPrice.Text == "Over $15")
                {
                    if (m.Price > 15)
                        filteredByPrice.Add(m);
                }
                else
                {
                    filteredByPrice.Add(m);
                }
            }
            filtered = filteredByPrice;

            // Filter by Time
            List<Movie> timeFiltered = new List<Movie>();
            for (int i = 0; i < filtered.Count; i++)
            {
                Movie m = filtered[i];
                TimeSpan t = ConvertTime(m.ShowTime);

                if (cboTime.Text == "Before 7 PM")
                {
                    if (t < new TimeSpan(19, 0, 0))
                        timeFiltered.Add(m);
                }
                else if (cboTime.Text == "7 PM or Later")
                {
                    if (t >= new TimeSpan(19, 0, 0))
                        timeFiltered.Add(m);
                }
                else
                {
                    timeFiltered.Add(m);
                }
            }
            filtered = timeFiltered;

            LoadMovies(filtered);
        }

        /// <summary>
        /// Sort movies based on selected criteria
        /// </summary>
        private void btnSort_Click(object sender, EventArgs e)
        {
            List<Movie> movies = new List<Movie>();

            // Copy all movies
            for (int i = 0; i < controller.Movies.Count; i++)
            {
                movies.Add(controller.Movies[i]);
            }

            // Bubble sort based on selection
            for (int i = 0; i < movies.Count - 1; i++)
            {
                for (int j = 0; j < movies.Count - 1 - i; j++)
                {
                    bool shouldSwap = false;

                    if (cboSort.Text == "Price: Low to High")
                    {
                        if (movies[j].Price > movies[j + 1].Price)
                            shouldSwap = true;
                    }
                    else if (cboSort.Text == "Price: High to Low")
                    {
                        if (movies[j].Price < movies[j + 1].Price)
                            shouldSwap = true;
                    }
                    else if (cboSort.Text == "Title A-Z")
                    {
                        if (string.Compare(movies[j].Title, movies[j + 1].Title) > 0)
                            shouldSwap = true;
                    }
                    else if (cboSort.Text == "Time: Earliest First")
                    {
                        TimeSpan t1 = ConvertTime(movies[j].ShowTime);
                        TimeSpan t2 = ConvertTime(movies[j + 1].ShowTime);

                        if (t1 > t2)
                            shouldSwap = true;
                    }

                    if (shouldSwap)
                    {
                        Movie temp = movies[j];
                        movies[j] = movies[j + 1];
                        movies[j + 1] = temp;
                    }
                }
            }

            LoadMovies(movies);
        }

        /// <summary>
        /// Add selected movie to watchlist in database
        /// </summary>
        private void btnAddWatchlist_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMovieList.CurrentRow == null)
                {
                    MessageBox.Show("Please select a movie first.", "No Selection",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string title = dgvMovieList.CurrentRow.Cells["Title"].Value.ToString();

                // Find the movie in the dataset
                var movieRow = dataSet.Movies.FirstOrDefault(m => m.Title == title);

                if (movieRow != null)
                {
                    // Insert into database
                    var ticketsAdapter = new MovieTicketBuyer1DataSetTableAdapters.TicketsTableAdapter();
                    ticketsAdapter.Insert(1, movieRow.MovieID, "A1", "Watchlist", null);

                    MessageBox.Show($"'{title}' added to watchlist!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Movie not found in database.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding to watchlist: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Open purchase form for selected movie
        /// </summary>
        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (dgvMovieList.CurrentRow == null)
            {
                MessageBox.Show("Please select a movie first.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string title = dgvMovieList.CurrentRow.Cells["Title"].Value.ToString();
            Movie selectedMovie = null;

            // Find the selected movie
            for (int i = 0; i < controller.Movies.Count; i++)
            {
                if (controller.Movies[i].Title == title)
                {
                    selectedMovie = controller.Movies[i];
                    break;
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

        /// <summary>
        /// Open watchlist form
        /// </summary>
        private void btnOpenWatchlist_Click(object sender, EventArgs e)
        {
            frmWatchlist watchlistForm = new frmWatchlist(currentUser);
            watchlistForm.ShowDialog();
        }

        private void dgvMovieList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string title = dgvMovieList.Rows[e.RowIndex].Cells["Title"].Value.ToString();
            Movie selectedMovie = controller.Movies.FirstOrDefault(m => m.Title == title);

            if (selectedMovie != null)
            {
                string details = $"Title: {selectedMovie.Title}\n\n" +
                                $"Genre: {selectedMovie.Genre}\n" +
                                $"Rating: {selectedMovie.Rating}\n" +
                                $"Duration: {selectedMovie.Duration} minutes\n" +
                                $"Theater: {selectedMovie.Theater.Name}\n" +
                                $"Show Time: {selectedMovie.ShowTime}\n" +
                                $"Price: {selectedMovie.Price:C}\n\n" +
                                $"Description:\n{selectedMovie.Description}";

                MessageBox.Show(details, selectedMovie.Title,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                LoadMovies(controller.Movies);
                return;
            }

            string searchTerm = txtSearch.Text.ToLower();
            List<Movie> results = new List<Movie>();

            foreach (Movie m in controller.Movies)
            {
                if (m.Title.ToLower().Contains(searchTerm) ||
                    m.Genre.ToLower().Contains(searchTerm) ||
                    m.Theater.Name.ToLower().Contains(searchTerm))
                {
                    results.Add(m);
                }
            }

            LoadMovies(results);

            if (results.Count == 0)
            {
                MessageBox.Show("No movies found matching your search.", "No Results");
            }
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
        }
    }
}