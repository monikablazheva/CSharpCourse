 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            int count = 0;
            int summary = 0;
            int i = 0;
            while(true)
            {
                string str = Console.ReadLine();
                if(str == "")
                {
                    break;
                }
                list.Add(int.Parse(str));
                count++;
                summary += list[i];
                i++;
            }
            Console.WriteLine("The summary of the list is: {0}", summary);
            Console.WriteLine("The mean average of the list is: {0}", summary / count);
        }
    }
}
