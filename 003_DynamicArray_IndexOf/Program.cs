using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_DynamicArray_IndexOf
{
    class Program
    {
        static void Main (string[] args)
        {
            DynamicArray<int> arr = new DynamicArray<int>(10);
            for (int i = 1; i < 11; i++) arr.Add(i);

            Console.WriteLine("Contains '5'   : " + arr.Contains(5));
            Console.WriteLine("Contains '200' : " + arr.Contains(200));
            Console.WriteLine("Index of element '7' : " + arr.IndexOf(7));

            Console.ReadKey();
        }
    }
}
