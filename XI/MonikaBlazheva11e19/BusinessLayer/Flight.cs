using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessLayer
{
    public partial class Flight
    {
        public Flight()
        {
            Bookings = new HashSet<Booking>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public short? Duration { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
