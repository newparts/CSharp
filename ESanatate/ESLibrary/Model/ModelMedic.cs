using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESLibrary.Model
{
    public class ModelMedic
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string CNP { get; set; }
        public string SerieCI { get; set; }
        public int NumarCI { get; set; }
        public string SerieContract { get; set; }
        public int NumarContract { get; set; }
        public string SerieCertificatCM { get; set; }
        public int NumarCertificatCM { get; set; }
        public string Utilizator { get; set; }
        public string Parola { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Adresa { get; set; }
        public string Localitate { get; set; }
        public string Judet { get; set; }
        public string Specializarea { get; set; }
        public int CodPostal { get; set; }
        public string Tara { get; set; }
        public int Id { get; set; }

      

        public ModelMedic(string txtBoxNume, string txtBoxPrenume, string txtBoxCNP, string txtBoxSerieCI,
            string txtBoxNumarCI, string txtBoxSerieContract, string txtBoxNrContract, string txtBoxCertificatCM,
            string txtBoxNrCertificatCM, string txtBoxUser, string txtBoxPass, string txtBoxTelefon, string txtBoxEmail,
            string txtBoxAdresa, string txtBoxLocalitate, string txtBoxJudet, string txtBoxTara,
            string txtBoxSpecializarea, string txtBoxCod)
        {
            Nume = txtBoxNume;
            Prenume = txtBoxPrenume;
            CNP = txtBoxCNP;
            SerieCI = txtBoxSerieCI;

            int txtBoxNrCIValoare = 0;
            int.TryParse(txtBoxNumarCI, out txtBoxNrCIValoare);
            NumarCI = txtBoxNrCIValoare;

            SerieContract = txtBoxSerieContract;

            int txtBoxNrContractValoare = 0;
            int.TryParse(txtBoxNrContract, out txtBoxNrContractValoare);
            NumarContract = txtBoxNrContractValoare;

            SerieCertificatCM = txtBoxCertificatCM;

            int txtBoxNrCertificatCMValoare = 0;
            int.TryParse(txtBoxNrCertificatCM, out txtBoxNrCertificatCMValoare);
            NumarCertificatCM = txtBoxNrCertificatCMValoare;

            Utilizator = txtBoxUser;
            Parola = txtBoxPass;
            Telefon = txtBoxTelefon;
            Email = txtBoxEmail;
            Adresa = txtBoxAdresa;
            Localitate = txtBoxLocalitate;
            Judet = txtBoxJudet;
            Tara = txtBoxTara;
            Specializarea = txtBoxSpecializarea;

            int txtBoxCodValoare = 0;
            int.TryParse(txtBoxCod, out txtBoxCodValoare);
            CodPostal = txtBoxCodValoare;
        }      
    }
}
