using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CabinetRadiologie
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            //f.CNP = (string)((DataRowView)pacientiBindingSource.Current)["CNP"];
            if (f.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //radiografiiTableAdapter.Insert(cnp, imagine, data, diagnostic, comentarii);

            //tableAdapterManager.UpdateAll(pacientiDataSet);

            //radiografiiTableAdapter.Fill(pacientiDataSet.Radiografii);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = Application.StartupPath;
            dlg.Filter = "*.jpg|*.jpg";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
