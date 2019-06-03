using System;
using System.Collections.Generic;
using System.Text;

namespace CSLibrary.Model
{
    /// <summary>
    /// Reprezinta un meciurile noi introduse
    /// </summary>
    public class MeciuriNoiModel
    {
        /// <summary>
        /// Reprezinta o singura echipa dintr-un meci
        /// </summary>
        public EchipaModel Competitor { get; set; }
        /// <summary>
        /// Reprezinta scorul acestei echipe
        /// </summary>
        public double Rezultat { get; set; }
        /// <summary>
        /// Reprezinta meciul din care a venit ca invingatoare
        /// </summary>
        public MeciuriModel MeciParinte { get; set; }

    }
}
