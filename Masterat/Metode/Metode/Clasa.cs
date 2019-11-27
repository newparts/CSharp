using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metode
{
    class Clasa
    {
        public void whoAmI(string name)
        {
            Console.WriteLine("Hello " + name + ", how are you doing?");
        }

        public int addMe(int a, int b)
        {
            int totalValue;
            totalValue = (a + b);
            return totalValue;
        }

        public int addMe(int a, int b, int c)
        {
            int totalValue;
            totalValue = (a + b + c);
            return totalValue;
        }
    }
}
