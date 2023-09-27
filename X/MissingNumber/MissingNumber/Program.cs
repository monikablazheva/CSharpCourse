using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingNumber
{
    class Program
    {
        private static void FindsTheMissingNumberWithLoop(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] != i)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        } 
        static void Main(string[] args)
        {
            int[] array = { 0, 1, 2, 3, 4, 6, 7, 8, 9 };
            FindsTheMissingNumberWithLoop(array);
        }
    }
}
