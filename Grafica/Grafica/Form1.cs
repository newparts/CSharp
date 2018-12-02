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
            //Thread firnavy = new Thread(()=> deseneaza(Color.Navy, 100, 150));
            firgalben.Start();
            //firnavy.Start();
        }

        private void deseneaza(Color culoare, Int16 Rx, Int16 Ry)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Pen creion = new Pen(culoare);
            Pen guma = new Pen(Color.Yellow);
            int x1, y1, x2, y2, x3, y3, vx=330, vy=100;
            double alpha;
            g.DrawEllipse(creion, 130, 230, 400, 200);
            for(alpha = -3.14; alpha<=3.14; alpha+=0.02)
            {
                x1 = (int)(330 + Rx * Math.Cos(alpha));
                y1 = (int)(330 + Ry * Math.Sin(alpha));
                x2 = (int)(330 + Rx * Math.Cos(alpha+2));
                y2 = (int)(330 + Ry * Math.Sin(alpha+2));
                x3 = (int)(330 + Rx * Math.Cos(alpha-2));
                y3 = (int)(330 + Ry * Math.Sin(alpha-2));
                g.DrawLine(creion, x1, y1, x2, y2);
                g.DrawLine(creion, x1, y1, x3, y3);
                g.DrawLine(creion, x3, y3, x2, y2);
                g.DrawLine(creion, x1, y1, vx, vy);
                g.DrawLine(creion, x2, y2, vx, vy);
                g.DrawLine(creion, x3, y3, vx, vy);
                Thread.Sleep(15);
                g.DrawLine(guma, x1, y1, x2, y2);
                g.DrawLine(guma, x1, y1, x3, y3);
                g.DrawLine(guma, x3, y3, x2, y2);
                g.DrawLine(guma, x1, y1, vx, vy);
                g.DrawLine(guma, x2, y2, vx, vy);
                g.DrawLine(guma, x3, y3, vx, vy);
                g.DrawEllipse(creion, 130, 230, 400, 200);
            }
        }
    }
}
