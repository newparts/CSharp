using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string WebPage = txtAddress.Text.Trim();
            webBrowser1.Navigate(WebPage);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
            {
                webBrowser1.GoBack();
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
            {
                webBrowser1.GoForward();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void btnBack_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnBack, "Inapoi");
        }

        private void btnHome_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnHome, "Acasa");
        }

        private void btnForward_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnForward, "Inainte");
        }

        private void btnStop_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnStop, "Stop");
        }

        private void btnRefresh_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnRefresh, "Reincarca");
        }
    }
}
