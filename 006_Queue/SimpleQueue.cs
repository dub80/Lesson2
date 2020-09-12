using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Queue
{
    class SimpleQueue<T>
    {
        private class Node
        {
            public T data { get; set; }
            public Node next { get; set; }

            public Node (T data, Node next)
            {
                this.data = data;
                this.next = next;
            }
        }

        private Node head;
        private Node tail;
        private int count;


        public SimpleQueue ()
        {
            head = tail = null;
            count = 0;
        }
        public void Enqueue(T item)
        {
            if (tail == null)
            {
                head = tail = new Node(item, null);
            }
            else
            {
                tail.next = new Node(item, null);
                tail = tail.next;
            }
            count++;
        }

    }
}
