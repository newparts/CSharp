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
            private string nume;
            private byte varsta;

            public string NumePersoana
            {
                get { return nume; }
                set { nume = value; }
            }

            public byte VarstaPersoana
            {
                get { return varsta; }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
