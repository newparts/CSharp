
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
    public partial class Registratura : Form
    {
        int PanelWidth;
        bool isCollapsed;

        public Registratura()
        {
            InitializeComponent();
            timerTime.Start();
            PanelWidth = panelLeft.Width;
            isCollapsed = false;
            MedicNou mn = new MedicNou();
            AddControlsToPanel(mn);
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

        private void buttonMeniu_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnHome);
        }

        private void btnMedici_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnMedici);
        }

        private void btnAsistenti_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnAsistenti);
        }

        private void btnPacienti_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnPacienti);
        }

        private void btnContabilitate_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnContabilitate);
        }

        private void btnUtilizatori_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnUtilizatori);
        }

        private void btnLaborator_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnLaborator);
        }

        private void btnFurnizor_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnFurnizor);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnSetari);
        }

        

        private void timer1_Tick_1(object sender, EventArgs e)
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

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("HH : MM : ss");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }

        private void labelRolUser_Click(object sender, EventArgs e)
        {

        }

        private void labelRol_Click(object sender, EventArgs e)
        {

        }

        private void labelNumeUser_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelSalut_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void labelFront_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelNumeCabinet_Click(object sender, EventArgs e)
        {

        }

        private void labelDenumireCabinet_Click(object sender, EventArgs e)
        {

        }

        private void pictBoxLogo_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelSide_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelControls_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
