using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowestAndHigherNumber
{
    class Program
    {
        static int GetMin(int a, int b)
        {
            if (a < b)
            {
                return a;
            }
            if (b < a)
            {
                return b;
            }
        } 
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            var min = GetMin(GetMin(a, b), c);
        }
    }
}
