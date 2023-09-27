using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second_name_Monika_Blazheva_9e
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] arr = str.Split('-', ' ', '/', '*');
            char c = ' ';
            if (str.ToLower().Contains('-'))
            {
                c = '-';
            }
            else if (str.ToLower().Contains(' '))
            {
                c = ' ';
            }
            else if (str.ToLower().Contains('/'))
            {
                c = '/';
            }
            else if (str.ToLower().Contains('*'))
            {
                c = '*';
            }
            string result = arr[0] + c + arr[2];
            Console.WriteLine(result);
        }
    }
}
