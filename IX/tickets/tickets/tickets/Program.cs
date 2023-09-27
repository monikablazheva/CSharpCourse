using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tickets
{
    class Program
    {
        public static double bujet = double.Parse(Console.ReadLine());
        public static string kategoriq = Console.ReadLine();
        public static double hora = double.Parse(Console.ReadLine());
        public static double transport;
        public static double bileti;
        public static double ostatuk;
        public static double obshto;
        public static double need;

        static void Main(string[] args)
        {            
            if (hora >= 1 && hora <= 4)
            {
                CheckTransport(75);
            }
            else if (hora >= 5 && hora <= 9)
            {
                CheckTransport(60);
            }
            else if (hora >= 10 && hora <= 24)
            {
                CheckTransport(50);
            }
            else if (hora >= 25 && hora <= 49)
            {
                CheckTransport(40);
            }
            else if (hora >= 50)
            {
                CheckTransport(25);
            }
        }

        /// <summary>
        /// Check category and set transport value.
        /// </summary>
        /// <param name="percent"></param>
        public static void CheckTransport(int percent)
        {
            transport = bujet * percent / 100;
            if (kategoriq == "VIP")
            {
                bileti = hora * 499.99;
                ostatuk = bujet - transport - bileti;
                obshto = bileti + transport;
                need = obshto - bujet;
                if (ostatuk >= 0)
                {
                    Console.WriteLine("Yes, You have {0:f2} leva left.", ostatuk);
                }
                else
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", need);

            }
            else if (kategoriq == "Normal")
            {
                bileti = hora * 249.99;
                obshto = bileti + transport;
                ostatuk = bujet - obshto;
                need = obshto - bujet;
                if (ostatuk >= 0)
                {
                    Console.WriteLine("Yes, You have {0:f2} leva left.", ostatuk);
                }
                else
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", need);
            }
        }
    }
}
