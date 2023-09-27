using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nizove_TriteImena_9e
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string[] array = name.Split(' ');
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
