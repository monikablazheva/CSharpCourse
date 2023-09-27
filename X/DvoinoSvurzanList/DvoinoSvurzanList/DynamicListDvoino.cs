using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvoinoSvurzanList
{
    class DynamicListDvoino
    {
        class Node
        {
            private object element;
            private Node next;
            private Node prev;
            private int count;

            public object Element
            {
                get { return element; } 
                set { element = value; }
            }
            public Node Next
            {
                get { return next; }
                set { next = value; }
            }
            public Node Prev
            {
                get { return next; }
                set { next = value; }
            }
        }
    }
}
