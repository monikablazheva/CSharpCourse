using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bonusTochki
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete chislo");
            int a = int.Parse(Console.ReadLine());
            if (a <= 100)
            {
                Console.WriteLine(a + 5);
            }
            else if (a > 100 && a < 1000)
            {
                Console.WriteLine(a + a * 20 / 100);
            }
            else if (a >= 1000)
            {
                Console.WriteLine(a + a * 10 / 100);
            }
            Console.ReadLine();
        }
    }
}
