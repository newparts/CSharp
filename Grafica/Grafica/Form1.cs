using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            deseneaza();
        }

        private void deseneaza()
        {
            Graphics g = pictureBox1.CreateGraphics();
            Pen creion = new Pen(Color.Navy);
            int x, y, R=100;
            double alpha;
            for(alpha = -3.14; alpha<=3.14; alpha+=0.02)
            {
                x = (int)(250 + R * Math.Cos(alpha));
                y = (int)(250 + R * Math.Sin(alpha));
                g.DrawRectangle(creion, x, y, 2, 2);

            }
        }
    }
}
