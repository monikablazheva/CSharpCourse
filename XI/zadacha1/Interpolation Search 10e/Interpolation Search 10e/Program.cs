using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpolation_Search_10e
{
    class Program
    {
        static void interpolationSearch(int x, int[] arr)
        {
            // Намираме и поставяме индексите на двата края на масива
            int lo = 0;
            int hi = (arr.Length - 1);
            int index = -1;
            
            while (lo <= hi  &&  x >= arr[lo] &&  x <= arr[hi])
            {   // Случаите, в които имаме само един елемент в масива
                if (lo == hi)
                {
                    if (arr[lo] == x)
                    {  index = lo; }       
                }
         
                int pos = lo + (((hi - lo) / (arr[hi] - arr[lo])) *  (x - arr[lo]));

                // Вариантът, ако сме намерили точната позиция
                if (arr[pos] == x)
                {                  
                    index =  pos;

                    int pos1 = pos;

                    while (pos1+1 <= hi && arr[pos1+1] == x)
                    {
                        Console.WriteLine("Element found " + "at index " + (pos1+1));
                        pos1++;
                    }

                    pos1 = pos;
                    while (pos1 -1 >= lo && arr[pos1 - 1] == x)
                    {
                        Console.WriteLine("Element found " + "at index " + (pos1-1));
                        pos1--;
                    }
                }

                // Ако x е по-голямото, x е в горната част
                if (arr[pos] < x)
                { lo = pos + 1; }

                // Ако x е по-малкото, x е в долната част
                else
                { hi = pos - 1; }
            }

            // Ако елементът е намерен
            if (index != -1)
            {
                Console.WriteLine("Element found " + "at index " + index);
            }
            else
            {
                Console.WriteLine("Element not found.");
            }

        }


        static void Main(string[] args)
        {
            int[] arr = new int[]{10, 12, 13, 16, 18, 18, 18, 20, 21, 22, 23, 24, 33, 35, 42, 47};

            int x = 18; // Елементът, който ще се търси

            interpolationSearch(x, arr);


            

            Console.ReadKey();
        }
    }
}
