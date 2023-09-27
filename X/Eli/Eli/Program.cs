using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eli
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Stancho's num: {0}, turns: {1}", n, Strategy.guessStanchosNumber(n));
        }
    }
}
