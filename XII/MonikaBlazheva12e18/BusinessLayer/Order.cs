using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    [SerializableAttribute]
    public class Order
    {
        public string ID { get; private set; }
        public string CustomerName {get; private set;}
        public string Address { get; private set; }
        public decimal Price { get; private set; }
        public int Quantity { get; private set; }

        public Car Car { get; set; }

        private Order()
        {

        }
        public Order(string customerName, string address, decimal price, int quantity, Car car)
        {
            this.ID = Guid.NewGuid().ToString();
            CustomerName = customerName;
            Address = address;
            Price = price;
            Quantity = quantity;
            Car = car;
        }
    }
}
