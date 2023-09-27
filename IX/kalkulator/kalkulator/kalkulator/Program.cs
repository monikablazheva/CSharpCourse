using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            string operatr = Console.ReadLine();
            var chst1 = "Cannot divide " + n1 + " by zero";
            if (operatr == "+")
            {
                double sbor = n1 + n2;
                if (sbor % 2 == 0)
                {
                    var sum1 = n1 + " + " + n2 + " = " + sbor + " -" + " even";
                    Console.WriteLine(sum1);
                }
                else if (sbor % 2 == 1)
                {
                    var sum2 = n1 + " + " + n2 + " = " + sbor + " -" + " odd";
                    Console.WriteLine(sum2);
                }
                    
            }
            else if (operatr == "-")
            {
                double razlika = n1 - n2;
                if (razlika % 2 == 0)
                {
                    var raz1 = n1 + " - " + n2 + " = " + razlika + " -" + " even";
                    Console.WriteLine(raz1);
                }
                else if (razlika % 2 == 1)
                {
                    var raz2 = n1 + " - " + n2 + " = " + razlika + " -" + " odd";
                    Console.WriteLine(raz2);
                }
            }
            else if (operatr == "*")
            {
                double proizvedenie = n1 * n2;
                if (proizvedenie % 2 == 0)
                {
                    var proiz1 = n1 + " * " + n2 + " = " + proizvedenie + " -" + " even";
                    Console.WriteLine(proiz1);
                }
                else if (proizvedenie % 2 == 1)
                {
                    var proiz2 = n1 + " * " + n2 + " = " + proizvedenie + " -" + " odd";
                    Console.WriteLine(proiz2);
                }
            }
            else if (operatr == "/")
            { 
                double chastno = n1 / n2;
                if (n2 == 0)
                {
                    Console.WriteLine(chst1);
                }
                else
                    Console.WriteLine("{0} / {1} = {2:f2}", n1, n2, chastno);
            }
            else if (operatr == "%")
            {
                double ostatuk = n1 % n2;
                if (n2 == 0)
                {
                    Console.WriteLine(chst1);
                }
                else
                    Console.WriteLine("{0} % {1} = {2}", n1, n2, ostatuk);
            }
        }
    }
}
