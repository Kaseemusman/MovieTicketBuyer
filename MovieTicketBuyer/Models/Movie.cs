using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketBuyer.Models
{
    // Movie class to represent a movie showing
    public class Movie
    {
        // Properties
        public string Title { get; set; }
        public string Genre { get; set; }
        public double Price { get; set; }
        public string ShowTime { get; set; }
        public Theater Theater { get; set; }
        public int Duration { get; set; }  // minutes
        public string Rating { get; set; }  
        public string Description { get; set; }

        // Constructor to initialize a Movie object
        public Movie(string title, string genre, double price, string showTime,
                     Theater theater, int duration, string rating, string description)
        {
            Title = title;
            Genre = genre;
            Price = price;
            ShowTime = showTime;
            Theater = theater;
            Duration = duration;
            Rating = rating;
            Description = description;
        }
        // Override ToString for easy display of movie details
        // if i call Console.WriteLine(movie), it will print this string
        // i dont need to call movie.ToString() explicitly
        // it will only print this string on Console.WriteLine or string interpolation
        public override string ToString()
        {
            return $"{Title} ({Genre}) - {Rating} - {Duration}min - {Theater.Name} - {ShowTime} - ${Price}";
        }
    }

}
