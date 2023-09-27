using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha1
{
    class Program
    {
        static void Main(string[] args)
        {           
            DynamicList a = new DynamicList();
            while(true)
            {
                string str = Console.ReadLine();
                if(str == "")
                {
                    break;
                }
                else
                {
                    a.Add(int.Parse(str));
                }
            }           
            DynamicList b = new DynamicList();           
            for (int i = 0; i < a.Count; i++)
            {
                if (Convert.ToInt32(a[i]) >= 0)
                {
                    b.Add(a[i]);
                }               
            }
            for (int i=0;i<b.Count;i++)
            {
                Console.WriteLine(b[i]);
            }
        }
    }
}
