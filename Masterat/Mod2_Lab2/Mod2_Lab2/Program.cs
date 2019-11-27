using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cafea: 1 = Mica 2 = Medie 3 = Mare");
            Console.Write("Alegeti o cafea: ");
            string str = Console.ReadLine();
            int cost = 0;

            switch (str)
            {
                case "1":
                case "Mica":
                    cost += 25;
                    break;

                case "2":
                case "Medie":
                    cost += 50;
                    break;

                case "3":
                case "Mare":
                    cost += 75;
                    break;

                default:
                    Console.WriteLine("Selectie invalida. Selectati 1, 2 sau 3 !");
                    break;
            }
            if (cost !=0)
            {
                Console.WriteLine("Va rugam introduceti {0} lei", cost);
            }
            Console.WriteLine("Multumim!");
            Console.ReadLine();
        }
    }
}
