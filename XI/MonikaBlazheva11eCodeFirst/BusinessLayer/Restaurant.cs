using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Restaurant
    {
        [Key]
        public string Name { get; set; }

        [Required, MaxLength(64)]
        public string Address { get; set; }

        public decimal? Income { get; set; }

        public IEnumerable<Booking> bookings { get; set; }

        private Restaurant()
        {

        }

        public Restaurant(string name, string address)
        {
            Name = name;
            Address = address;
        }
    }
}