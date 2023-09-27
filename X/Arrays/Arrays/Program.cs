using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr1 = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            SelectionSort.Sort(arr1);
            double[] arr2 = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            SelectionSort.Sort(arr1);
            double[] mergeArr = new double[arr1.Length + arr2.Length];
            Array.Copy(arr1, mergeArr, arr1.Length);
            Array.Copy(arr2, 0, mergeArr, arr1.Length, arr2.Length);
            SelectionSort.Sort(mergeArr);
            foreach (double i in mergeArr)
            {
                Console.Write(i + " ");
            }
        }
    }
}
