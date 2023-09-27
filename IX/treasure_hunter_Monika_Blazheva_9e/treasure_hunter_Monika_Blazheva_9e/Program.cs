using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treasure_hunter_Monika_Blazheva_9e
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, coins = 1;
            int leftSum = 0, rightSum = 0;
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
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
                        leftSum += matrix[i, j];
                    }
                }
                for (j = 0; j < n; j++)
                {
                    if ((i + j) == (n - 1))
                    {
                        rightSum += matrix[i, j];
                    }
                }
            }
            for(i = 0; i < n; i++)
            {
                for(j = 1; j < 3; j++)
                {
                    coins *= matrix[i, j];
                }
            }
            if (leftSum == rightSum)
            {
                Console.WriteLine("YES");
                Console.WriteLine("Броя на монетите е: {0}", coins);
            }
            else Console.WriteLine("NO");
        }
    }
}
