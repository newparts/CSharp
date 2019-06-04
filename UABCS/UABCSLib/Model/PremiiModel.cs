using System;
using System.Collections.Generic;
using System.Text;

namespace UABCSLib.Model
{
    /// <summary>
    /// Reprezinta premiile puse in joc in competitie
    /// </summary>
    public class PremiiModel
    {   /// <summary>
        /// Identificarea unica pentru premiu
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Reprezinta locul ocupat de echipa
        /// </summary>
        public int LoculOcupat { get; set; }
        /// <summary>
        /// Reprezinta ce loc a ocupat echipa
        /// </summary>
        public string LocNume { get; set; }
        /// <summary>
        /// Reprezinta valoarea premiului castigat de echipa
        /// </summary>
        public decimal ValoarePremiu { get; set; }
        /// <summary>
        /// Reprezinta cat procent din suma adunata ca taxa reprezinta premiul castigat de echipa
        /// </summary>
        public double ProcentPremiu { get; set; }

        public PremiiModel()
        {

        }

        public PremiiModel(string loculOcupat, string valoarePremiu, string numeleLocului, string procentPremiu)
        {
            LocNume = numeleLocului;

            int loculOcupatValoare = 0;
            int.TryParse(loculOcupat, out loculOcupatValoare);
            LoculOcupat = loculOcupatValoare;

            decimal valoarePremiuValue = 0;
            decimal.TryParse(valoarePremiu, out valoarePremiuValue);
            ValoarePremiu = valoarePremiuValue;

            double procentPremiuValoare = 0;
            double.TryParse(procentPremiu, out procentPremiuValoare);
            ProcentPremiu = procentPremiuValoare;
        }
    }
}
