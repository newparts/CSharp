namespace VeziPoze
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLoadImages = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.oFD1 = new System.Windows.Forms.OpenFileDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.saveFD = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(204, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 600);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(750, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // btnLoadImages
            // 
            this.btnLoadImages.Location = new System.Drawing.Point(46, 23);
            this.btnLoadImages.Name = "btnLoadImages";
            this.btnLoadImages.Size = new System.Drawing.Size(100, 25);
            this.btnLoadImages.TabIndex = 1;
            this.btnLoadImages.Text = "Incarca Imagini";
            this.btnLoadImages.UseVisualStyleBackColor = true;
            this.btnLoadImages.Click += new System.EventHandler(this.btnLoadImages_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Imagini";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(25, 86);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(160, 585);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // oFD1
            // 
            this.oFD1.FileName = "openFileDialog1";
            this.oFD1.Multiselect = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(64, 64);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // button1
            // 
            this.button1.ImageKey = "iconfinder_ic_screen_rotation_48px_352089.png";
            this.button1.ImageList = this.imageList2;
            this.button1.Location = new System.Drawing.Point(254, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "iconfinder_clone_1608634.png");
            this.imageList2.Images.SetKeyName(1, "iconfinder_Deal_With_It_Glasses_pixel_geek_mame_3186898.png");
            this.imageList2.Images.SetKeyName(2, "iconfinder_ic_crop_din_48px_352295.png");
            this.imageList2.Images.SetKeyName(3, "iconfinder_ic_flip_48px_352371.png");
            this.imageList2.Images.SetKeyName(4, "iconfinder_ic_screen_rotation_48px_352089.png");
            this.imageList2.Images.SetKeyName(5, "iconfinder_save_1608823.png");
            // 
            // button2
            // 
            this.button2.ImageKey = "iconfinder_ic_flip_48px_352371.png";
            this.button2.ImageList = this.imageList2;
            this.button2.Location = new System.Drawing.Point(295, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 35);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // button3
            // 
            this.button3.ImageKey = "iconfinder_ic_crop_din_48px_352295.png";
            this.button3.ImageList = this.imageList2;
            this.button3.Location = new System.Drawing.Point(336, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 35);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseHover += new System.EventHandler(this.button3_MouseHover);
            // 
            // button4
            // 
            this.button4.ImageKey = "iconfinder_Deal_With_It_Glasses_pixel_geek_mame_3186898.png";
            this.button4.ImageList = this.imageList2;
            this.button4.Location = new System.Drawing.Point(377, 24);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 35);
            this.button4.TabIndex = 7;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.MouseHover += new System.EventHandler(this.button4_MouseHover);
            // 
            // button5
            // 
            this.button5.ImageKey = "iconfinder_clone_1608634.png";
            this.button5.ImageList = this.imageList2;
            this.button5.Location = new System.Drawing.Point(418, 24);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(35, 35);
            this.button5.TabIndex = 8;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.MouseHover += new System.EventHandler(this.button5_MouseHover);
            // 
            // button6
            // 
            this.button6.ImageKey = "iconfinder_save_1608823.png";
            this.button6.ImageList = this.imageList2;
            this.button6.Location = new System.Drawing.Point(459, 24);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(35, 35);
            this.button6.TabIndex = 9;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            this.button6.MouseHover += new System.EventHandler(this.button6_MouseHover);
            // 
            // saveFD
            // 
            this.saveFD.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoadImages);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Imagini";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLoadImages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.OpenFileDialog oFD1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.SaveFileDialog saveFD;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

