using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriugulnikPAndS
{
    class Program
    {
        static void CheckIfThereIsTriangle(double a, double b, double c)
        {
            
            if ((a + b) > c)
            {
                Console.WriteLine("There is a possible triangle");
                CalculatesPerimeterAndArea(a, b, c);
            }
            else
                Console.WriteLine("There isn't possible triangle");
        }
        static void CalculatesPerimeterAndArea(double a, double b, double c)
        {
            double P = a + b + c;
            double p = P / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Console.WriteLine("The perimeter of the triangle is {0}", P);
            Console.WriteLine("The area of the triangle is {0}", S);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete n:");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Vuvedete a:");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Vuvedete b:");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Vuvedete c:");
                double c = double.Parse(Console.ReadLine());
                CheckIfThereIsTriangle(a, b, c);
            }
        }
    }
}
