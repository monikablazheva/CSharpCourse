using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eli
{
    static class Strategy
    {
        public static int guessStanchosNumber(int number)
        {
            int left = 1, right = 1000, turns = 0;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                int a = guessStanchosNumber(mid); 
                if (a == mid)
                    return turns;
                if (a < mid)
                    right = mid - 1;
                else
                    left = mid + 1;
                turns++;
            }
            return -1;
        }
    }
}
