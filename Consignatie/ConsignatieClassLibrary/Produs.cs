using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignatieClassLibrary
{
    public class Produs
    {
        public string Titlu { get; set; }
        public string Descriere { get; set; }
        public decimal Pret { get; set; }
        public bool Vanzare { get; set; }
        public bool Plata { get; set; }
        public Furnizor Proprietar { get; set; }

        public string Display
        {
            get
            {
                return string.Format("{0} - {1} Lei", Titlu, Pret);
            }
        }
    }
}
