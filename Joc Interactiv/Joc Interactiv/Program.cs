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

            while (true)
            {
                Random random = new Random();

                int numarCorect = random.Next(1, 10);

                int aleator = 0;

                Console.WriteLine("Ghiceste numarul intre 1 si 10");

                while (aleator != numarCorect)
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out aleator))
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;

                        Console.WriteLine("Te rog tasteaza un numar !");

                        Console.ResetColor();

                        continue;
                    }

                    aleator = Int32.Parse(input);

                    if (aleator != numarCorect)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Numar gresit, incearca din nou !");

                        Console.ResetColor();
                    }
                }

                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("Ai ghicit numarul corect !");

                Console.ResetColor();

                Console.WriteLine("Joaca din nou? [D sau N]");

                string raspuns = Console.ReadLine().ToUpper();

                if(raspuns == "D")
                {
                    continue;
                }
                else if(raspuns == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            
                Console.Read();


            }
        }
    }
}
