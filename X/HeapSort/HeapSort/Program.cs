using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSort
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Sort sortedArray = new Sort();
            sortedArray.HeapSort(array);

            Console.WriteLine("The sorted array is:");
            sortedArray.PrintArray(array);
        }
    }
}
