using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main (string[] args)
        {
            DynamicArray<int> arr = new DynamicArray<int>(3);
            arr.Add(1);
            arr.Add(2);
            arr.Add(3);
            arr.Add(4);
            arr.Insert(5, 5);
        }
    }
}
