﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UABCSLibrary.Model
{
    /// <summary>
    /// Reprezinta o competitie noua
    /// </summary>
    public class CompetitieModel
    {
        /// <summary>
        /// Reprezinta Numele competitiei
        /// </summary>
        public string NumeCompetitie { get; set; }
        /// <summary>
        /// Reprezinta Taxa de participare
        /// </summary>
        public decimal TaxaParticipare { get; set; }
        /// <summary>
        /// Reprezinta Numele Echipelor participante la competitie
        /// </summary>
        public List<MembruModel> EchipeParticipante { get; set; } = new List<MembruModel>();
        /// <summary>
        /// Reprezinta Premiile puse in joc
        /// </summary>
        public List<PremiiModel> Premii { get; set; } = new List<PremiiModel>();
        /// <summary>
        /// Reprezinta rundele jucate
        /// </summary>
        public List<List<MeciuriModel>> Runde { get; set; } = new List<List<MeciuriModel>>();

    }
}
