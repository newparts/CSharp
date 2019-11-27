using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar intreg si apasati tasta Enter");
            int input = Int32.Parse(Console.ReadLine());

            if (input %2 ==0)
            {
                Console.WriteLine("Numarul introdus este par");
            }
            else
            {
                Console.WriteLine("Numarul introdus este impar");
            }
            Console.ReadLine();
        }
    }
}
