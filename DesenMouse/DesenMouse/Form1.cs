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
        int x1, y1, x2, y2;
        bool deseneaza = false;
        Graphics desen;
        Pen creion;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            deseneaza = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            deseneaza = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            x2 = e.X;
            y2 = e.Y;
            deseneazaM();
            x1 = x2;
            y1 = y2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            desen = pictureBox1.CreateGraphics();
            creion = new Pen(Color.Navy);
        }

        public Form1()
        {
            InitializeComponent();
        }

        void deseneazaM()
        {
            if (deseneaza) desen.DrawLine(creion, x1, y1, x2, y2);
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
            MessageBox.Show("Ati dat click" + buton + " la coordonatele " + x + " si " + y);
        }


    }
}
