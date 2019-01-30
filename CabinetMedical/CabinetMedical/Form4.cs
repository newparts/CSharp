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
    public partial class Form4 : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\iuliu\Desktop\newparts.github.io\CSharp\CabinetMedical\CabinetMedical\CabinetMedical.mdf;Integrated Security=True;Connect Timeout=30");
        Radiografii model = new Radiografii();
        private string strFilePath = "";
        
        Image DefaultImage;
        private object pbxImage;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                if (button1.Text == "Salveaza")
                {
                    SqlCommand sqlCmd = new SqlCommand("RadiografiiAddEdit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Add");
                    sqlCmd.Parameters.AddWithValue("@Id", 0);
                    sqlCmd.Parameters.AddWithValue("@CNP", textBox1.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Imagine", textBox2.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Nume", textBox5.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Diagnostic", textBox3.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Comentarii", textBox4.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost salvate cu succes !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eroare");
            }
            finally
            {
                sqlCon.Close();
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = Application.StartupPath;
            dlg.Filter = "Images(.jpg, .png) *.jpg|*.jpg";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                strFilePath = dlg.FileName;
                //pbxImage.Image = new Bitmap(strFilePath);
                if (textBox2.Text.Trim().Length == 0)
                    textBox2.Text = System.IO.Path.GetFileName(strFilePath);

            }
        }


    }
}
