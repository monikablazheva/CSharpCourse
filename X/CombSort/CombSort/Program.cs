using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombSort
{
    class Program
    {
        public static void CombSort(int[] data)
        {
            double gap = data.Length;
            bool swaps = true;

            while (gap > 1 || swaps)
            {
                gap /= 1.247330950103979;
                if (gap < 1)
                    gap = 1;
                int i = 0;
                swaps = false;

                while (i + gap < data.Length)
                {
                    int igap = i + (int)gap;
                    if (data[i] > data[igap])
                    {
                        int temp = data[i];
                        data[i] = data[igap];
                        data[igap] = temp;
                        swaps = true;
                    }
                    ++i;
                }
            }
        }

        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            CombSort(arr);
            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }
        }
    }
}
