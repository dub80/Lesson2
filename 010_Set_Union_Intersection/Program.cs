using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Set_Union_Intersection
{
    class Program
    {
        static void Main (string[] args)
        {
            int[] array1 = { 10, 20, 30, 40, 50 };
            int[] array2 = { 1, 2, 3, 4, 5, 50 };
            var set1 = new SimpleSet<int>(array2);
            var set2 = new SimpleSet<int>(array1);
            var set3 = new SimpleSet<int>();

            set3 = set1.Union(set2);

            foreach (var item in set3)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.ReadKey();

            int[] array = { 3, 4, 5, 6 };

            set1 = new SimpleSet<int>();
            set2 = new SimpleSet<int>(array);
            set3 = new SimpleSet<int>();

            set1.Add(1);
            set1.Add(2);
            set1.Add(3);
            set1.Add(4);

            set3 = set1.Intersection(set2);

            foreach (var item in set3)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
