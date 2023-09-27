using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixDrunDrun
{
    class Search
    {
        public static int InterpolationSearch(int[] arr, int number, int low, int high)
        {
            //int low = 0;
            //int high = arr.Length - 1;
            while (low <= high && number >= arr[low] && number <= arr[high])
            {
                if (low == high)
                {
                    if (arr[low] == number)
                    {
                        return low;
                    }
                    else
                    {
                        return -1;
                    }
                }
                int position = low + (((high - low) / (arr[high] - arr[low])) * (number - arr[low]));
                if (arr[position] == number)
                {
                    if (position + 1 < high && position + 1 == number)
                    {
                        InterpolationSearch(arr, number, position + 1, high);
                    }
                    if (position - 1 > low && position - 1 == number)
                    {
                        InterpolationSearch(arr, number, low, position - 1);
                    }
                }
                if (arr[position] == number)
                {
                    return position;
                }
                if (arr[position] < number)
                {
                    low = position + 1;
                }
                else
                {
                    high = position - 1;
                }
            }
            return -1;
        }
    }
}
