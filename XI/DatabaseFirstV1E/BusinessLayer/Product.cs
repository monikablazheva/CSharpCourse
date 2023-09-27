using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusinessLayer
{
    public class Product
    {
        [Key]
        [MaxLength(20)]
        public string Barcode { get; set; }

        [Required]
        [MaxLength(40)]
        public string Name { get; set; }

        // null
        [MaxLength(40)]
        public string Brand { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public IEnumerable<Customer> FavouriteForCustomers { get; set; }

        private Product()
        {

        }

        public Product(string barcode, string name, string brand, int quantity, decimal price)
        {
            this.Barcode = barcode;
            this.Name = name;
            this.Brand = brand;
            this.Quantity = quantity;
            this.Price = price;
        }

    }
}
