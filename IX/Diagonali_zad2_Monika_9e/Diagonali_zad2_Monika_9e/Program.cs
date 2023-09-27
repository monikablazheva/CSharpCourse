using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagonali_zad2_Monika_9e
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, mainSum = 0, secondSum = 0, overEvenSum = 0, underNotEvenSum = 0, mainEvensSum = 0, rowsEvensSum = 0, colsNotEvensSum = 0;
            Console.WriteLine("Vuvedete broq na redovete/kolonite: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            Console.WriteLine("Vuvedete elementite na 2d masiva: ");
            for (i = 0; i < n; i++)
            {
                int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (j = 0; j < n; j++)
                {
                    matrix[i, j] = array[j];
                }
            }
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                   if(i == j)
                   {
                       mainSum += matrix[i, j];
                       if(matrix[i,j] % 2 == 0)
                       {
                            mainEvensSum += matrix[i, j];
                       }
                   }
                   if((i + j) == (n - 1))
                   {
                       secondSum += matrix[i, j];   
                   }
                   if(i > j)
                   {
                       underNotEvenSum += matrix[i, j];
                   }
                   if(i < j)
                   {
                       overEvenSum += matrix[i, j]; 
                   }
                   if(i == 0 || i == n - 1)
                   {
                       if(matrix[i,j] % 2 == 0)
                       {
                           rowsEvensSum += matrix[i, j];
                       }
                   }
                   if(j == 0 || j == n - 1)
                   {
                       if(matrix[i,j] % 2 == 1)
                       {
                           colsNotEvensSum += matrix[i, j];
                       }
                   }
                }
            }
            if (mainSum == secondSum && underNotEvenSum % 2 == 1 && overEvenSum % 2 == 0)
            {
                Console.WriteLine("YES");
                int allSums = underNotEvenSum + mainEvensSum + rowsEvensSum + colsNotEvensSum;
                double pechalba = allSums / 4;
                Console.WriteLine("Vashata pechalba e: {0:f2}lv.", pechalba);
            }
            else
                Console.WriteLine("NO");
        }
    }
}
