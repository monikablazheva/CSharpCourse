using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[,]
            {
                { 1, 4 },
                { 9, 2 },
                { 2, 7 },
                { 5, 1 }
            };
            //Sort.SortMatrix(matrix);
            QuickSort.SortMatrix(matrix);
        }
    }
}
