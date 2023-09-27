using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pogolqmo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete purvoto chislo:");
            int numA = int.Parse(Console.ReadLine());
            Console.WriteLine("Vuvedete vtoroto chislo:");
            int numB = int.Parse(Console.ReadLine());
            if (numA > numB)
            {
                Console.WriteLine(numA);
            }
            else
            {
                Console.WriteLine(numB);
            }
        }
    }
}
