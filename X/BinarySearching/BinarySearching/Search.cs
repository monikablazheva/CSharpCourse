using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearching
{
    static class Search
    {
        public static int BinarySearching(int[] arr, int number)
        {
            int left = 0;
            int right = arr.Length - 1;
            
            while(left <= right)
            {
                int middle = (left + right) / 2;

                if(arr[middle] == number)
                {
                    return middle;
                }
                else if(arr[middle] > number)
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }
            return -1;
        }
    }
}
