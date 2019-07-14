namespace ESanatateUI
{
    partial class Programare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Programare));
            this.labelProgramari = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictBoxCalendar = new System.Windows.Forms.PictureBox();
            this.pictBoxMedic = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.txtBoxNume = new System.Windows.Forms.TextBox();
            this.labelProg = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelNume = new System.Windows.Forms.Label();
            this.labelPrenume = new System.Windows.Forms.Label();
            this.txtBoxPrenume = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.txtBoxTelefon = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.labelComent = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelMedic = new System.Windows.Forms.Label();
            this.labelNumeMedic = new System.Windows.Forms.Label();
            this.labelPacientNou = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxCalendar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxMedic)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelProgramari
            // 
            this.labelProgramari.AutoSize = true;
            this.labelProgramari.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelProgramari.ForeColor = System.Drawing.Color.White;
            this.labelProgramari.Location = new System.Drawing.Point(198, 22);
            this.labelProgramari.Name = "labelProgramari";
            this.labelProgramari.Size = new System.Drawing.Size(393, 55);
            this.labelProgramari.TabIndex = 0;
            this.labelProgramari.Text = "Programare Noua";
            this.labelProgramari.Click += new System.EventHandler(this.labelProgramari_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(175)))));
            this.panel1.Controls.Add(this.pictBoxMedic);
            this.panel1.Controls.Add(this.pictBoxCalendar);
            this.panel1.Controls.Add(this.labelProgramari);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 100);
            this.panel1.TabIndex = 1;
            // 
            // pictBoxCalendar
            // 
            this.pictBoxCalendar.Image = ((System.Drawing.Image)(resources.GetObject("pictBoxCalendar.Image")));
            this.pictBoxCalendar.Location = new System.Drawing.Point(672, 12);
            this.pictBoxCalendar.Name = "pictBoxCalendar";
            this.pictBoxCalendar.Size = new System.Drawing.Size(100, 77);
            this.pictBoxCalendar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictBoxCalendar.TabIndex = 1;
            this.pictBoxCalendar.TabStop = false;
            this.pictBoxCalendar.Click += new System.EventHandler(this.pictBoxCalendar_Click);
            // 
            // pictBoxMedic
            // 
            this.pictBoxMedic.Image = ((System.Drawing.Image)(resources.GetObject("pictBoxMedic.Image")));
            this.pictBoxMedic.Location = new System.Drawing.Point(12, 12);
            this.pictBoxMedic.Name = "pictBoxMedic";
            this.pictBoxMedic.Size = new System.Drawing.Size(104, 77);
            this.pictBoxMedic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictBoxMedic.TabIndex = 2;
            this.pictBoxMedic.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.btnSalveaza);
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Location = new System.Drawing.Point(12, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 346);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calendar";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(73, 96);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSalveaza.Location = new System.Drawing.Point(143, 291);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(102, 34);
            this.btnSalveaza.TabIndex = 1;
            this.btnSalveaza.Text = "Ascunde";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            // 
            // txtBoxNume
            // 
            this.txtBoxNume.Location = new System.Drawing.Point(556, 175);
            this.txtBoxNume.Name = "txtBoxNume";
            this.txtBoxNume.Size = new System.Drawing.Size(200, 20);
            this.txtBoxNume.TabIndex = 3;
            // 
            // labelProg
            // 
            this.labelProg.AutoSize = true;
            this.labelProg.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelProg.Location = new System.Drawing.Point(12, 123);
            this.labelProg.Name = "labelProg";
            this.labelProg.Size = new System.Drawing.Size(0, 24);
            this.labelProg.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(73, 36);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(227, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNume.Location = new System.Drawing.Point(441, 175);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(58, 22);
            this.labelNume.TabIndex = 5;
            this.labelNume.Text = "Nume";
            // 
            // labelPrenume
            // 
            this.labelPrenume.AutoSize = true;
            this.labelPrenume.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPrenume.Location = new System.Drawing.Point(441, 220);
            this.labelPrenume.Name = "labelPrenume";
            this.labelPrenume.Size = new System.Drawing.Size(83, 22);
            this.labelPrenume.TabIndex = 7;
            this.labelPrenume.Text = "Prenume";
            // 
            // txtBoxPrenume
            // 
            this.txtBoxPrenume.Location = new System.Drawing.Point(556, 220);
            this.txtBoxPrenume.Name = "txtBoxPrenume";
            this.txtBoxPrenume.Size = new System.Drawing.Size(200, 20);
            this.txtBoxPrenume.TabIndex = 6;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEmail.Location = new System.Drawing.Point(441, 266);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(58, 22);
            this.labelEmail.TabIndex = 9;
            this.labelEmail.Text = "Email";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(556, 269);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(200, 20);
            this.txtBoxEmail.TabIndex = 8;
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTelefon.Location = new System.Drawing.Point(441, 318);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(70, 22);
            this.labelTelefon.TabIndex = 11;
            this.labelTelefon.Text = "Telefon";
            // 
            // txtBoxTelefon
            // 
            this.txtBoxTelefon.Location = new System.Drawing.Point(556, 318);
            this.txtBoxTelefon.Name = "txtBoxTelefon";
            this.txtBoxTelefon.Size = new System.Drawing.Size(200, 20);
            this.txtBoxTelefon.TabIndex = 10;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReset.Location = new System.Drawing.Point(445, 487);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(128, 34);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Sterge";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.Location = new System.Drawing.Point(643, 487);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 34);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Salveaza";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // labelComent
            // 
            this.labelComent.AutoSize = true;
            this.labelComent.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelComent.Location = new System.Drawing.Point(441, 366);
            this.labelComent.Name = "labelComent";
            this.labelComent.Size = new System.Drawing.Size(102, 22);
            this.labelComent.TabIndex = 14;
            this.labelComent.Text = "Comentarii";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(556, 367);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 94);
            this.textBox1.TabIndex = 15;
            // 
            // labelMedic
            // 
            this.labelMedic.AutoSize = true;
            this.labelMedic.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMedic.Location = new System.Drawing.Point(18, 123);
            this.labelMedic.Name = "labelMedic";
            this.labelMedic.Size = new System.Drawing.Size(66, 22);
            this.labelMedic.TabIndex = 16;
            this.labelMedic.Text = "Medic:";
            // 
            // labelNumeMedic
            // 
            this.labelNumeMedic.AutoSize = true;
            this.labelNumeMedic.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNumeMedic.Location = new System.Drawing.Point(90, 123);
            this.labelNumeMedic.Name = "labelNumeMedic";
            this.labelNumeMedic.Size = new System.Drawing.Size(16, 22);
            this.labelNumeMedic.TabIndex = 17;
            this.labelNumeMedic.Text = "-";
            // 
            // labelPacientNou
            // 
            this.labelPacientNou.AutoSize = true;
            this.labelPacientNou.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPacientNou.Location = new System.Drawing.Point(441, 125);
            this.labelPacientNou.Name = "labelPacientNou";
            this.labelPacientNou.Size = new System.Drawing.Size(110, 22);
            this.labelPacientNou.TabIndex = 18;
            this.labelPacientNou.Text = "Pacient Nou";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLogin.Location = new System.Drawing.Point(639, 125);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(116, 22);
            this.labelLogin.TabIndex = 19;
            this.labelLogin.Text = "Autentificare";
            // 
            // Programare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelPacientNou);
            this.Controls.Add(this.labelNumeMedic);
            this.Controls.Add(this.labelMedic);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelComent);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.labelTelefon);
            this.Controls.Add(this.txtBoxTelefon);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.labelPrenume);
            this.Controls.Add(this.txtBoxPrenume);
            this.Controls.Add(this.labelNume);
            this.Controls.Add(this.labelProg);
            this.Controls.Add(this.txtBoxNume);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Programare";
            this.Text = "Programare";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxCalendar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxMedic)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProgramari;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictBoxMedic;
        private System.Windows.Forms.PictureBox pictBoxCalendar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtBoxNume;
        private System.Windows.Forms.Label labelProg;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.Label labelPrenume;
        private System.Windows.Forms.TextBox txtBoxPrenume;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.TextBox txtBoxTelefon;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label labelComent;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelMedic;
        private System.Windows.Forms.Label labelNumeMedic;
        private System.Windows.Forms.Label labelPacientNou;
        private System.Windows.Forms.Label labelLogin;
    }
}