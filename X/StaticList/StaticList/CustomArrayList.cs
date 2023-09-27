using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticList
{
    class CustomArrayList
    {
        private object[] arr;
        private int count;
        public int Count 
        {
            get 
            {
                return count;
            }
        }
        private static readonly int initialCapacity = 4;
        public CustomArrayList()
        {
            arr = new object[initialCapacity];
            count = 0;
        }
        public void Insert(int index, object item)
        {
            if (index > count || index < 0)
            {
                throw new IndexOutOfRangeException("Invalid index: " + index);
            }
            object[] extendedArray = arr;
            if (count + 1 == arr.Length)
            {
                extendedArray = new object[arr.Length * 2];
            }
            Array.Copy(arr, extendedArray, index);
            count++;
            Array.Copy(arr, index, extendedArray, index + 1, count - index - 1);
            extendedArray[index] = item;
            arr = extendedArray;
        }
        public void Add(object item)
        {
            Insert(count, item);
        }
        public int IndexOf(object item)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (item == arr[i])
                {
                    return i;
                }
            }
            return -1; 
        }
        public void Clear()
        {
            arr = new object[initialCapacity];
            count = 0;
        }
        public void Contains(object item)
        {
            int index = IndexOf(item);
            bool found = (index != -1);
            if (found == true)
            {
                Console.WriteLine("Yes, there is {0} in the list.", item);
            }
            else
                Console.WriteLine("No, there isn't {0} in the list.", item);
        }
        public object this[int index]
        {
            get
            {
                if (index >= count || index < 0)
                {
                    throw new ArgumentOutOfRangeException("invalid index " + index);
                }
                return arr[index];
            }
            set
            {
                if (index >= count || index < 0)
                {
                    throw new ArgumentOutOfRangeException("invalid index " + index);
                }
                arr[index] = value;
            }
        }
        public object Remove(object item)
        {
            int index = IndexOf(item);
            if (index == -1)
            {
                throw new IndexOutOfRangeException("invalid index " + index);
            }
            Array.Copy(arr, index + 1, arr, index, count - index - 1);
            arr[count - 1] = null;
            count--;
            return item;
        }
    }

}
