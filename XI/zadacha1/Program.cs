using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            DynamicList a = new DynamicList();
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                {
                    a.Add(arr[i]);
                }
                else
                {
                    count++;
                }
            }
            for (int i=0;i<arr.Length-count;i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
