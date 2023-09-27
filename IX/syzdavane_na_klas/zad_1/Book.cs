using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_1
{
    class Book
    {
        public string name;
        public double price;
        public string author;
        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }
        public double Price
        {
            get { return price; }
            set { this.price = value; }
        }
        public string Author
        {
            get { return author; }
            set { this.author = value; }
        }
    }
}
