using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nizove_5zad_Monika_9e
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            int count = 0;
            int index = 0;
            for(int i = 0; i < str1.Length; i++)
            {
                int a = str1.IndexOf(str2, index);
                if(a > -1)
                {
                    count++;
                    index = a + str2.Length;
                }
            }
            Console.WriteLine(count);
        }
    }
}
