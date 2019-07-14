using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESLibrary.Model
{
    public class ModelFactura
    {
        public int NumarFactura { get; set; }
        public string SerieFacutura { get; set; }
        public string CantitateProdus { get; set; }
        public string DenumiresProdus { get; set; }
        public decimal PretUnitar { get; set; }
        public decimal TVA { get; set; }
        public decimal ValoareNeta { get; set; }
        public decimal ValoareTotala { get; set; }
        public DateTime DataEmiterii { get; set; }
        public DateTime DataScadenta { get; set; }
        public string NumeFurnizor { get; set; }
        public string UnitateMasura { get; set; }
    }
}
