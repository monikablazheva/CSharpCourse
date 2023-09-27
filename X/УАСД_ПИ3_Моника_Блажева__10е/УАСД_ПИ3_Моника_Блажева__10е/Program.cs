using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace УАСД_ПИ3_Моника_Блажева__10е
{
    class Program
    {
        private static void Arragement(int[] array)
        {
            int count = 0;
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int swap = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = swap;
                        Console.WriteLine("[{0}]<-->[{1}]", array[j + 1], array[j]);
                        count++;
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No exchanges");
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Arragement(arr);
        }
    }
}
