using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studenti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Persoana
        {
            protected string Nume;
            protected byte Varsta;

            public Persoana(string nume, byte varsta)
            {
                Nume = nume;
                Varsta = varsta;
            }

            public string Pers() { return Nume + " " + Varsta; }

        }

        class Student : Persoana
        {
            float Medie;
            private readonly byte an;
            private readonly byte[] note = new byte[5];
            public Student(byte an, string nume, byte note, byte varsta, float Medie) : base(nume, varsta)
            {


            }

            public string AfisareStudent()
            {
                return Nume + ", " + Varsta + " de ani, anul " + an + " " + Medie + ", media ";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.Read();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
    
    }
    }
}
