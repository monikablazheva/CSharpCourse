
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50random
{
    class Program
    {
        private static void Oktopod (int s)
        {
            int s2 = s + 1;
            int s3 = (s * 2) + 1;
            int s4 = s + 2;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> q = new List<int>();
            q.Add(n);
            
            for(int i = 1; i <= 16; i++)
            {
                q.Add(n + 1);
                q.Add((n * 2) + 1);
                q.Add(n + 2);
                n = q[i];
                /*if(i % 3 == 0 )
                {
                    n = n + 1;
                    count+=1;
                }
                else if(i %3 == 1)
                {
                    n = (2 * n) + 1;
                    count += 1;
                }
                else if (i % 3 == 2)
                {
                    n = n + 2;
                    count += 1;
                }*/
            }
            Console.WriteLine();
            foreach(int i in q)
            {
                Console.Write(i + " ");
            }
        }
    }
}
