using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer
{
    public class Customer
    {
        [Key]
        public int ID { get; private set; }

        [Required]
        [MaxLength(40)]
        public string Name { get; set; }

        [Required]
        [MaxLength(20)]
        public string Country { get; set; }

        public int Age { get; set; }

        public IEnumerable<Product> FavouriteProducts { get; set; }

        // For Entity Framework (Core)
        private Customer()
        {

        }

        public Customer(string name, string country, int age)
        {
            this.Name = name;
            this.Country = country;
            this.Age = age;
            this.FavouriteProducts = new HashSet<Product>();
        }

        public Customer(int id, string name, string country, int age)
            : this(name, country, age)
        {
            this.ID = id;
        }

        public Customer(string name, string country, int age, List<Product> products)
            : this(name, country, age)
        {
            this.FavouriteProducts = products;
        }

    }
}
