using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignatieClassLibrary
{
    public class Furnizor
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public double Comision { get; set; }

        public decimal Plati { get; set; }

        public string Display
        {
            get
            {
                return string.Format("{0} {1} - {2} Lei", Nume, Prenume, Plati);
            }
        }

        public Furnizor()
        {
            Comision = 0.2;
        }
    }
}
