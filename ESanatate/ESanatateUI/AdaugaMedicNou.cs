using ESLibrary;
using ESLibrary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESanatateUI
{
    public partial class AdaugaMedicNou : Form
    {
        public AdaugaMedicNou()
        {
            InitializeComponent();
        }

        private void AdaugaMedicNou_Load(object sender, EventArgs e)
        {

        }

        private bool ValidareForm()
        {
            bool output = true;

            return output;
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            if (ValidareForm())
            {
                ModelMedic model = new ModelMedic (
                    txtBoxNume.Text,
                    txtBoxPrenume.Text,
                    txtBoxCNP.Text,
                    txtBoxSerieCI.Text,
                    txtBoxNrCI.Text,
                    txtBoxSerieContract.Text,
                    txtBoxNrContract.Text,
                    txtBoxCertificatCM.Text,
                    txtBoxNrCertificatCM.Text,
                    txtBoxUser.Text,
                    txtBoxPass.Text,
                    txtBoxTelefon.Text,
                    txtBoxEmail.Text,
                    txtBoxAdresa.Text,
                    txtBoxLocalitate.Text,
                    txtBoxJudet.Text,
                    txtBoxCod.Text,
                    txtBoxTara.Text,
                    txtBoxSpecializare.Text);

                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.AdaugaMedicNou(model);
                }

                txtBoxNume.Text = "";
                txtBoxPrenume.Text = "";
                txtBoxCNP.Text = "";
                txtBoxSerieCI.Text = "";
                txtBoxNrCI.Text = "";
                txtBoxSerieContract.Text = "";
                txtBoxNrContract.Text = "";
                txtBoxCertificatCM.Text = "";
                txtBoxNrCertificatCM.Text = "";
                txtBoxUser.Text = "";
                txtBoxPass.Text = "";
                txtBoxTelefon.Text = "";
                txtBoxEmail.Text = "";
                txtBoxAdresa.Text = "";
                txtBoxLocalitate.Text = "";
                txtBoxJudet.Text = "";
                txtBoxCod.Text = "";
                txtBoxTara.Text = "";
                txtBoxSpecializare.Text = "";

            }

            else
            {
                MessageBox.Show("Acest formular contine informatii invalide ! Va rugam ca sa verificati informatiile apoi incercati din nou !");
            }
        }
    }
}
