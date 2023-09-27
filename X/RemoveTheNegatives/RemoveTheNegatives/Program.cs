using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveTheNegatives
{
    class Program
    {
        /*static public void ReturnsThePositiveElements(List<int> list)
        {
            List<int> positiveElements = new List<int>();
            foreach(int i in list)
            {
                if(i > 0)
                {
                    positiveElements.Add(i);
                }
            }
            foreach (int j in positiveElements)
            {
                Console.Write(" " + j);
            }
        }*/
        static void Main(string[] args)
        {
            /*Console.WriteLine("Enter the elements of the list: ");
            List<int> list = Console.ReadLine().Split(' ', ',').Select(int.Parse).ToList();
            ReturnsThePositiveElements(list);*/
            int[] arr2 = { 4, 2, 2, 5, -2, 3, -2, 3, 1, 5, 2 };
            DynamicList numList = new DynamicList();
            foreach (int i in arr2)
            {
                if (i > 0)
                {
                    numList.Add(i);
                }
            }
            for(int i = 0; i < numList.Count; i++)
            {
                Console.Write(numList[i] + " ");
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                int count = 0;
                for(int j = 0; j < arr2.Length; i++)
                {
                    if (arr2[i] == arr2[j])
                    {
                        count++;
                    }
                }
                if (count % 2 == 0)
                {
                    numList.Add(arr2[i]); 
                }
            }
            for (int i = 0; i < numList.Count; i++)
            {
                Console.Write(numList[i] + " ");
            }

        }
    }
}
