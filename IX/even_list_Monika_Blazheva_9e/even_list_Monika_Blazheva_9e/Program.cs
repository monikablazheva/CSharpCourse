using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace even_list_Monika_Blazheva_9e
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            List<int> nums = Console.ReadLine().Split(' ', ',').Select(int.Parse).ToList();
            List<int> evens = new List<int>();
            for(int i = 0; i < nums.Count; i++)
            {
                if(nums[i] % 2 == 0)
                {
                    evens.Add(nums[i]);
                }
            }
            evens.Reverse();
            for (int i = 0; i < evens.Count; i++)
            {
                sum += evens[i];
            }
            foreach(int even in evens)
            {
                Console.WriteLine(even);
            }
            Console.WriteLine("Sumsta na chetnite chisla ot spisuka e: {0}", sum);
        }
    }
}
