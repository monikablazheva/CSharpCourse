using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixSort
{
    class QuickSort
    {
        public static void SortMatrix(int[,] matrix)
        {
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    int maxI = i;
                    int maxJ = j;
                    for (int k = i; k < row; k++)
                    {
                        if(k == i)
                        {
                            for (int l = j; l < col; l++)
                            {
                                if (matrix[maxI, maxJ] > matrix[k, l])
                                {
                                    maxI = k;
                                    maxJ = l;
                                }
                            }
                        }
                        else
                        {
                            for (int l = 0; l < col; l++)
                            {
                                if (matrix[maxI, maxJ] > matrix[k, l])
                                {
                                    maxI = k;
                                    maxJ = l;
                                }
                            }
                        }
                    }
                    int swap = matrix[i, j];
                    matrix[i, j] = matrix[maxI, maxJ];
                    matrix[maxI, maxJ] = swap;
                }
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
