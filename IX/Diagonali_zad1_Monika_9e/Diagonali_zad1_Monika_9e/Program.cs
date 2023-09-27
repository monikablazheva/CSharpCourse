
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagonali_zad1_Monika_9e
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, sum, pr, primesCount, evensCount;
            double m;
            bool prime;
            pr = 1; sum = 0; primesCount = 0; evensCount = 0;
            Console.WriteLine("Vuvedete broq na redovete/kolonite: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            Console.WriteLine("Vuvedete elementite na 2d masiva: ");
            for(i = 0; i < n; i++)
            {
                for(j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (i = 0; i < n; i++)
            {
                pr *= matrix[i, i];
            }
            for (i = 0; i < n; i++)
            {
                for(j = 0; j < n; j++)
                {
                    if(i > j)
                    {
                        prime = true;
                        for (int l = 2; l < matrix[i, j] / 2; l++)
                        {
                            if (matrix[i, j] % l == 0)
                            {
                                prime = false;
                                break;
                            }
                        }
                        if (prime)
                        {
                            sum += matrix[i, j];
                        }
                    }
                }
            }
            for (i = 0; i < n-1; i++)
            {
                for (j = i+1; j < n; j++)
                {
                    if(matrix[i,j] % 2 == 0)
                    {
                        evensCount++;
                    }
                }
            }
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if ((i + j) == (n - 1))
                    {
                        prime = true;
                        m = matrix[i, j] / 2;
                        for (int l = 2; l < m; l++)
                        {
                            if (matrix[i, j] % l == 0)
                            {
                                prime = false;
                                break;
                            }
                        }
                        if (prime)
                        {
                            primesCount++;
                        }
                    }
                }
            }
            Console.WriteLine("Elementite na 2d masiva: ");
            for(i = 0; i < n; i++)
            {
                for(j = 0; j < n; j++)
                {
                    Console.Write("{0, 5}", matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Proizvedenieto na elementite ot glavniq diagonal: {0}", pr);
            Console.WriteLine("Sumata na prostite chisla pod glavniq diagonal: {0}", sum);
            Console.WriteLine("Broq na chetnite chisla nad glavniq diagonal: {0}", evensCount);
            Console.WriteLine("Broq na prostite chisla ot vtoriq diagonal: {0}", primesCount);
        }
    }
}
