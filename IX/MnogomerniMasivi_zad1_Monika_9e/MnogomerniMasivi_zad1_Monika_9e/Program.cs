using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MnogomerniMasivi_zad1_Monika_9e
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete broq na redovete:");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Vuvedete broq na colonite:");
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];
            Console.WriteLine("Vuvedete elementite:");
            for(int row = 0; row < rows; row++)
            {
                for(int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
