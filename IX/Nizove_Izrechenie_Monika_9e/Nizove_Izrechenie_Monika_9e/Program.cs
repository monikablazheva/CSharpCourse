using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nizove_Izrechenie_Monika_9e
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            s = s.Replace(".", "");
            s = s.Replace(",", "");
            string[] array = s.Split(' ', ',', '.');
            s = s.Replace(" ", "");
            Console.WriteLine("broi dumi ->" + array.Length);
            Console.WriteLine("broi simvoli ->" + s.Length);
        }
    }
}
