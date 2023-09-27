using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurseneNaElement_Monika_Blazheva_9e
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b = false;
            Console.WriteLine("Vuvedete broq na elementite na masiva: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Vuvedete elementite na masiva: ");
            for(int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Vuvedete elementa za proverka: ");
            int a = int.Parse(Console.ReadLine());
            Array.Sort(arr);
            foreach(int num in arr)
            {
                if (num == a)
                {
                    b = true;
                    break;
                }
            }
            if (b == true)
            {
                Console.WriteLine("Yes");
            }
            else Console.WriteLine("No");
        }
    }
}
