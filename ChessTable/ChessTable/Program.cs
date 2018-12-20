using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTable
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int col = 0; col < 8; col++)
            {
                for (int row = 0; row < 8; row++)
                {
                    if ((col + row) % 2 == 0)
                    {
                        Console.Write("X");
                    }
                    else if((col + row) % 2 == 1)
                    {
                        Console.Write("O");
                    }
                    else
                    {
                        Console.Write("Neither X nor O");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.Read();
        }
    }
}
