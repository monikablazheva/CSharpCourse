using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the array:");
            int[] array = Console.ReadLine().Split(',', ' ').Select(int.Parse).ToArray();

            Console.WriteLine("Input the searched number:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("The sorted array:");
            Sort.SelectionSort(array);
            foreach(int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            if(Search.BinarySearching(array, a) == -1)
            {
                Console.WriteLine("The number isn't in the array");
            }
            else
            {
                Console.WriteLine("The index of the number in the sorted array is:" + Search.BinarySearching(array, a));
            }
            
        }
    }
}
