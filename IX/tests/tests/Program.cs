using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tests
{
    class Program
    {
        static void ShowSuccsessMessages(string operation, string message)
        {
            
            Console.WriteLine("nSuccessfully executed {0}.", operation);
            string str = "Successfully executed " + operation + ".";
            int n = str.Length;
            Console.WriteLine(new string('=', 2 * n));
        }
        
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            

        }
    }
}
