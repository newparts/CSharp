using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int counter=0; counter<10;counter++)
            {
                Console.WriteLine($"Counter este la pozitia: {counter}");
            }
            Console.ReadLine();

            int outer;
            int inner;

            for (outer = 2; outer < 100; outer++)
            {
                for (inner = 2; inner <= (outer / inner); inner++)
                    if ((outer % inner) == 0) break;
                if (inner > (outer / inner))
                    Console.WriteLine("{0} este numar prim", outer);
            }
            Console.ReadLine();
        }
    }
}
