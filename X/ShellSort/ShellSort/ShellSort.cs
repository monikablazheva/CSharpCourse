using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellSort
{
    class ShellSort
    {
        int SortMethod(int[] arr)
        {
            int n = arr.Length;
            for(int gap = n/2; gap > 0; gap/=2)
            {
                for(int i = gap; i < n; i+=1)
                {
                    int temp = arr[i];
                    int j;
                    for(j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                    {
                        arr[j] = arr[j - gap];
                    }

                    arr[j] = temp;
                }
            }
            return 0;
        }
    }
}
