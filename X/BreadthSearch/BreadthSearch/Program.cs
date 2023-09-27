using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreadthSearch
{
    class Program
    {
        static List<int> BreadthSearch(int[] gr, List<int>[] edg, int index)
        {
            List<int> searched = new List<int>();

            searched.Add(gr[index]);

            int i = 0;

            for (int count = 1; count < 5; count++)
            {
                foreach (var item in edg[i])
                {
                    if (!searched.Contains(item))
                    {
                        searched.Add(item);
                    }
                }


                i = Array.IndexOf(gr, searched[count-1]);
            }


            return searched;
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            
            int[] graph = { 1, 2, 3, 4, 5 };
            int n = graph.Length;

            int index = Array.IndexOf(graph, a);

            List<int>[] edges = new List<int>[n];

            for (int i = 0; i < n; i++)
            {
                edges[i] = new List<int>();
            }

            edges[0].Add(2);
            edges[1].Add(1);
            edges[1].Add(4);
            edges[1].Add(5);
            edges[2].Add(4);
            edges[2].Add(5);
            edges[3].Add(2);
            edges[3].Add(3);
            edges[3].Add(5);
            edges[4].Add(2);
            edges[4].Add(3);
            edges[4].Add(4);

            List<int> searched = BreadthSearch(graph, edges,index);
            foreach (var item in searched)
            {
                Console.Write(item + " ");
            }
        }
    }
}
