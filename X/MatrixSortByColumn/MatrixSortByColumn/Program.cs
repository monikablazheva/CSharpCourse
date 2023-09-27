using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixSortByColumn
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
            Console.WriteLine("Input the index of the column which will be sorted:");
            int index = int.Parse(Console.ReadLine());
            if(index >= matrix.GetLength(1) || index < 0)
            {
                throw new IndexOutOfRangeException("Invalid index");
            }
            else
            {
                Sorting.SortTheMatrixByAColumn(matrix, index);
            }
        }
    }
}
