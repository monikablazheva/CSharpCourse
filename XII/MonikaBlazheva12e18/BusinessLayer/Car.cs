using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    [SerializableAttribute]
    public class Car
    {
        public string ID { get; private set; }
        public string Brand { get; private set; }
        public decimal Price { get; private set; }
        public string Color { get; private set; }
        private Car()
        {

        }
        public Car(string brand, decimal price, string color)
        {
            this.ID = Guid.NewGuid().ToString();
            Brand = brand;
            Price = price;
            Color = color;

        }
    }
}
