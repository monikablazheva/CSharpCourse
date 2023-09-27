using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MnogomerniMasivi_zad2_Monika_9e
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            Console.WriteLine("Vuvedete broq na redovete:");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Vuvedete broq na colonite:");
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];
            Console.WriteLine("Vuvedete elementite:");
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }
            for (int row = 0; row < rows; row++)
            {
                sum = 0;
                for (int col = 0; col < cols; col++)
                {
                    sum += matrix[row, col];
                    Console.Write("{0, 10}", matrix[row, col]);
                }
                Console.Write("{0, 10}", sum / cols);
                Console.WriteLine();
            }
        }
    }
}
