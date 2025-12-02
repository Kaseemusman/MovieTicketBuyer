using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketBuyer.Models
{
    public class MovieController
    {
        // In-memory list of movies for demonstration purposes
        public List<Movie> Movies { get; set; } = new List<Movie>();

        public void LoadSampleData()
        {
            var amc = new Theater("AMC", "King of Prussia");
            var regal = new Theater("Regal", "Collegeville");

            Movies.Add(new Movie("Dune 2", "Sci-Fi", 14.5, "9:30 PM", amc,142,"R","Dune"));
            Movies.Add(new Movie("Inside Out 2", "Animation", 10.0, "6:00 PM", regal, 142, "R", "Dune"));
            Movies.Add(new Movie("Joker 2", "Drama", 12.0, "8:00 PM", amc, 142, "R", "Dune"));
        }

        public List<Movie> FilterByTheater(string theater)
        {
            if (string.IsNullOrEmpty(theater) || theater == "All")
                return Movies;
            return Movies.Where(m => m.Theater.Name == theater).ToList();
        }

        public List<Movie> SortByPrice()
        {
            return Movies.OrderBy(m => m.Price).ToList();
        }
    }
}
