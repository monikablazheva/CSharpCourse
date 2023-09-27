using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nizove_GlavniMalkiBukvi_Monika_9e
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete purviq simvolen niz:");
            string str1 = Console.ReadLine();
            Console.WriteLine("Vuvedete vtoriq simvolen niz:");
            string str2 = Console.ReadLine();
            string str1Upper = str1.ToUpper();
            string str1Lower = str1.ToLower();
            string str2Upper = str2.ToUpper();
            string str2Lower = str2.ToLower();
            Console.WriteLine("-> {0}, {1}", str1Lower, str1Upper);
            Console.WriteLine("-> {0}, {1}", str2Lower, str2Upper);
        }
    }
}
