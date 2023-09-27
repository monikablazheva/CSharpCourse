using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vmukvaneNaElementVSortiranMasiv_Monika_Blazheva_9e
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete duljinata na masiva: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Vuvedete elementite na masiva: ");
            for(int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(arr);
            Console.WriteLine("Vuvedete dopulnitelniq element: ");
            int a = int.Parse(Console.ReadLine());
            int[] newArr = new int[n + 1];
            for (int i = 0; i < n; i++)
            {
                newArr[i] = arr[i];
            }
            newArr[n] = a;
            Array.Sort(newArr);
            for(int i = 0; i < n + 1; i++)
            {
                Console.Write(" " + newArr[i]);
            }
        }
    }
}
