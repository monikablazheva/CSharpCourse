using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search
{
    class Program
    {
        private static int BinarySearch(int[] arr, int value)
        {
            int left = 0, right = arr.Length - 1;
            while (left <= right)
            {
                int middle = (left + right) / 2;
                if (arr[middle] == value)
                {
                    return middle;
                }
                else if (arr[middle] < value)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ', ',').Select(int.Parse).ToArray();
            
            SelectionSort.Sort(array);
            Console.WriteLine();

            int n = int.Parse(Console.ReadLine());

            int index = BinarySearch(array, n);

            if (index == -1) Console.WriteLine("No such element");
            else Console.WriteLine("The element is on index " + index);
        }
    }
}
