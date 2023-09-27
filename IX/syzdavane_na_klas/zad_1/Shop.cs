using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_1
{
    class Shop
    {
        public string name;
        public string type;
        public uint count;
        public string Name
        {
            get { return name; }
            set { this.name = value; }

        }
        public string Type
        {
            get { return type; }
            set { this.type = value; }

        }
        public uint Count
        {
            get { return count; }
            set { this.count = value; }

        }
    }
}
