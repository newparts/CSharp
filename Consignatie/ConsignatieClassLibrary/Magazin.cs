using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignatieClassLibrary
{
    public class Magazin
    {
        public string Nume { get; set; }
        public List<Furnizor> Furnizori { get; set; }
        public List<Produs> Produse { get; set; }

        public Magazin()
        {
            Furnizori = new List<Furnizor>();
            Produse = new List<Produs>();
        }
    }
}
