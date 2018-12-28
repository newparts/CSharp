using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trepte
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            long[] f;
            Console.Write("Dati numarul de trepte: ");
            n = Convert.ToInt32(Console.ReadLine());
            f = new long[n + 1];
            f[1] = f[2] = 1;
            for (i = 3; i <= n; i++) f[i] = f[i - 1] + f[i - 2];
            Console.WriteLine("Numarul de posibilitati este: {0}", f[n].ToString());
            Console.ReadLine();
        }
    }
}
