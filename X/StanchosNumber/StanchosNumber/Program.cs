using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StanchosNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stancho's number is: {0}. Guessed with {1} turns.", 800, ElisStrategy.Guess(800));
        }
    }
}
