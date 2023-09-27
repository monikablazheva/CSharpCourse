using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeanMedianMode
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            int[] numbers = line.Split(' ', ',').Select(int.Parse).ToArray();
            double mean = Mean(numbers);
            double median = Median(numbers);
            Console.WriteLine("Mean: {0}", mean);
            Console.WriteLine("Median: {0}", median);
            Mode(numbers);
        }
        private static double Mean(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            double mean = sum / array.Length;
            return mean;
        }
        private static double Median(int[] array)
        {
            Array.Sort(array);
            int length = array.Length;
            double median = 0;
            if (length % 2 == 0)
            {
                median = array[length / 2] + array[(length / 2) + 1];
            }
            else
            {
                median = array[Convert.ToInt32(length / 2)];
            }
            return median;
        }
        private static void Mode(int[] array)
        {
            List<int> modes = new List<int>();
            Array.Sort(array);
            int count = 1;
            Dictionary<int, int> counts = new Dictionary<int, int>();
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    count++;
                }
                else
                {
                    counts.Add(array[i], count);
                    count = 1;
                }
            }
            counts = counts.OrderByDescending(u => u.Value).ToDictionary(z => z.Key, y => y.Value);
            var first = counts.First();
            int firstValue = first.Value;
            foreach (KeyValuePair<int, int> c in counts)
            {
                if (firstValue == c.Value)
                {
                    modes.Add(c.Key);
                }
            }
            Console.Write("Mode: ");
            if(counts.All(value => value.Value.Equals(1)))
            {
                foreach(int i in array)
                {
                    Console.Write(i + " ");
                }
                Console.Write("(No mode)");
            }
            else
            {
                foreach (int i in modes)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
