using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carti.UserControls
{
    public partial class UC_Vanzari : UserControl
    {
        public UC_Vanzari()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (Forms.Form_FinishOrder uf = new Forms.Form_FinishOrder())
            {
                uf.ShowDialog();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
