using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_ООП_УП_ПТ2_Радослав_Димитров_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Lion luvche = new Lion("Luvcho", "Zeburcho", "U gurata", 4);
            string a = luvche.ExplainMyself();
            Console.WriteLine(a);
            luvche.Move();
            luvche.Move();
            //luvche.Move();
            //luvche.Sleep(2);
            a = luvche.ExplainMyself();
            Console.WriteLine(a);
        }
    }
}
