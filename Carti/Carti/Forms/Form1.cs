using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carti
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Forms.Form_Dashboard fd = new Forms.Form_Dashboard())
            {
                fd.ShowDialog();
            }

        }
    }
}
