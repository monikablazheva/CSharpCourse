using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_chislaKvadrati_Monika_Blazheva_9e
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete broq na elementite na lista: ");
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();
            Console.WriteLine("Vuvedete elementite na lista: ");
            for(int i = 0; i < n; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }
            List<int> squares = new List<int>();
            foreach(int num in numbers)
            {
                if (Math.Sqrt(num) == (int)Math.Sqrt(num))
                {
                    squares.Add(num);
                }
            }
            squares.Sort((a,b) => b.CompareTo(a));
            foreach(int num in squares)
            {
                Console.Write(" " + num);
            }
        }
    }
}
