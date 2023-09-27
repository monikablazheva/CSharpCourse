using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace min
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());
            int min = int.MaxValue; 
            int[,] array2D = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    array2D[i, j] = int.Parse(Console.ReadLine());
                    if (array2D[i, j] < min)
                    {
                        min = array2D[i, j];
                    }
                }
            }
            Console.WriteLine(min);
        }
    }
}
