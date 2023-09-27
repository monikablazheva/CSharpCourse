using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faktoriel
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int fakt = 1;

            for (int i = 1; i <= n; i++)
            {
                fakt *= i;
            }
            Console.WriteLine(fakt);
        }
    }
}
