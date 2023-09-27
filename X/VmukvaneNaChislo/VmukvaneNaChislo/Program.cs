using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VmukvaneNaChislo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Array.Sort(arr);
            int n = int.Parse(Console.ReadLine());
            int[] extendedArr = new int[arr.Length + 1];
            if(n <= arr[0])
            {
                Array.Copy(arr, 0, extendedArr, 1, arr.Length);
                extendedArr[0] = n;
                arr = extendedArr;
            }
            else if(n >= arr[arr.Length - 1])
            {
                Array.Copy(arr, extendedArr, arr.Length);
                extendedArr[arr.Length] = n;
                arr = extendedArr;
            }
            else
            {
                int index = 0;
                for(int i = 1; i < arr.Length - 1; i++)
                {
                    if(n <= arr[i + 1] && n >= arr[i - 1])
                    {
                        index = i;
                    }
                }
                Array.Copy(arr, extendedArr, index);
                Array.Copy(arr, index, extendedArr, index + 1, arr.Length - index);
                extendedArr[index] = n;
                arr = extendedArr;
            }
            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }
        }
    }
}
