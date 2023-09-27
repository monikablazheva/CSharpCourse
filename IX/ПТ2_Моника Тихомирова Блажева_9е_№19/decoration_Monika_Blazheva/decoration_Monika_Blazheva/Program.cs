using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decoration_Monika_Blazheva
{
    class Program
    {
        static void RowM(int start, int end)
        {
            for (int j = start; j <= end; j++)
            {
                Console.Write(". ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете числото М: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                RowM(1, i);
            }   
        }
    }
}
