using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixSort
{
    class Sort
    {
        public static void SortMatrix(int[,] matrix)
        {
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);
            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    for(int k =0; k < row; k++)
                    {
                        for (int l = 0; l < col; l++)
                        {
                            if (matrix[i, j] < matrix[k, l])
                            {
                                int swap = matrix[i, j];
                                matrix[i, j] = matrix[k, l];
                                matrix[k, l] = swap;
                            }
                        }
                    }
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
