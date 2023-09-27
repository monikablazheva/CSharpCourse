using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsSort
{
    class Program
    {
        private static void SelectionSorting(char[] array, int l)
        {
            for (int i = 0; i < l - 1; i++)
            {
                for (int j = i + 1; j < l; j++)
                {
                    if (array[j] < array[i])
                    {
                        char swap = array[j];
                        array[j] = array[i];
                        array[i] = swap;
                    }
                }
            }
            foreach (char c in array)
            {
                Console.Write(c);
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            char[] chars = s.ToCharArray();
            SelectionSorting(chars, l);

        }
    }
}
