using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace svetofar
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            string str3 = Console.ReadLine();
            string newString = String.Concat(str1, str2, str3);

            if (newString == "bbg")
            {
                Console.WriteLine("black");
                Console.WriteLine("black");
                Console.WriteLine("GREEN");
            }
            else if (newString == "bbG")
            {
                Console.WriteLine("black");
                Console.WriteLine("yellow");
                Console.WriteLine("black");
            }
            else if (newString == "byb")
            {
                Console.WriteLine("red");
                Console.WriteLine("black");
                Console.WriteLine("black");
            }
            else if (newString == "rbb")
            {
                Console.WriteLine("red");
                Console.WriteLine("yellow");
                Console.WriteLine("black");
            }
            else if (newString == "ryb")
            {
                Console.WriteLine("black");
                Console.WriteLine("black");
                Console.WriteLine("green");
            }
            else if (newString == "bYb")
            {
                Console.WriteLine("black");
                Console.WriteLine("YELLOW");
                Console.WriteLine("black");
            }
            else Console.WriteLine("error");
        }
    }
}
