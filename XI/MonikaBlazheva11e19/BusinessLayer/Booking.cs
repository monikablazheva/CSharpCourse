using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessLayer
{
    public partial class Booking
    {
        public int Id { get; set; }
        public int NumberOfPlaces { get; set; }
        public short TicketsCount { get; set; }
        public decimal Price { get; set; }
        public int? AirportsId { get; set; }
        public int FlightsId { get; set; }

        public virtual Airport Airports { get; set; }
        public virtual Flight Flights { get; set; }
    }
}
