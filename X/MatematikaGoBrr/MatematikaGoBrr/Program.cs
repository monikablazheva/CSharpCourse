using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatematikaGoBrr
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            Array.Sort(array);

            double min = array[0];
            double max = array[array.Length - 1];

            double r = max - min;
        }
    }
}
