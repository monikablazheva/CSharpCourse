using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Pharmacy
{
    class Medicine
    {
        private string name;
        private double price;

        public Medicine(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name
        {
            get => this.name;
            set
            {
                if ((this.name.Length < 3) && (System.Text.RegularExpressions.Regex.IsMatch(this.name, @"^[a-zA-Z0-9\_]+$"))) throw new ArgumentException("Invalid name");
                this.name = value;
            }
        }
        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (this.price < 0) throw new ArgumentException("Invalid price");
                this.price = value;
            }
        }
    }
}
