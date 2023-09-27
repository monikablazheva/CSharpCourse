using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessLayer
{
    public partial class Country
    {
        public Country()
        {
            Customers = new HashSet<Customer>();
            Departments = new HashSet<Department>();
        }

        public string CountryId { get; set; }
        public string CountryName { get; set; }
        public short? RegionId { get; set; }

        public virtual Region Region { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
    }
}
