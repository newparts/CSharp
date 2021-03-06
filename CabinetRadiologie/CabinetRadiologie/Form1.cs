﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pacientiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.radiografiiTableAdapter.Fill(this.cabinetRadiologieDataSet.Radiografii);

            this.pacientiTableAdapter.Fill(this.cabinetRadiologieDataSet.Pacienti);

        }

        private void pacientiBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {
            this.Validate();
            this.pacientiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cabinetRadiologieDataSet);
        }

        private void radiografiiDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void pic_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;

            foreach (DataRowView drv in radiografiiBindingSource.List)
            {
                string img = (string)drv["Imagine"];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Validate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Validate();
            this.pacientiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cabinetRadiologieDataSet);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pic = new PictureBox();

            //pic.SetBounds(0, 0, latimeControl, inaltimeControl);
            pic.BackColor = Color.Black;
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            //pic.Image = Bitmap.FromFile(numeFisier);
            pic.Tag = "Alte informatii despre control";

            flowLayoutPanel1.Controls.Add(pic);

            pic.Click += pic_Click;
        }

        
    }
}