using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessLayer
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public decimal CustomerId { get; set; }
        public string CountryId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }

        public virtual Country Country { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
