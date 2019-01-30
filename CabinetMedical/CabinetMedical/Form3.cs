using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CabinetMedical
{
    public partial class Form3 : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\iuliu\Desktop\newparts.github.io\CSharp\CabinetMedical\CabinetMedical\CabinetMedical.mdf;Integrated Security=True;Connect Timeout=30");
        Radiografii model = new Radiografii();
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.ShowDialog();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cabinetMedicalDataSet.Pacienti' table. You can move, or remove it, as needed.
            this.pacientiTableAdapter.Fill(this.cabinetMedicalDataSet.Pacienti);
            FillDataGridView();
        }
        void FillDataGridView()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();

            SqlDataAdapter sqlDat = new SqlDataAdapter("RadiografiiAfisareCautare", sqlCon);
            sqlDat.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDat.SelectCommand.Parameters.AddWithValue("@Nume", textBox1.Text.Trim());
            DataTable dttbl = new DataTable();
            sqlDat.Fill(dttbl);
            dataGridView1.DataSource = dttbl;
            dataGridView1.Columns[0].Visible = false;
            sqlCon.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                FillDataGridView();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eroare");
            }
        }
    }
}
