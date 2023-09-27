using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubjectTextbook
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolSubject history = new SchoolSubject();
            history.Subject = Console.ReadLine();
            history.Authors = Console.ReadLine();
            history.YearOfPublishing = int.Parse(Console.ReadLine());
            history.Grade = short.Parse(Console.ReadLine());
            Console.WriteLine(history.SchoolbookAge());
            history.ShowInfo();
        }
    }
}
