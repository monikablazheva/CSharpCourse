using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortedListOfNumbers_Monika_Blazheva_9e
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete broq na elementite za lista: ");
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();
            Console.WriteLine("Vuvedete elementite na lista: ");
            for(int i = 0; i < n; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }
            numbers.Sort();

            Console.Write(numbers[0]);
            for(int i = 1; i < n; i++)
            {
                Console.Write(" <= " + numbers[i]);
            }
        }
    }
}
