using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BusinessLayer
{
    public class Order
    {
        [Key]
        public int ID { get; private set; }

        public decimal Price { get; set; }

        public DateTime OrderDate { get; private set; }

        public DateTime DeliveryDate { get; set; }

        [Required]
        public Customer Customer { get; set; }

        [ForeignKey("Customer")]
        public int CustomerID { get; set; }

        // will be added afterwards! [nullable]
        public IEnumerable<OrdersProductsQuantities> OPQ { get; set; }


        private Order()
        {
            // overwriting the Hashset<T> implementation
            this.OPQ = new List<OrdersProductsQuantities>();
        }

        public Order(Customer customer)
        {
            this.Customer = customer;
            this.OrderDate = DateTime.Now;
        }

    }
}
