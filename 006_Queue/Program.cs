using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Queue
{
    class Program
    {
        static void Main (string[] args)
        {
            SimpleQueue<String> queue = new SimpleQueue<string>();

            queue.Enqueue("Hello");
            queue.Enqueue("world");


        }
    }
}
