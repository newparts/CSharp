using ESanatateUI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESanatateUI
{
    public partial class Inregistrari : Form
    {
        int PanelWidth;
        bool isCollapsed;

        public Inregistrari()
        {
            InitializeComponent();
            timerTime.Start();
            PanelWidth = panelLeft.Width;
            isCollapsed = false;
            InregistrariNoi inreg = new InregistrariNoi();
            AddControlsToPanel(inreg);
            
        }

        private void moveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 10;

                if (panelLeft.Width >= PanelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width = panelLeft.Width - 10;
                if (panelLeft.Width <= 60)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void buttonMeniu_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("HH : MM : ss");
        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnHome);
            InregistrariNoi inoi = new InregistrariNoi();
            AddControlsToPanel (inoi);
        }

        private void btnMedicNou_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnHome);
            MedicNou mn = new MedicNou();
            AddControlsToPanel(mn);
        }

        private void btnAsistentNou_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnHome);
            AsistentNou an = new AsistentNou();
            AddControlsToPanel(an);
        }

        private void btnPacientNou_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnHome);
            PacientNou pn = new PacientNou();
            AddControlsToPanel(pn);
        }

        private void btnLaboratorNou_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnHome);
            LaboratorNou ln = new LaboratorNou();
            AddControlsToPanel(ln);
        }

        private void btnFurnizorNou_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnHome);
            FurnizorNou fn = new FurnizorNou();
            AddControlsToPanel(fn);
        }

        private void btnRadiografieNoua_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnHome);
            RadiografieNoua rn = new RadiografieNoua();
            AddControlsToPanel(rn);
        }
    }
}
