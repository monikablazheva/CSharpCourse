using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversedList
{
    class ReversedStaticList<T>
    {
        private T[] arr;
        private int count;

        public int Count
        {
            get
            {
                return count;
            }
        }

        private static readonly int capacity = 2;

        public ReversedStaticList()
        {
            this.arr = new T[capacity]; //T[] arr = newT[capacity];
            this.count = 0;
        }

        public void Add(T element)
        {
            if(count + 1 == arr.Length)
            {
                T[] extendedArr = new T[arr.Length * 2];
                Array.Copy(arr, extendedArr, count);
                arr = extendedArr;
            }
            this.arr[count] = element;
            count++;
        }
        public int Capacity()
        {
            return arr.Length;
        }
        public T this[int index]
        {
            get
            {
                if (index >= count || index < 0)
                {
                    throw new IndexOutOfRangeException("Invalid Index");
                }
                return arr[count - 1 - index];
            }
        }
        public void RemoveAt(int index)
        {
            if (index >= count || index < 0)
            {
                throw new IndexOutOfRangeException("Invalid Index");
            }
            int newIndex = count - index - 1;
            Array.Copy(arr, newIndex + 1, arr, newIndex, count - newIndex - 1);
            arr[count - 1] = default(T);
        }
    }
}
