using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Stack
{
    class Program
    {
        static void Main (string[] args)
        {
            SimpleStack<int> stack = new SimpleStack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(10);

        }
    }
}
