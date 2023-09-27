using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObedinenieSechenie
{
    class Program
    {
        private static void Union(List<int> list1, List<int> list2)
        {
            List<int> list = new List<int>();
            list.AddRange(list1);
            for (int i = 0; i < list2.Count; i++)
            {
                if(!list.Contains(list2[i]))
                {
                    list.Add(list2[i]);
                }
            }
            list.Sort();
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
        }
        private static void InterSect(List<int> list1, List<int> list2)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < list2.Count; i++)
            {
                if (list1.Contains(list2[i]))
                {
                    list.Add(list2[i]);
                }
            }
            list.Sort();
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
        }
        private static void Merge(List<int> list1, List<int> list2)
        {
            list2.AddRange(list1);
            list2.Sort();
            foreach (int i in list2)
            {
                Console.Write(i + " ");
            }
        }
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList<int>();
            List<int> list2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList<int>();
            Union(list1, list2);
            Console.WriteLine();

            InterSect(list1, list2);
            Console.WriteLine();

            Merge(list1, list2);
            Console.WriteLine();

            List<string> line = Console.ReadLine().Split(' ').ToList<string>();
            line.Sort();
            Console.WriteLine();
            foreach(string str in line)
            {
                Console.Write(str + " ");
            }
        }
    }
}
