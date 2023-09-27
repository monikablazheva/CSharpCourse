using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proverka_Monika_Blazheva
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete chislo:");
            int number = int.Parse(Console.ReadLine());

            bool prime = true;
            int count = (int)Math.Sqrt(number);
            for (int i = 2; i <= count; i++)
            {
                if ((number % i) == 0)
                {
                    prime = false;
                    break;
                }
            }
            Console.WriteLine((prime ? "prime" : "not prime"));
        }
    }
}
