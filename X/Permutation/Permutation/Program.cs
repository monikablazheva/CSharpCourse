using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutation
{
    class Program
    {
        public static void Print1ToN(int n)
        {
            if (n > 1)
            {
                Print1ToN(n - 1);
                Console.WriteLine(n);
                //Print1ToN(n - 1);
            }
            else Console.WriteLine(1);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Print1ToN(n);
        }
    }
}
