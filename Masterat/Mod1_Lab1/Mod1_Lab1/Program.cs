using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "";
            string lastName = "";
            int age = 0;
            string street = "";
            string city = "";
            string country = "";
            DateTime birthDate;

            firstName = "Ion";
            lastName = "Ionescu";
            age = 20;
            street = "Bulevardul 1 Decembrie 1918";
            city = "Alba Iulia";
            country = "Romania";
            birthDate = new DateTime(1990, 6, 28);

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

            Console.WriteLine("{0} ani", age);

            Console.WriteLine(street + ", " + city + ", " + country);

            Console.WriteLine($"Nascut in {birthDate}");

            Console.ReadLine();
        }
    }
}
