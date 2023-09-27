using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family
{
    class Program
    {
        static void Main(string[] args)
        {
            FamilyList list = new FamilyList();
            list.AddsPeopleToList();
            list.Print();
        }
    }
}
