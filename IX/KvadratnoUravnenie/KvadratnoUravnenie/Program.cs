using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KvadratnoUravnenie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Vuvedete b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Vuvedete c:");
            double c = double.Parse(Console.ReadLine());
            double d = b * b - 4 * a * c;
            double x1, x2;
            if(d > 0)
            {
                x1 = (-b + (Math.Sqrt(d))) / 2 * a;
                x2 = (-b - (Math.Sqrt(d))) / 2 * a;
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
            else if(d == 0)
            {
                x1 = x2 = -b /(2 * a);
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
            else if(d < 0)
            {
                Console.WriteLine("Nqma reshenie");
            }
        }
    }
}
