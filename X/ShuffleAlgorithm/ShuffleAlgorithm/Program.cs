using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShuffleAlgorithm
{
    class Program
    {
        public static void Shuffle(int[] array)
        {
            Random random = new Random();
            int n = array.Length;
            for(int i = 0; i < n-1; i++)
            {
                int r = i + (int)(random.NextDouble() * (n - 1));
            }
        }
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Shuffle(arr);
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }

    }
}
