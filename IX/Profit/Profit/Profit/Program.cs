using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete broi rabotni dni v meseca:");
            int dniMesec = int.Parse(Console.ReadLine());
            Console.WriteLine("Vuvedete izkaranite pari na den:");
            double pariNaDen = double.Parse(Console.ReadLine().Replace(',', '.'));
            Console.WriteLine("Vuvedete kurs na dolara:");
            double kursDolar = double.Parse(Console.ReadLine().Replace(',', '.'));
            double zaplataMesec = dniMesec * pariNaDen;
            double dohodGodina = zaplataMesec * 12 + zaplataMesec * 2.5;
            double danak = dohodGodina * 25/100;
            double chisto = (dohodGodina - danak) * kursDolar;
            double naDen = chisto / 365;
            Console.WriteLine(naDen);
            Console.ReadLine();
        }
    }
}
