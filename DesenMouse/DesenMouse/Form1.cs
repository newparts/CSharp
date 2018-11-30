using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesenMouse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            string date = "Coordonatele mouse-ului sunt: X=" + e.X.ToString() + "  Y=" + e.Y.ToString();
            Form1.ActiveForm.Text = date;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            string buton="dreapta", x, y;
            x = e.X.ToString();
            y = e.Y.ToString();
            if (e.Button == MouseButtons.Left) buton = "stanga";
            MessageBox.Show("Ati dat click" + buton + " la coordonatele" + x + " si " + y);

        }
    }
}
