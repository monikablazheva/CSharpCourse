using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Random r = new Random();
            for(int i = 0; i < 100; i++)
            {
                Console.WriteLine(r.Next(a, b));
            }
        }
    }
}
