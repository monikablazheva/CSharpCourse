using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class CountingSort
    {
        public static void CountSort(int[] arr)
        {
            int n = arr.Length;
            int[] output = new int[n];
            int[] count = new int[256];
            for(int i = 0; i < 256; ++i)
            {
                count[i] = 0;
            }
            for (int i = 0; i < n; ++i)
            {
                ++count[arr[i]];
            }
            for (int i = 1; i <= 255; ++i)
            {
                count[i] += count[i - 1];
            }
            for(int i = n - 1; i >= 0; i--)
            {
                output[count[arr[i]] - 1] = arr[i];
                --count[arr[i]];
            }
            for (int i = 0; i < n; ++i)
            {
                arr[i] = output[i];
            }
            for(int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
