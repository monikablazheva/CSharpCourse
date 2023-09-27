using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_1
{
    class Human
    {
        public string name;
        public int age;
        public void introduseYourSelf()
        {
            Console.WriteLine("Моето име е: {0} аз съм на {1} години.", name, age);
        }
        public string Name
        {
            get { return name; }
            set { this.name = value; }

        }
        public int Age
        {
            get { return age; }
            set { this.age = value; }

        }
    }
}
