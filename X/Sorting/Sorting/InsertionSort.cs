using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class InsertionSort
    {
        public static void InsertSort(int[] array)
        {
            int n = array.Length;
            int j = 0;
            for(int i = 1; i < n; i++)
            {
                j = i - 1;
                while(j >= 0 && array[j] >= array[j+1])
                {
                    int swap = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = swap;
                    j--;
                }
            }
            foreach(int i in array)
            {
                Console.Write(i + " ");
            }
        }
    }
}
