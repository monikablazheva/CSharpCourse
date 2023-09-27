using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nizove_6zad_Monika_9e
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete purviq niz za sravnenie:");
            string str1 = Console.ReadLine();
            Console.WriteLine("Vuvedete vtoriq niz za sravnenie: ");
            string str2 = Console.ReadLine();
            char[] arr1 = str1.ToCharArray();
            char[] arr2 = str2.ToCharArray();
            if(arr1.Length == arr2.Length)
            {
                Console.WriteLine("Dvata niza sa s ravna duljina");
                for(int i = 0; i < arr1.Length; i++)
                {
                    if(arr1[i] != arr2[i])
                    {
                        Console.WriteLine("Razlika v poziciq {0} -> {1} - {2}", i + 1, arr1[i], arr2[i]);
                    }
                }
            }
            else
            {
                Console.WriteLine("Dvata niza ne sa s ravna duljina");
                if(arr1.Length> arr2.Length)
                {
                    Console.WriteLine("Purviq niz e po-dulig ot vtoriq");
                    for (int i = 0; i < arr2.Length; i++)
                    {
                        if (arr1[i] != arr2[i])
                        {
                            Console.WriteLine("Razlika v poziciq {0} -> {1} - {2}", i + 1, arr1[i], arr2[i]);
                        }
                    }
                }
                else if(arr1.Length < arr2.Length)
                {
                    Console.WriteLine("Vtoriq niz e po-dulug ot purviq");
                    for (int i = 0; i < arr1.Length; i++)
                    {
                        if (arr1[i] != arr2[i])
                        {
                            Console.WriteLine("Razlika v poziciq {0} -> {1} - {2}", i + 1, arr1[i], arr2[i]);
                        }
                    }
                }
            }
        }
    }
}
