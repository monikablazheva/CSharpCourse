using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace УАСД_ПТ1_Моника_Блажева_10е
{
    class DynamicQueue<T>
    {
        private class Node<T>
        {
            private T element;
            private Node<T> next;
            public T Element
            {
                get { return element; }
                set { this.element = value; }
            }

            public Node<T> Next
            {
                get { return next; }
                set { this.next = value; }
            }

            public Node(T value, Node<T> nextNode)
            {
                this.element = element;
                next = null;
            }
        }

        private Node<T> firstNode;
        private Node<T> rearNode;
        private int count;

        public DynamicQueue()
        {
            firstNode = null;
            rearNode = null;
            count = 0;
        }
        public void Enqueue(T element)
        {
            if (firstNode == null)
            {
                firstNode = new Node<T>(element, null);
                rearNode = firstNode;
            }
            else
            {
                Node<T> node = new Node<T>(element, null);
                rearNode.Next = node;
                rearNode = node;
            }
            count++;
        }
        public T Dequeue()
        {
            Node<T> prevNode = null;
            prevNode = firstNode;
            firstNode = firstNode.Next;
            count--;
            return prevNode.Element;
        }
        public T Peek
        {
            get
            {
                return firstNode.Element;
            }
            set
            {
                firstNode.Element = value;
            }
        }
    }
}
