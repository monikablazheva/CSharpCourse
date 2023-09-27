using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessLayer
{
    public partial class Order
    {
        public Order()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        public int OrderId { get; set; }
        public decimal CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public string ShipAdress { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
