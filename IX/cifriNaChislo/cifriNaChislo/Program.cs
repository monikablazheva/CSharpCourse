using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cifriNaChislo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; n > 0; i++)
            {
                sum += n % 10;
                n = n / 10;
            }
            Console.WriteLine(sum);
        }
    }
}
