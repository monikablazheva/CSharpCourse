using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace symmetry_array_Monika_Blazheva_9e
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] arr1 = str.Split(' ', ',');
            int[] arr2 = new int[arr1.Length];
            for(int i = 0; i < arr1.Length; i++)
            {
                arr2[i] = int.Parse(arr1[i]);
            }
            bool symmetric = true;
            for (int i = 0; i < arr2.Length / 2; i++)
            {
                if (arr2[i] != arr2[arr2.Length - i - 1])
                {
                    symmetric = false;
                    break;
                }
            }
            if (symmetric == true)
            {
                Console.WriteLine("Yes");
                int sum = 0;
                for (int i = 0; i < arr2.Length; i++)
                {
                    sum += arr2[i];
                }
                Console.WriteLine(sum);
            }
            else Console.WriteLine("No");
        }
    }
}
