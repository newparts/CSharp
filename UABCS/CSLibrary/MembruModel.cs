using System;
using System.Collections.Generic;
using System.Text;

namespace CSLibrary
{
    /// <summary>
    /// Reprezinta un membru nou al unei echipe
    /// </summary>
    public class MembruModel
    {
        /// <summary>
        /// Reprezinta numele unui membru al echipei
        /// </summary>
        public string Nume { get; set; }
        /// <summary>
        /// Reprezinta prenumele aceluiasi membru al echipei
        /// </summary>
        public string Prenume { get; set; }
        /// <summary>
        /// Reprezinta adresa de email al membrului echipei
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Reprezinta numarul de telefon al membrului echipei
        /// </summary>
        public string Telefon { get; set; }

    }
}
