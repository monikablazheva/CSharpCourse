using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortiraneNizhodqshtRed_Monika_Blazheva_9e
{
    class Program
    {
        static void Main(string[] args)
        {
            //int min = Int16.MaxValue;
            string str = Console.ReadLine();
            string[] arr = str.Split(' ');
            int[] numbers = new int[arr.Length];
            for(int i = 0; i < arr.Length; i++)
            {
                numbers[i] = int.Parse(arr[i]);
            }
            Array.Sort(numbers);
            Array.Reverse(numbers);
            foreach(int num in numbers)
            {
                Console.Write(" " + num);
            }
            /*for(int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < arr.Length;j++)
                {
                    if(numbers[j] < min)
                    {
                        min = numbers[j];
                    }
                }
                numbers[i] = min;
                min = Int16.MaxValue;
            }
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(" " + numbers[i]);
            }*/
        }
    }
}
