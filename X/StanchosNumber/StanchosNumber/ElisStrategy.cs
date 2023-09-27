using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StanchosNumber
{
    class ElisStrategy
    {
        public static int Guess(int number)
        {
            int left = 1;
            int right = 1000;
            int turns = 0;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (number == mid)
                    return turns;
                if (number < mid)
                    right = mid - 1;
                else
                    left = mid + 1;
                turns++;
            }
            return -1;
        }
    }
}
