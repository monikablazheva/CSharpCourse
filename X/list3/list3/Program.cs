using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list3
{
    class Program
    {
        static public void ReturnsTheNewList(List<int> list)
        {
            List<int> newList = new List<int>();
            list.Sort();
            int count
            for(int i = 0; i < list.Count; i++)
            {
                
            }
        }
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ', ',').Select(int.Parse).ToList();

        }
    }
}
