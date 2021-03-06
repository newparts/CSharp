﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESLibrary.Model
{
    public class ModelPacient
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string CNP { get; set; }
        public string SerieCI { get; set; }
        public string NumarCI { get; set; }
        public string CardSanatate { get; set; }
        public string User { get; set; }
        public string Parola { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Adresa { get; set; }
        public string Localitate { get; set; }
        public string Judet { get; set; }
        public string Tara { get; set; }
        public int CodPostal { get; set; }
    }
}
