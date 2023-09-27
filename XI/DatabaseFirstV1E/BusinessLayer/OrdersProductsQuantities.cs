using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BusinessLayer
{
    public class OrdersProductsQuantities
    {
        [ForeignKey("Order")]
        public int OrderID { get; set; }

        [ForeignKey("Product")]
        [MaxLength(20)]
        public string ProductBarcode { get; private set; }

        [Required]
        public int Quantity { get; set; }

        public Order Order { get; set; }

        public Product Product { get; set; }

        private OrdersProductsQuantities()
        {

        }

        public OrdersProductsQuantities(string productBarcode, int quantity)
        {
            this.ProductBarcode = productBarcode;
            this.Quantity = quantity;
        }

    }
}
