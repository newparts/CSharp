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
    public partial class Form2 : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\iuliu\Desktop\newparts.github.io\CSharp\CabinetMedical\CabinetMedical\CabinetMedical.mdf;Integrated Security=True;Connect Timeout=30");
        Radiografii model = new Radiografii();
        int Id = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Clear()
        {
            textBox1.Text = textBox2.Text = textBox3.Text = "";
            button1.Text = "Salveaza";
            button2.Enabled = true;
            model.SetPacienti(0);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Clear();
         
            FillDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                if (button1.Text == "Salveaza")
                {
                    SqlCommand sqlCmd = new SqlCommand("PacientiAddEdit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Add");
                    sqlCmd.Parameters.AddWithValue("@Id", 0);
                    sqlCmd.Parameters.AddWithValue("@CNP", textBox1.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Nume", textBox2.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Adresa", textBox3.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost salvate cu succes !");
                }
                else
                {
                    SqlCommand sqlCmd = new SqlCommand("PacientiAddEdit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Edit");
                    sqlCmd.Parameters.AddWithValue("@Id", Id);
                    sqlCmd.Parameters.AddWithValue("@CNP", textBox1.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Nume", textBox2.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Adresa", textBox3.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost actualizate cu succes !");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Eroare");
            }
            finally
            {
                sqlCon.Close();
            }  
        }

        void FillDataGridView()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();

            SqlDataAdapter sqlDat = new SqlDataAdapter("PacientiAfisareCautare", sqlCon);
            sqlDat.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDat.SelectCommand.Parameters.AddWithValue("@Nume", textBox4.Text.Trim());
            DataTable dttbl = new DataTable();
            sqlDat.Fill(dttbl);
            dataGridView1.DataSource = dttbl;
            dataGridView1.Columns[0].Visible = false;
            sqlCon.Close();
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
              
                textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                button1.Text = "Actualizati";
                button2.Enabled = true;
            }
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                if (button2.Text == "Sterge")
                {
                    SqlCommand sqlCmd = new SqlCommand("PacientiSterge", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@Id", Id);
                    
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost sterse cu succes !");
                   
                    FillDataGridView();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Eroare");
            }
        }
        
    }

    internal class Radiografii
    {
        private int pacienti;

        public int GetPacienti()
        {
            return pacienti;
        }

        internal void SetPacienti(int value)
        {
            pacienti = value;
        }

        
    }
}
