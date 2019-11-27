using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Div
{
    class Divizor
    {
        public bool EsteDivizor(int a, int b)
        {
            if ((b % a) == 0)
                return true;
            else
                return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int d, m;
            Console.WriteLine("Programul testeaza daca d este divizor al lui m");
            Console.Write("Introduceti un numar intreg d = ");
            d = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nIntroduceti un numar intreg m = ");
            m = int.Parse(Console.ReadLine());
            Divizor x = new Divizor();
            x.EsteDivizor(d, m);
            if (x.EsteDivizor(d, m))
                Console.WriteLine("{0} este divizor al lui {1}", d, m);
            else
                Console.WriteLine("{0} nu este divizor al lui {1}", d, m);
            Console.Read();
        }
    }
}
