using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MnogomerniMasivi_zad3_Monika_9e
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];
            for(int row = 0; row < rows; row++)
            {
                int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for(int col = 0; col < cols; col++)
                {
                    matrix[row, col] = array[col];
                }
            }
            int[] minArray = new int[cols];
            int min;
            for (int col = 0; col < cols; col++)
            {
                min = Int16.MaxValue;
                for (int row = 0; row < rows; row++)
                {
                    if(matrix[row,col] < min)
                    {
                        min = matrix[row, col];
                    }
                }
                minArray[col] = min;
            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write("{0, 5}", matrix[row, col]);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < cols; i++)
            {
                Console.Write("{0, 5}", minArray[i]);
            }
            Console.WriteLine();
        }
    }
}
