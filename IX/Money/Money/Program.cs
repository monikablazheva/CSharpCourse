using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete broi biktkoini:");
            int broiBitkoini = int.Parse(Console.ReadLine());
            Console.WriteLine("Vuvedete broi kitaiski uani:");
            double uana = double.Parse(Console.ReadLine());
            Console.WriteLine("Vuvedete komisionnata:");
            double comisionna = double.Parse(Console.ReadLine());
            double dolar = 1.76;
            double kumDolari = uana * 0.15;
            double leva = broiBitkoini * 1168 + kumDolari * 1.76;
            double evro = leva / 1.95;
            Console.WriteLine("Obshto evra: " + (evro - evro * comisionna/100));
         }
    }
}
