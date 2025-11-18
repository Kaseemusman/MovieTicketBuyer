using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketBuyer.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public Movie Movie { get; set; }
        public string SeatNumber { get; set; }
        public string Status { get; set; }  // "Available", "Watchlist", "Sold"

        // Constructor to initialize a Ticket object
        public Ticket(int id, Movie movie, string seat)
        {
            Id = id;
            Movie = movie;
            SeatNumber = seat;
            Status = "Available";
        }
    }
}
