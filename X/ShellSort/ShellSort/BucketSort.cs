using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellSort
{
    class BucketSort
    {
        static void SortMethod(float[] arr, int n)
        {
            if (n <= 0)
                return;
            List<float>[] buckets = new List<float>[n];
            for (int i = 0; i < n; i++)
            {
                buckets[i] = new List<float>();
            }
            for (int i = 0; i < n; i++)
            {
                float idx = arr[i] * n;
                buckets[(int)idx].Add(arr[i]);
            }
            for (int i = 0; i < n; i++)
            {
                buckets[i].Sort();
            }
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < buckets[i].Count; j++)
                {
                    arr[index++] = buckets[i][j];
                }
            }
        }
    }
}
