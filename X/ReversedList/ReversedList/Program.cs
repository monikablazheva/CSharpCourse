using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversedList
{
    class Program
    {
        static void Main(string[] args)
        {
            ReversedStaticList<int> rList = new ReversedStaticList<int>();
            rList.Add(1);
            rList.Add(2);
            rList.Add(3);
            rList.Add(4);
            rList.Add(5);
            for(int i = 0; i < rList.Count; i++)
            {
                Console.Write(rList[i]);
            }
        }
    }
}
