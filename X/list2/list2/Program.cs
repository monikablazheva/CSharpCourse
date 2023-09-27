
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list2
{
    class Program
    {
        public static void ReturnsTheLongestSequenceOfEqualNumbers (List<int> list)
        {
            List<int> longestSequence = new List<int>();
            int count = 1, longestCount = 1;
            int theNumber = list[0];
            for(int i = 1; i < list.Count; i++)
            {
                if(list[i] != list[i-1])
                {
                    count=0;
                }
                count++;
                if(longestCount < count)
                {
                    longestCount = count;
                    theNumber = list[i];
                }
            }
            for(int i = 0; i < longestCount; i++)
            {
                longestSequence.Add(theNumber);
            }
            Console.WriteLine("The longest sequence of equal numbers is: ");
            foreach(int i in longestSequence)
            {
                Console.Write(longestSequence[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the elements of the list: ");
            List<int> list = Console.ReadLine().Split(' ', ',').Select(int.Parse).ToList();
            ReturnsTheLongestSequenceOfEqualNumbers(list);
        }

    }
}
