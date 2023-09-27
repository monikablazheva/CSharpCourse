using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomEvensAndOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Random random = new Random();
            List<int> listEvens = new List<int>();
            List<int> listOdds = new List<int>();
            for (int i = 0; i <= n; i++)
            {
                int number = random.Next(1, 101);
                if(number % 2 == 0)
                {
                    listEvens.Add(number);
                }
                else
                {
                    listOdds.Add(number);
                }
            }
            listOdds.Reverse();
            listEvens.Concat(listOdds);
            foreach(int i in listEvens)
            {
                Console.Write(i + " ");
            }
        }
    }
}
