using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true) //Цикълът е безкраен. Ще се върти докато не срещне break;.
            {
                Console.WriteLine("Enter even number:");
                string input = Console.ReadLine(); 
                try //Пробваме дали това, което искаме да направим е възможно.
                {
                    int number = Int32.Parse(input);
                    if (number % 2 == 0)
                    {
                        Console.WriteLine("Even number entered: {0}", number);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The number is not even.");
                    }
                }
                catch //Ако не е възможно, извежда това:
                {
                    Console.WriteLine("Invalid number!");
                }
                Console.WriteLine(); //Това е просто за формалност.
            }
        }
    }
}
