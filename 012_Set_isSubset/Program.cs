using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_Set_isSubset
{
    class Program
    {
        static void Main (string[] args)
        {
            bool rez;

            int[] array = { 1, 2, 3, 4, 5, 6 };

            var set1 = new SimpleSet<int>();
            var set2 = new SimpleSet<int>(array);

            set1.Add(1);
            set1.Add(2);
            set1.Add(3);
            set1.Add(4);
            //set1.Add(7); //Расскоментировать!

            rez = set1.IsSubset(set2);

            Console.WriteLine(rez);

            Console.ReadKey();
        }
    }
}
