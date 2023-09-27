using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nizove_IndexOf_Monika_9e
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char a = Console.ReadKey().KeyChar;
            char[] arr = str.ToCharArray();
            int count = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == a)
                {
                    count++;
                }
            }
            Console.WriteLine();
            Console.WriteLine(count);
        }
    }
}
