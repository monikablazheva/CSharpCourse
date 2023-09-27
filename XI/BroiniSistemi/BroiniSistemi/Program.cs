using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BroiniSistemi
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("First Numeral System:");
                string firstNumSystem = Console.ReadLine();
                if (firstNumSystem.ToLower() == "exit")
                {
                    break;
                }
                Console.WriteLine("Second Numeral System:");
                string secondNumSystem = Console.ReadLine();
                string number = Console.ReadLine();
                
                if (firstNumSystem.ToLower() == "hexademical" && secondNumSystem.ToLower() == "decimal")
                {
                    Console.WriteLine(Convert.ToInt32(number, 16));
                }
                else if (firstNumSystem.ToLower() == "hexademical" && secondNumSystem.ToLower() == "binary")
                {
                    Console.WriteLine(Convert.ToString(Convert.ToInt32(number, 16), 2));
                }
                else if (firstNumSystem.ToLower() == "hexademical" && secondNumSystem.ToLower() == "octal")
                {
                    Console.WriteLine(Convert.ToString(Convert.ToInt32(number, 16), 8));
                }

                else if (firstNumSystem.ToLower() == "decimal" && secondNumSystem.ToLower() == "hexademical")
                {
                    Console.WriteLine(Convert.ToString(Int32.Parse(number), 16).ToUpper());
                }
                else if (firstNumSystem.ToLower() == "decimal" && secondNumSystem.ToLower() == "binary")
                {
                    Console.WriteLine(Convert.ToString(Int32.Parse(number), 2).ToUpper());
                }
                else if (firstNumSystem.ToLower() == "decimal" && secondNumSystem.ToLower() == "octal")
                {
                    Console.WriteLine(Convert.ToString(Int32.Parse(number), 8).ToUpper());
                }

                else if (firstNumSystem.ToLower() == "binary" && secondNumSystem.ToLower() == "decimal")
                {
                    Console.WriteLine(Convert.ToString(Convert.ToInt32(number, 2), 10));
                }
                else if (firstNumSystem.ToLower() == "binary" && secondNumSystem.ToLower() == "hexademical")
                {
                    Console.WriteLine(Convert.ToString(Convert.ToInt32(number, 2), 16).ToUpper());
                }
                else if (firstNumSystem.ToLower() == "binary" && secondNumSystem.ToLower() == "octal")
                {
                    Console.WriteLine(Convert.ToString(Convert.ToInt32(number, 2), 8).ToUpper());
                }
            }
        }
    }
}
