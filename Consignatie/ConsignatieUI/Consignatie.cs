using ConsignatieClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsignatieUI
{
    public partial class Consignatie : Form
    {
        private Magazin magazin = new Magazin();
        private List<Produs> CosCumparaturiData = new List<Produs>();
        BindingSource produseBinding = new BindingSource();
        BindingSource cosProduseBinding = new BindingSource();
        BindingSource furnizoriBinding = new BindingSource();
        private decimal profit = 0;

        public Consignatie()
        {
            InitializeComponent();
            SetupData();

            produseBinding.DataSource = magazin.Produse.Where(x => x.Vanzare == false).ToList();
            listaProduse.DataSource = produseBinding;
            listaProduse.DisplayMember = "Display";
            listaProduse.ValueMember = "Display";

            cosProduseBinding.DataSource = CosCumparaturiData;
            listaCosProduse.DataSource = cosProduseBinding;
            listaCosProduse.DisplayMember = "Display";
            listaCosProduse.ValueMember = "Display";

            furnizoriBinding.DataSource = magazin.Furnizori;
            listaFurnizori.DataSource = furnizoriBinding;

            listaFurnizori.DisplayMember = "Display";
            listaFurnizori.ValueMember = "Display";
        }

        private void produseLabel_Click(object sender, EventArgs e)
        {

        }

        private void Consignatie_Load(object sender, EventArgs e)
        {

        }

        private void SetupData()
        {
            magazin.Furnizori.Add(new Furnizor { Nume = "Ionescu", Prenume = "Ion" });
            magazin.Furnizori.Add(new Furnizor { Nume = "Bibescu", Prenume = "Maria" });

            magazin.Produse.Add(new Produs
            {
                Titlu = "Winnetou",
                Descriere = "Aventurile unei capetenii apache",
                Pret = 45.5M,
                Proprietar = magazin.Furnizori[0]
            });

            magazin.Produse.Add(new Produs
            {
                Titlu = "Insula plutitoare",
                Descriere = "Descrierea unei aventuri pe o insula plutitoare",
                Pret = 67.5M,
                Proprietar = magazin.Furnizori[1]
            });

            magazin.Produse.Add(new Produs
            {
                Titlu = "Alba Iulia",
                Descriere = "Monografia orsaului Alba Iulia",
                Pret = 36M,
                Proprietar = magazin.Furnizori[0]
            });

            magazin.Produse.Add(new Produs
            {
                Titlu = "Castelul din Carpati",
                Descriere = "Descrierea unor aventuri in Transilvania",
                Pret = 82M,
                Proprietar = magazin.Furnizori[1]
            });

            magazin.Nume = "Consignatie";
        }

        private void adaugaProdusul_Click(object sender, EventArgs e)
        {
            Produs produsSelectat = (Produs)listaProduse.SelectedItem;

            CosCumparaturiData.Add(produsSelectat);

            cosProduseBinding.ResetBindings(false);
        }

        private void butonComanda_Click(object sender, EventArgs e)
        {
            foreach (Produs item in CosCumparaturiData)
            {
                item.Vanzare = true;
                item.Proprietar.Plati += (decimal)item.Proprietar.Comision * item.Pret;
                profit += (1-(decimal)item.Proprietar.Comision) * item.Pret;
            }

            CosCumparaturiData.Clear();
            produseBinding.DataSource = magazin.Produse.Where(x => x.Vanzare == false).ToList();

            profitValoare.Text = string.Format("{0} Lei", profit);

            cosProduseBinding.ResetBindings(false);
            produseBinding.ResetBindings(false);
            furnizoriBinding.ResetBindings(false);
        }
    }
}
