using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class PriorityQueue<int>
    {
        private List<int> data;
        public PriorityQueue()
        {
            this.data = new List<int>();
        }
        public void Enqueue(int item)
        {
            data.Add(item);
            int ci = data.Count - 1;
            while (ci > 0)
            {
                int pi = (ci - 1) / 2;
                if (data[ci].CompareTo(data[pi]) >= 0)
                {
                    break;
                }
                int tmp = data[ci];
                data[ci] = data[pi];
                data[pi] = tmp;
                ci = pi;
            }
        }
        public int Dequeue()
        {
            if (data.Count == 0)
            {
                throw new Exception
            }
        }
    }
}