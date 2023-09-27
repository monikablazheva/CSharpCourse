using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchTheNumber3
{
    class Sorting
    {
        public static void SelectionSort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[i])
                    {
                        int swap = array[j];
                        array[j] = array[i];
                        array[i] = swap;
                    }
                }
            }
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
        }
    }
}
