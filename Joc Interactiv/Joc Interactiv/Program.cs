using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joc_Interactiv
{
    class Program
    {
        static void Main(string[] args)
        {
            string appNume = "Ghiceste Numarul Corect";
            string appVersiune = "1.0.0";
            string appAutor = "Newparts";

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Aplicatia: {0} | Versiunea: {1} | Realizata de {2}", appNume, appVersiune, appAutor);         

            Console.ResetColor();

            Console.WriteLine("Care este numele tau?");

            string inputNume = Console.ReadLine();

            Console.WriteLine("Salut {0}, hai sa ne jucam !", inputNume);

            Console.Read();
        }
    }
}
