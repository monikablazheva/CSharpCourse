using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 10, c;
            double result = 200;
            if (a > b)
            {
                Console.Write(a);
            }
            else c = --b; result--;
            
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
