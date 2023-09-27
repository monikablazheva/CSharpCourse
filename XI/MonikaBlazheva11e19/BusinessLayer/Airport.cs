using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessLayer
{
    public partial class Airport
    {
        public Airport()
        {
            Bookings = new HashSet<Booking>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? Income { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
