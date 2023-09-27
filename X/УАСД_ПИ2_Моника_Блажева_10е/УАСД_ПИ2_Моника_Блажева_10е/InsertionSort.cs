using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace УАСД_ПИ2_Моника_Блажева_10е
{
    class InsertionSort
    {
        public static void InsertSort(double[] array)
        {
            int n = array.Length;
            int j = 0;
            for (int i = 1; i < n; i++)
            {
                j = i - 1;
                while (j >= 0 && array[j] <= array[j + 1])
                {
                    double swap = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = swap;
                    j--;
                }
            }
            foreach (double i in array)
            {
                Console.Write(i + " ");
            }
        }
    }
}
