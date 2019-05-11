using System;
using System.Collections.Generic;
using System.Text;

namespace CSLibrary
{
    public class EchipaModel
    {
        /// <summary>
        /// Reprezinta Membrii unei echipe participante la competitie
        /// </summary>
        public List<MembruModel> MembriiEchipei { get; set; } = new List<MembruModel>();
        /// <summary>
        /// Reprezinta numele unei echipe inscrisa in competitie
        /// </summary>
        public string NumeleEchipei { get; set; }
    }
}
