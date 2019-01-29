using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeziPoze
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadImages_Click(object sender, EventArgs e)
        {
            imageList1.Images.Clear();
            listView1.Clear();

            oFD1.InitialDirectory = "C:\\";
            oFD1.Title = "Incarca o poza";
            oFD1.Filter = "JPEGS|*.jpg|GIFS|*.gif";
            var ofdResults = oFD1.ShowDialog();
            if (ofdResults == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }

            try
            {
                int num_of_files = oFD1.FileNames.Length;
                string[] aryFilePaths = new string[num_of_files];
                int counter = 0;
                foreach (string single_file in oFD1.FileNames)
                {
                    aryFilePaths[counter] = single_file;
                    imageList1.Images.Add(Image.FromFile(single_file));
                    counter++;
                    
                }

                listView1.LargeImageList = imageList1;
                for (int i = 0; i < counter; i++)
                {
                    listView1.Items.Add(aryFilePaths[i], i);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Eroare: " + err.Message);
            }
            foreach (string single_file in oFD1.FileNames)
            {
                MessageBox.Show(single_file);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string big_filename;
            for (int i = 0; i < listView1.SelectedItems.Count; i++)
            {
                big_filename = listView1.SelectedItems[i].Text;
                pictureBox1.Image = Image.FromFile(big_filename);
                panel1.AutoScrollMinSize = new Size(pictureBox1.Image.Width,pictureBox1.Image.Height);
            }

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button==System.Windows.Forms.MouseButtons.Right)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Image);
                Bitmap bmp_new = new Bitmap(Convert.ToInt32(pictureBox1.Image.Width / 2), Convert.ToInt32(pictureBox1.Image.Height / 2));

                Graphics gr = Graphics.FromImage(bmp_new);
                gr.DrawImage(bmp, 0, 0, bmp_new.Width, bmp_new.Height);
                pictureBox1.Image = bmp_new;
            }
            else
            {
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Image);
                bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox1.Image = bmp;
            }
            else
            {
                MessageBox.Show("Nu exista nici o imagine!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            bmp.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pictureBox1.Image = bmp;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Rectangle rect = new Rectangle(0, 0, 200, 200);
            Bitmap cloneImage = bmp.Clone(rect, System.Drawing.Imaging.PixelFormat.DontCare);
            pictureBox1.Image = cloneImage;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            int x, y;
            for (x = 0; x < bmp.Width; x++)
            {
                for (y = 0; y < bmp.Height; y++)
                {
                    Color old_pixel_colour = bmp.GetPixel(x, y);
                    Color new_pixel_colour = Color.FromArgb(old_pixel_colour.R, 0, 0);
                    bmp.SetPixel(x, y, new_pixel_colour);
                }
            }
            pictureBox1.Image = bmp;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            int x, y;
            for (x = 0; x < bmp.Width; x++)
            {
                for (y = 0; y < bmp.Height; y++)
                {
                    Color old_pixel_colour = bmp.GetPixel(x, y);
                    Color new_pixel_colour = Color.FromArgb(255 - old_pixel_colour.R, 255 - old_pixel_colour.G, 255 - old_pixel_colour.B);
                    bmp.SetPixel(x, y, new_pixel_colour);
                }
            }
            pictureBox1.Image = bmp;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string save_path = "";
            saveFD.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFD.FileName = "default";
            saveFD.Filter = "JPEG|*.jpeg";

            if (saveFD.ShowDialog() != DialogResult.Cancel)
            {
                save_path = saveFD.FileName;
                Bitmap bmp = new Bitmap(pictureBox1.Image);
                bmp.Save(save_path, System.Drawing.Imaging.ImageFormat.Jpeg);
                MessageBox.Show("Imaginea a fost salvata!");
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button1, "Roteste Imaginea");
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button2, "Inverseaza Imaginea");
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button3, "Cloneaza Imaginea");
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button4, "Schimba Culoarea");
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button5, "Inverseaza Culoarea");
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button6, "Salveaza Imaginea");
        }
    }
}
