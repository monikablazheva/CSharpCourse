using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Client
    {
        [Key]
        public int Id { get; private set; }

        [Required, MaxLength(20)]
        public string Name { get; set; }


        [Range(1, 100, ErrorMessage = "Age should be between {0} and {1}.")]
        public int? Age { get; set; }

        public IEnumerable<Booking> bookings { get; set; }

        private Client()
        {

        }
        public Client(string name)
        {
            Name = name;
        }
    }
}