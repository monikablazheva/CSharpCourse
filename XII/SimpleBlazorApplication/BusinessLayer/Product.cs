using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Product
    {
        [Key]
        public string Barcode { get; set; }

        [Required]
        public string Name { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        [ForeignKey("Brand")]
        public int BrandId { get; set; }

        // I removed 'Required' because when we bind the model in Create.razor, we cannot convert automatically string to object!
        //[Required]
        public Brand Brand { get; set; }

        public Product()
        {

        }

        public Product(string barcode, string name, int quanitty, decimal price)
        {
            Barcode = barcode;
            Name = name;
            Quantity = quanitty;
            Price = price;
        }

        public Product(string barcode, string name, int quanitty, decimal price, Brand brand)
            : this(barcode, name, quanitty, price)
        {
            Brand = brand;
            BrandId = brand.Id;
        }

    }
}
