using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessLayer
{
    public partial class Product
    {
        public Product()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Descr { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
