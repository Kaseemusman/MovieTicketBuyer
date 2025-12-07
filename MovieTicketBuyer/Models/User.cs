using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketBuyer.Models
{
    public class User
    {
   
        public string Name { get; set; }
        public string Password { get; set; }
        public List<Ticket> Watchlist { get; set; }
        public List<Ticket> Purchased { get; set; }
        public User(string name)
        {
            Name = name;
            Password = "";
            Watchlist = new List<Ticket>();
            Purchased = new List<Ticket>();
        }
        public User(string name, string password)
        {
            Name = name;
            Password = password;
            Watchlist = new List<Ticket>();
            Purchased = new List<Ticket>();
        }
        public bool VerifyPassword(string password)
        {
            return this.Password == password;
        }
    }
}
