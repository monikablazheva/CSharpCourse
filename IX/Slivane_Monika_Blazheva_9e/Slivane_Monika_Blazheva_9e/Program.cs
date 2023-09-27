using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slivane_Monika_Blazheva_9e
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m, i;
            Console.WriteLine("Vuvedete broq na elementite na purviq masiv: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Vuvedete broq na elementite na vtoriq masiv: ");
            m = int.Parse(Console.ReadLine());
            int[] arrN = new int[n];
            int[] arrM = new int[m];
            int[] newArray = new int[n + m];
            Console.WriteLine("Vuvedete elementite na purviq masiv: ");
            for(i = 0; i < n; i++)
            {
                arrN[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Vuvedete elementite na vtoriq masiv: ");
            for (i = 0; i < m; i++)
            {
                arrM[i] = int.Parse(Console.ReadLine());
            }
            Array.Copy(arrN, newArray, n);
            Array.Copy(arrM, 0, newArray, n, m);
            Array.Sort(newArray);
            Console.WriteLine("Tretiq obedinen i sortiran masiv:");
            foreach(int num in newArray)
            {
                Console.Write(" " + num);
            }
        }
    }
}
