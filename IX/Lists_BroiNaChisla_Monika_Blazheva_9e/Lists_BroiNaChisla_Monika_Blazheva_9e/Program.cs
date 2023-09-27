using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_BroiNaChisla_Monika_Blazheva_9e
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            numbers.Sort();
            int i = 0;
            while(i < numbers.Count)
            {
                int num = numbers[i];
                int count = 1;
                while(i + count < numbers.Count && numbers[i + count] == num)
                {
                    count++;
                }
                i += count;
                Console.WriteLine("{0} -> {1}", num, count);
            }
        }
    }
}
