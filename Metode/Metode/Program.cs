using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metode;

namespace Metode
{
    class Program
    {
        static void Main(string[] args)
        {
            Metode.Clasa exMeth = new Clasa();
            exMeth.whoAmI("Gigi");
            Console.WriteLine(exMeth.addMe(3, 8));
            Console.WriteLine(exMeth.addMe(3, 8, 4));
            Console.ReadLine();
        }
    }
}
