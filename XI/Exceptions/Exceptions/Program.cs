using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string age = Console.ReadLine();
            try
            {
                Int32.Parse(age);
            }
            catch(FormatException)
            {
                Console.WriteLine("The age must be integer");
            }
            Person person = new Person(firstName, lastName, Int32.Parse(age));
            person.Print();
        }
    }
}
