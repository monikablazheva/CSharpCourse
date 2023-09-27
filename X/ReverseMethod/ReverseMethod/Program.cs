using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseMethod
{
    class Program
    {
        public static void Reverse(List<int> list)
        {
            int n = list.Count;
            for(int i = 0; i < n / 2; i++)
            {
                int swap = list[i];
                list[i] = list[n - i - 1];
                list[n - i - 1] = swap;
            }
            foreach(int i in list)
            {
                Console.Write(i + " ");
            }
        }
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Reverse(list);
        }
    }
}
