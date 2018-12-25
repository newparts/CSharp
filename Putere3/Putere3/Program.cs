using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Putere3
{
    class Putere3
    {
        public int this[int index]
        {
            get
            {
                if (index >= 0)
                    return (int)Math.Pow(3, index);
                else
                    return -1;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Putere3 p = new Putere3();
            for (int i = 0; i < 20; i++)
                Console.WriteLine("3^{0}={1}", i, p[i]);
            Console.Read();
        }
    }
}
