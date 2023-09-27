using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linuravnenie
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double sum = -(b / a);
            if(a == 0)
            {
                if(b > 0)
                {
                    Console.WriteLine("Vx e reshenie");
                }
                else if(b <= 0)
                {
                    Console.WriteLine("Nqma reshenie");
                }
            }
            else
            {
                if(a > 0)
                {
                    Console.WriteLine("x > " + Math.Round(sum, 2));
                }
                else if(a < 0)
                {
                    Console.WriteLine("x < " + Math.Round(sum, 2));
                }
            }
        }
    }
}
