using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Employee[] employees = new Employee[count];
            for (int i = 0; i < count; i++)
            {
                employees[i] = new Employee();
                employees[i].ReadData();
            }
        }
    }
}
