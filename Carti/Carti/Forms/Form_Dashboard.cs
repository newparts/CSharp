using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carti.Forms
{
    public partial class Form_Dashboard : Form
    {
        int PanelWidth;
        bool isCollapsed;

        public Form_Dashboard()
        {
            InitializeComponent();
            timerTime.Start();
            PanelWidth = panelLeft.Width;
            isCollapsed = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 10;

                if(panelLeft.Width >= PanelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width = panelLeft.Width - 10;
                if(panelLeft.Width <= 60)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void moveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnHome);
        }

        private void btnDepozit_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnDepozit);
        }

        private void btnComenzi_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnComenzi);
        }

        private void btnVanzari_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnVanzari);
        }

        private void btnContabilitate_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnContabilitate);
        }

        private void btnUtilizatori_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnUtilizatori);
        }

        private void btnSetari_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnSetari);
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("HH : MM : ss");
        }
    }
}
