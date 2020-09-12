using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_Set_Remove
{
    class Program
    {
        static void Main (string[] args)
        {
            SimpleSet<int> instance = new SimpleSet<int>();

            instance.Add(1);
            instance.Add(2);
            instance.Add(3);
            instance.Add(4);
            instance.Add(5);

            instance.Remove(5);

            foreach (var item in instance)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
