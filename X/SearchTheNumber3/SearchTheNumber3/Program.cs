using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchTheNumber3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the numbers of the array:");
            int[] array = Console.ReadLine().Split(' ', ',').Select(int.Parse).ToArray();
            Console.WriteLine("The sorted array: ");
            Sorting.SelectionSort(array);
            Console.WriteLine();
            Console.WriteLine("Enter the searched number:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("The number is on index: " + Search.SearchTheNumber(array, number));
            
        }
    }
}
