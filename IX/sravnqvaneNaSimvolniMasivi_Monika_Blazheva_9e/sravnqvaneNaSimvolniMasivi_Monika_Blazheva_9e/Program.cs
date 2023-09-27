using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sravnqvaneNaSimvolniMasivi_Monika_Blazheva_9e
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            bool b = true;
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            char[] arr1 = str1.ToCharArray();
            char[] arr2 = str2.ToCharArray();
            int minLen = Math.Min(arr1.Length, arr2.Length);
            for (i = 0; i < minLen; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    continue;
                }
                else
                {
                    b = false;
                    if (arr1[i] < arr2[i])
                    {
                        for (i = 0; i < arr1.Length; i++)
                        {
                            Console.Write(arr1[i]);
                        }
                        Console.WriteLine();
                        for (i = 0; i < arr2.Length; i++)
                        {
                            Console.Write(arr2[i]);
                        }
                        Console.WriteLine();
                        Console.WriteLine("The first char array is lexicografically before the second.");
                    }
                    else
                    {
                        for (i = 0; i < arr2.Length; i++)
                        {
                            Console.Write(arr2[i]);
                        }
                        Console.WriteLine();
                        for (i = 0; i < arr1.Length; i++)
                        {
                            Console.Write(arr1[i]);
                        }
                        Console.WriteLine();
                        Console.WriteLine("The second char array is lexicografically before the first.");
                    }
                } 
            }
            if(b == true && arr1.Length < arr2.Length)
            {
                for(i = 0; i < arr1.Length;i++)
                {
                    Console.Write(arr1[i]);
                }
                Console.WriteLine();
                for (i = 0; i < arr2.Length; i++)
                {
                    Console.Write(arr2[i]);
                }
                Console.WriteLine();
                Console.WriteLine("The first char array is lexicografically before the second.");
            }
            else if(b == true && arr1.Length > arr2.Length)
            {
                for (i = 0; i < arr2.Length; i++)
                {
                    Console.Write(arr2[i]);
                }
                Console.WriteLine();
                for (i = 0; i < arr1.Length; i++)
                {
                    Console.Write(arr1[i]);
                }
                Console.WriteLine();
                Console.WriteLine("The second char array is lexicografically before the first.");
            }
            else if(b == true && arr1.Length == arr2.Length)
            {
                for (i = 0; i < arr1.Length; i++)
                {
                    Console.Write(arr1[i]);
                }
                Console.WriteLine();
                for (i = 0; i < arr2.Length; i++)
                {
                    Console.Write(arr2[i]);
                }
                Console.WriteLine();
                Console.WriteLine("The arrays are equal.");
            }
        }
    }
}
