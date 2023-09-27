using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsHW
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicList insertList = new DynamicList();
            while(true)
            {
                string str = Console.ReadLine();
                if(str == "")
                {
                    break;
                }
                else
                {
                    insertList.Add(str);
                }
            }
            DynamicList newList = new DynamicList();
            for(int i = 0; i < insertList.Count; i++)
            {
                if (Convert.ToInt32(insertList[i]) >= 0)
                {
                    newList.Add(insertList[i]);
                }
            }
            for (int i = 0; i < newList.Count; i++)
            {
                Console.Write(newList[i] + " ");
            }
            newList.Clear();
            for (int i = 0; i < insertList.Count; i++)
            {
                int count = 0;
                for (int j = 0; j < insertList.Count; i++)
                {
                    if (insertList[i] == insertList[j])
                    {
                        count++;
                    }
                }
                if (count % 2 == 0)
                {
                    newList.Add(insertList[i]);
                }
            }
            for (int i = 0; i < newList.Count; i++)
            {
                Console.Write(newList[i] + " ");
            }
        }
    }
}
