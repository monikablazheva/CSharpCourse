using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static long Permutation(int n)
        {
            if (n == 0) return 1;
            if (n == 1) return 1;
            return n * Permutation(n - 1);
        }
        static int Fibonacci(int n)
        {
            if (n == 1 || n == 2) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        static long Pow(int n, int x)
        {
            if (x == 0) return 1;
            if (x == 1) return n;
            return n * Pow(n, x - 1);
        }
        static double xZ(double x, int Z)
        {
            if (Z < 0) { x = 1 / x; Z = -Z; }
            if (Z == 0) return 1;
            if (Z == 1) return x;
            return x * xZ(x, Z - 1);
        }
        static int ReverseNumber(int n)
        {
            if (n < 10) return n;
            int a = n % 10;
            return int.Parse(a.ToString() + ReverseNumber(n / 10));
        }
        static int SummariseNumber(int n)
        {
            if (n < 10) return n;
            return n % 10 + SummariseNumber(n / 10);
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            //Console.WriteLine(Permutation(n));
            //Console.WriteLine(Fibonacci(n));
            //Console.WriteLine(Pow(n, x));
            Console.WriteLine(xZ(n, x));
            //Console.WriteLine(ReverseNumber(n));
            //Console.WriteLine(SummariseNumber(n));
        }
    }
}
