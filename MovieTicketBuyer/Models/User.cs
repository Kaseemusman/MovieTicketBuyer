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
        public List<Ticket> Watchlist { get; set; }
        public List<Ticket> Purchased { get; set; }

        public User(string name)
        {
            Name = name;
            Watchlist = new List<Ticket>();
            Purchased = new List<Ticket>();
        }
    }
}
