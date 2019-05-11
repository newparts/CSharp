using System;
using System.Collections.Generic;
using System.Text;

namespace CSLibrary
{
    /// <summary>
    /// Reprezinta meciurile din competitie
    /// </summary>
    public class MeciuriModel
    {
        /// <summary>
        /// Reprezinta meciurile noi ce urmeaza sa se joace
        /// </summary>
        public List<MeciuriNoiModel> MeciuriNoi { get; set; } = new List<MeciuriNoiModel>();
        /// <summary>
        /// Reprezinta echipa castigatoare a unui meci
        /// </summary>
        public EchipaModel Castigator { get; set; }
        /// <summary>
        /// Reprezinta rundele jucate pana la un moment dat
        /// </summary>
        public int Runde { get; set; }

    }
}
