using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

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
            Thread firgalben = new Thread(()=> deseneaza(Color.Yellow,150,100));
            Thread firnavy = new Thread(()=> deseneaza(Color.Navy, 100, 150));
            firgalben.Start();
            firnavy.Start();
        }

        private void deseneaza(Color culoare, Int16 Rx, Int16 Ry)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Pen creion = new Pen(culoare);
            Pen guma = new Pen(Color.Yellow);
            int x, y;
            double alpha;
            for(alpha = -3.14; alpha<=3.14; alpha+=0.02)
            {
                x = (int)(250 + Rx * Math.Cos(alpha));
                y = (int)(250 + Ry * Math.Sin(alpha));
                g.DrawRectangle(creion, x, y, 2, 2);
                Thread.Sleep(15);
                g.DrawRectangle(guma, x, y, 2, 2);
            }
        }
    }
}
