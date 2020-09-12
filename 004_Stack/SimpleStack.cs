using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Stack
{
    class SimpleStack<T>
    {
        private class Node
        {
            T data;
            Node next;
            public Node (T data, Node next)
            {
                this.data = data;
                this.next = next;
            }
        }

        private Node top;
        private int count;

        public SimpleStack ()
        {
            top = null;
            count = 0;
        }

        public void Push(T item)
        {
            top = new Node(item, top);

            count++;
        }

    }
}
