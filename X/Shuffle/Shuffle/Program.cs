using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shuffle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 6, 7, 8, 9, 10 };

            Random r = new Random();

            for (int i = 0; i < arr.Length; i++)

            {

                int randomIndex = r.Next(0, arr.Length - 1);

                int randomIndex2 = r.Next(0, arr.Length - 1);

                int swap = arr[randomIndex2];

                arr[randomIndex2] = arr[randomIndex];

                arr[randomIndex] = swap;

            }
            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }
        }
    }
}
