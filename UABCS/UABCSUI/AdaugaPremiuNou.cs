using System;
using System.Windows.Forms;
using UABCSLib;
using UABCSLib.AccesDate;
using UABCSLib.Model;

namespace UABCSUI
{
    public partial class AdaugaPremiuNou : Form
    {
        public AdaugaPremiuNou()
        {
            InitializeComponent();
        }

        private void numeValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void sauLabel_Click(object sender, EventArgs e)
        {

        }

        private void AdaugaPremiuNou_Load(object sender, EventArgs e)
        {

        }

        private void salveazaPremiuNou_Click(object sender, EventArgs e)
        {
            if(ValidareForm())
            {
                PremiiModel model = new PremiiModel(
                    loculOcupatValue.Text, 
                    valoarePremiuValue.Text, 
                    numeleLoculuiValue.Text, 
                    procentPremiuValue.Text);
                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.CrearePremii(model);
                }

                loculOcupatValue.Text = "";
                valoarePremiuValue.Text = "0";
                numeleLoculuiValue.Text = "";
                procentPremiuValue.Text = "0";
            }

            else
            {
                MessageBox.Show("Acest formular contine informatii invalide ! Va rugam ca sa verificati informatiile apoi incercati din nou !");
            }
        }

        private bool ValidareForm()
        {
            bool output = true;
            int loculOcupat = 0;
            bool loculOcupatValidNumber = int.TryParse(loculOcupatValue.Text, out loculOcupat);

            if (loculOcupatValidNumber == false)
            {
                output = false;
            }

            if(loculOcupat < 1)
            {
                output = false;
            }

            if(numeleLoculuiValue.Text.Length == 0)
            {
                output = false;
            }

            decimal valoarePremiu = 0;
            double procentPremiu = 0;

            bool valoarePremiuValid = decimal.TryParse(valoarePremiuValue.Text, out valoarePremiu);
            bool procentPremiuValid = double.TryParse(procentPremiuValue.Text, out procentPremiu);

            if (valoarePremiuValid == false || procentPremiuValid == false)
                {
                output = false;
                }

            if (valoarePremiu <= 0 && procentPremiu <=0)
            {
                output = false;
            }

            if(procentPremiu < 0 || procentPremiu > 100)
            {
                output = false;
            }

            return output;
        }
    }
}
