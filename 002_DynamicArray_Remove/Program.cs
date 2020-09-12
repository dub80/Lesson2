using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_DynamicArray_Remove
{
    class Program
    {
        static void Main (string[] args)
        {
            DynamicArray<int> arr = new DynamicArray<int>(10);
            for (int i = 0; i < 10; i++) arr.Add(i);

            arr.RemoveAt(2);
            arr.RemoveAt(0);
            arr.Remove(5);
        }
    }
}
