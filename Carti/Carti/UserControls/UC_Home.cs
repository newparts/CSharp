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
    public partial class UC_Home : UserControl
    {
        public UC_Home()
        {
            InitializeComponent();
        }

        Random rand = new Random();

        private void LoadChart()
        {
            var cnv = new Bunifu.DataViz.Canvas();
            var dataPoint = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_splineArea);

            dataPoint.addLabely("Ianuarie", rand.Next(0, 1000).ToString());
            dataPoint.addLabely("Februarie", rand.Next(0, 1000).ToString());
            dataPoint.addLabely("Martie", rand.Next(0, 1000).ToString());
            dataPoint.addLabely("Aprilie", rand.Next(0, 1000).ToString());
            dataPoint.addLabely("Mai", rand.Next(0, 1000).ToString());
            dataPoint.addLabely("Iunie", rand.Next(0, 1000).ToString());
            dataPoint.addLabely("Iulie", rand.Next(0, 1000).ToString());
            dataPoint.addLabely("August", rand.Next(0, 1000).ToString());
            dataPoint.addLabely("Septembrie", rand.Next(0, 1000).ToString());
            dataPoint.addLabely("Octombrie", rand.Next(0, 1000).ToString());
            dataPoint.addLabely("Noiembrie", rand.Next(0, 1000).ToString());
            dataPoint.addLabely("Decembrie", rand.Next(0, 1000).ToString());

            cnv.addData(dataPoint);
            bunifuDataViz1.colorSet.Add(Color.Red);
            bunifuDataViz1.Render(cnv);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadChart();
        }
    }
}
