using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixsColumnSort
{
    class Program
    {
        private static void SortTheMatrixByAColumn(int[,] matrix, int n)
        {
            int columnLenght = matrix.GetLength(0);
            /*for (int i = 0; i < columnLenght - 1; i++)
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
            }*/
            for (int i = 0; i < columnLenght - 1; i++)
            {
                for (int j = 0; j < columnLenght - i - 1; j++)
                {
                    if (matrix[j,n] > matrix[j + 1,n])
                    {
                        int swap = matrix[j,n];
                        matrix[j,n] = matrix[j + 1,n];
                        matrix[j + 1,n] = swap;
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
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int r = arr[0], c = arr[1], s = arr[2];
            /*int[,] matrix = new int[r, c];

            for(int i = 0; i < r; i++)
            {
                int[] line = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for(int row = 0; row < r; row++)
                {
                    for(int col = 0; col < c; col++)
                    {
                        matrix[row, col] = line[row];
                    }
                }
                
            }*/
            int[,] matrix = new int[,]
            {
                { 1, 2, 3, 4 },
                { 3, 1, 2, 4 },
                { 2, 3, 1, 2 }
            };
            SortTheMatrixByAColumn(matrix, s);
        }
    }
}
