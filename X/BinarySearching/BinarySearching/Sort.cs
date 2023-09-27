using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearching
{
    static class Sort
    {
        public static int[] SelectionSort(int[] arr)
        {
            int n = arr.Length;
            for(int i = 0; i < n - 1; i++)
            {
                for(int j = i + 1; j < n; j++)
                {
                    if(arr[j] < arr[i])
                    {
                        int swap = arr[j];
                        arr[j] = arr[i];
                        arr[i] = swap;
                    }
                }
            }
            return arr;
        }
    }
}
