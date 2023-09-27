using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Landscaping_Monika_Blazheva
{
    class Program
    {
        static void Area_square(double a)
        {
            if (a > 0)
            {
                double area1 = a * a;
                double area2 = (a + 1) * (a + 1);
                Console.WriteLine("Площта на градина1 със страна {0:f2} м. е {1:f2} кв.м.", a, area1);
                Console.WriteLine("Площта на градина2 със страна {0:f2} м. е {1:f2} кв.м.", a + 1, area2);
            }
            else if (a <= 0)
            {
                Console.WriteLine("Invalid values! Please, try again!");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете страната а: ");
            double a = double.Parse(Console.ReadLine());
            Area_square(a);
        }
    }
}
