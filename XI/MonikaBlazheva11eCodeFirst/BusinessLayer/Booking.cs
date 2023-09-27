using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Booking
    {

        [Key]
        public int Id { get; private set; }

        [Range(1, 2000, ErrorMessage = "Rooms number should be between {0} and {1}.")]
        public int NumberOfRooms { get; set; }

        [Range(1, 500, ErrorMessage = "Days should be between {0} and {1}.")]
        public int DaysCount { get; set; }

        public DateTime Date { get; set; }

        [Range(1, 5000, ErrorMessage = "Price should be between {0} and {1}.")]
        public decimal Price { get; private set; }

        [ForeignKey("Restaurant")]
        public string RestaurantName { get; set; }

        [Required]
        public Restaurant Restaurant { get; set; }

        [ForeignKey("Client")]
        public int ClientId { get; set; }

        [Required]
        public Client Client { get; set; }

        private Booking()
        {

        }

        public Booking(int numberOfRooms, int daysCount, DateTime date, decimal price, Restaurant restaurant, Client client)
        {
            NumberOfRooms = numberOfRooms;
            DaysCount = daysCount;
            Date = date;
            Price = price;
            Restaurant = restaurant;
            Client = client;
        }
    }
}
