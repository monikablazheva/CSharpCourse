using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixSortByColumn
{
    class Sorting
    {
        public static void SortTheMatrixByAColumn(int[,] matrix, int n)
        {
            int columnLenght = matrix.GetLength(0);
            for (int i = 0; i < columnLenght - 1; i++)
            {
                for (int j = i + 1; j < columnLenght; j++)
                {
                    if (matrix[i, n] > matrix[j, n])
                    {
                        int swap = matrix[i, n];
                        matrix[i, n] = matrix[j, n];
                        matrix[j, n] = swap;
                    }
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
