using System;
using System.Collections.Generic;
using System.Text;

namespace CSLibrary
{
    public class PremiiModel
    {
        /// <summary>
        /// Reprezinta locul ocupat de echipa
        /// </summary>
        public int LoculOcupat { get; set; }
        /// <summary>
        /// Reprezinta ce loc a ocupat echipa
        /// </summary>
        public int LocNume { get; set; }
        /// <summary>
        /// Reprezinta valoarea premiului castigat de echipa
        /// </summary>
        public decimal ValoarePremiu { get; set; }
        /// <summary>
        /// Reprezinta cat procent din suma adunata ca taxa reprezinta premiul castigat de echipa
        /// </summary>
        public double ProcentPremiu { get; set; }
    }
}
