namespace ESanatateUI
{
    partial class Registratura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registratura));
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.panelControls = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelRolUser = new System.Windows.Forms.Label();
            this.labelRol = new System.Windows.Forms.Label();
            this.labelNumeUser = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelSalut = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.labelFront = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonMeniu = new System.Windows.Forms.Button();
            this.labelNumeCabinet = new System.Windows.Forms.Label();
            this.labelDenumireCabinet = new System.Windows.Forms.Label();
            this.pictBoxLogo = new System.Windows.Forms.PictureBox();
            this.btnLaborator = new System.Windows.Forms.Button();
            this.btnUtilizatori = new System.Windows.Forms.Button();
            this.btnContabilitate = new System.Windows.Forms.Button();
            this.btnMedici = new System.Windows.Forms.Button();
            this.btnPacienti = new System.Windows.Forms.Button();
            this.btnAsistenti = new System.Windows.Forms.Button();
            this.panelSide = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnSetari = new System.Windows.Forms.Button();
            this.btnFurnizor = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 6;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panelControls
            // 
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControls.Location = new System.Drawing.Point(215, 150);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(1069, 599);
            this.panelControls.TabIndex = 9;
            this.panelControls.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControls_Paint);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelTime.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(931, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(138, 24);
            this.labelTime.TabIndex = 10;
            this.labelTime.Text = "HH : MM : SS";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelTime.Click += new System.EventHandler(this.labelTime_Click);
            // 
            // labelRolUser
            // 
            this.labelRolUser.AutoSize = true;
            this.labelRolUser.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRolUser.ForeColor = System.Drawing.Color.White;
            this.labelRolUser.Location = new System.Drawing.Point(165, 57);
            this.labelRolUser.Name = "labelRolUser";
            this.labelRolUser.Size = new System.Drawing.Size(69, 24);
            this.labelRolUser.TabIndex = 9;
            this.labelRolUser.Text = "Admin";
            this.labelRolUser.Click += new System.EventHandler(this.labelRolUser_Click);
            // 
            // labelRol
            // 
            this.labelRol.AutoSize = true;
            this.labelRol.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRol.ForeColor = System.Drawing.Color.White;
            this.labelRol.Location = new System.Drawing.Point(109, 58);
            this.labelRol.Name = "labelRol";
            this.labelRol.Size = new System.Drawing.Size(58, 24);
            this.labelRol.TabIndex = 8;
            this.labelRol.Text = "Rol:  ";
            this.labelRol.Click += new System.EventHandler(this.labelRol_Click);
            // 
            // labelNumeUser
            // 
            this.labelNumeUser.AutoSize = true;
            this.labelNumeUser.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNumeUser.ForeColor = System.Drawing.Color.White;
            this.labelNumeUser.Location = new System.Drawing.Point(165, 21);
            this.labelNumeUser.Name = "labelNumeUser";
            this.labelNumeUser.Size = new System.Drawing.Size(100, 24);
            this.labelNumeUser.TabIndex = 7;
            this.labelNumeUser.Text = "Newparts ";
            this.labelNumeUser.Click += new System.EventHandler(this.labelNumeUser_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(175)))));
            this.panel5.Controls.Add(this.labelTime);
            this.panel5.Controls.Add(this.labelRolUser);
            this.panel5.Controls.Add(this.labelRol);
            this.panel5.Controls.Add(this.labelNumeUser);
            this.panel5.Controls.Add(this.labelSalut);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(215, 50);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1069, 100);
            this.panel5.TabIndex = 8;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // labelSalut
            // 
            this.labelSalut.AutoSize = true;
            this.labelSalut.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSalut.ForeColor = System.Drawing.Color.White;
            this.labelSalut.Location = new System.Drawing.Point(35, 22);
            this.labelSalut.Name = "labelSalut";
            this.labelSalut.Size = new System.Drawing.Size(131, 24);
            this.labelSalut.TabIndex = 5;
            this.labelSalut.Text = "Bine ai venit, ";
            this.labelSalut.Click += new System.EventHandler(this.labelSalut_Click);
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Right;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(1019, 0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(50, 50);
            this.button9.TabIndex = 10;
            this.button9.Text = "     ";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // labelFront
            // 
            this.labelFront.AutoSize = true;
            this.labelFront.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFront.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(175)))));
            this.labelFront.Location = new System.Drawing.Point(6, 9);
            this.labelFront.Name = "labelFront";
            this.labelFront.Size = new System.Drawing.Size(378, 32);
            this.labelFront.TabIndex = 5;
            this.labelFront.Text = "   Cabinet Medical Dent Estet";
            this.labelFront.Click += new System.EventHandler(this.labelFront_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.button9);
            this.panel4.Controls.Add(this.labelFront);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(215, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1069, 50);
            this.panel4.TabIndex = 7;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // buttonMeniu
            // 
            this.buttonMeniu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMeniu.FlatAppearance.BorderSize = 0;
            this.buttonMeniu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMeniu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMeniu.ForeColor = System.Drawing.Color.White;
            this.buttonMeniu.Image = ((System.Drawing.Image)(resources.GetObject("buttonMeniu.Image")));
            this.buttonMeniu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMeniu.Location = new System.Drawing.Point(168, 0);
            this.buttonMeniu.Name = "buttonMeniu";
            this.buttonMeniu.Size = new System.Drawing.Size(47, 41);
            this.buttonMeniu.TabIndex = 9;
            this.buttonMeniu.Text = "     ";
            this.buttonMeniu.UseVisualStyleBackColor = true;
            this.buttonMeniu.Click += new System.EventHandler(this.buttonMeniu_Click);
            // 
            // labelNumeCabinet
            // 
            this.labelNumeCabinet.AutoSize = true;
            this.labelNumeCabinet.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNumeCabinet.ForeColor = System.Drawing.Color.White;
            this.labelNumeCabinet.Location = new System.Drawing.Point(73, 118);
            this.labelNumeCabinet.Name = "labelNumeCabinet";
            this.labelNumeCabinet.Size = new System.Drawing.Size(96, 22);
            this.labelNumeCabinet.TabIndex = 7;
            this.labelNumeCabinet.Text = "Dent Estet";
            this.labelNumeCabinet.Click += new System.EventHandler(this.labelNumeCabinet_Click);
            // 
            // labelDenumireCabinet
            // 
            this.labelDenumireCabinet.AutoSize = true;
            this.labelDenumireCabinet.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDenumireCabinet.ForeColor = System.Drawing.Color.White;
            this.labelDenumireCabinet.Location = new System.Drawing.Point(52, 96);
            this.labelDenumireCabinet.Name = "labelDenumireCabinet";
            this.labelDenumireCabinet.Size = new System.Drawing.Size(145, 22);
            this.labelDenumireCabinet.TabIndex = 6;
            this.labelDenumireCabinet.Text = "Cabinet Medical";
            this.labelDenumireCabinet.Click += new System.EventHandler(this.labelDenumireCabinet_Click);
            // 
            // pictBoxLogo
            // 
            this.pictBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictBoxLogo.Image")));
            this.pictBoxLogo.Location = new System.Drawing.Point(70, 12);
            this.pictBoxLogo.Name = "pictBoxLogo";
            this.pictBoxLogo.Size = new System.Drawing.Size(100, 81);
            this.pictBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictBoxLogo.TabIndex = 5;
            this.pictBoxLogo.TabStop = false;
            this.pictBoxLogo.Click += new System.EventHandler(this.pictBoxLogo_Click);
            // 
            // btnLaborator
            // 
            this.btnLaborator.FlatAppearance.BorderSize = 0;
            this.btnLaborator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaborator.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLaborator.ForeColor = System.Drawing.Color.White;
            this.btnLaborator.Image = ((System.Drawing.Image)(resources.GetObject("btnLaborator.Image")));
            this.btnLaborator.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLaborator.Location = new System.Drawing.Point(12, 524);
            this.btnLaborator.Name = "btnLaborator";
            this.btnLaborator.Size = new System.Drawing.Size(200, 50);
            this.btnLaborator.TabIndex = 9;
            this.btnLaborator.Text = "     Laborator";
            this.btnLaborator.UseVisualStyleBackColor = true;
            this.btnLaborator.Click += new System.EventHandler(this.btnLaborator_Click);
            // 
            // btnUtilizatori
            // 
            this.btnUtilizatori.FlatAppearance.BorderSize = 0;
            this.btnUtilizatori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUtilizatori.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUtilizatori.ForeColor = System.Drawing.Color.White;
            this.btnUtilizatori.Image = ((System.Drawing.Image)(resources.GetObject("btnUtilizatori.Image")));
            this.btnUtilizatori.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUtilizatori.Location = new System.Drawing.Point(12, 464);
            this.btnUtilizatori.Name = "btnUtilizatori";
            this.btnUtilizatori.Size = new System.Drawing.Size(200, 50);
            this.btnUtilizatori.TabIndex = 9;
            this.btnUtilizatori.Text = "     Utilizatori";
            this.btnUtilizatori.UseVisualStyleBackColor = true;
            this.btnUtilizatori.Click += new System.EventHandler(this.btnUtilizatori_Click);
            // 
            // btnContabilitate
            // 
            this.btnContabilitate.FlatAppearance.BorderSize = 0;
            this.btnContabilitate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContabilitate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnContabilitate.ForeColor = System.Drawing.Color.White;
            this.btnContabilitate.Image = ((System.Drawing.Image)(resources.GetObject("btnContabilitate.Image")));
            this.btnContabilitate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContabilitate.Location = new System.Drawing.Point(12, 404);
            this.btnContabilitate.Name = "btnContabilitate";
            this.btnContabilitate.Size = new System.Drawing.Size(200, 50);
            this.btnContabilitate.TabIndex = 8;
            this.btnContabilitate.Text = "     Contabilitate";
            this.btnContabilitate.UseVisualStyleBackColor = true;
            this.btnContabilitate.Click += new System.EventHandler(this.btnContabilitate_Click);
            // 
            // btnMedici
            // 
            this.btnMedici.FlatAppearance.BorderSize = 0;
            this.btnMedici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedici.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMedici.ForeColor = System.Drawing.Color.White;
            this.btnMedici.Image = ((System.Drawing.Image)(resources.GetObject("btnMedici.Image")));
            this.btnMedici.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedici.Location = new System.Drawing.Point(12, 224);
            this.btnMedici.Name = "btnMedici";
            this.btnMedici.Size = new System.Drawing.Size(200, 50);
            this.btnMedici.TabIndex = 8;
            this.btnMedici.Text = "     Medici";
            this.btnMedici.UseVisualStyleBackColor = true;
            this.btnMedici.Click += new System.EventHandler(this.btnMedici_Click);
            // 
            // btnPacienti
            // 
            this.btnPacienti.FlatAppearance.BorderSize = 0;
            this.btnPacienti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacienti.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPacienti.ForeColor = System.Drawing.Color.White;
            this.btnPacienti.Image = ((System.Drawing.Image)(resources.GetObject("btnPacienti.Image")));
            this.btnPacienti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPacienti.Location = new System.Drawing.Point(12, 344);
            this.btnPacienti.Name = "btnPacienti";
            this.btnPacienti.Size = new System.Drawing.Size(200, 50);
            this.btnPacienti.TabIndex = 7;
            this.btnPacienti.Text = "     Pacienti";
            this.btnPacienti.UseVisualStyleBackColor = true;
            this.btnPacienti.Click += new System.EventHandler(this.btnPacienti_Click);
            // 
            // btnAsistenti
            // 
            this.btnAsistenti.FlatAppearance.BorderSize = 0;
            this.btnAsistenti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsistenti.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAsistenti.ForeColor = System.Drawing.Color.White;
            this.btnAsistenti.Image = ((System.Drawing.Image)(resources.GetObject("btnAsistenti.Image")));
            this.btnAsistenti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsistenti.Location = new System.Drawing.Point(12, 284);
            this.btnAsistenti.Name = "btnAsistenti";
            this.btnAsistenti.Size = new System.Drawing.Size(200, 50);
            this.btnAsistenti.TabIndex = 6;
            this.btnAsistenti.Text = "       Asistenti";
            this.btnAsistenti.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAsistenti.UseVisualStyleBackColor = true;
            this.btnAsistenti.Click += new System.EventHandler(this.btnAsistenti_Click);
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.White;
            this.panelSide.Location = new System.Drawing.Point(0, 164);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(10, 50);
            this.panelSide.TabIndex = 5;
            this.panelSide.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSide_Paint);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(12, 164);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(200, 50);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "        Acasa";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonMeniu);
            this.panel2.Controls.Add(this.labelNumeCabinet);
            this.panel2.Controls.Add(this.labelDenumireCabinet);
            this.panel2.Controls.Add(this.pictBoxLogo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 150);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(175)))));
            this.panelLeft.Controls.Add(this.btnSetari);
            this.panelLeft.Controls.Add(this.btnFurnizor);
            this.panelLeft.Controls.Add(this.btnLaborator);
            this.panelLeft.Controls.Add(this.btnUtilizatori);
            this.panelLeft.Controls.Add(this.btnContabilitate);
            this.panelLeft.Controls.Add(this.btnMedici);
            this.panelLeft.Controls.Add(this.btnPacienti);
            this.panelLeft.Controls.Add(this.btnAsistenti);
            this.panelLeft.Controls.Add(this.panelSide);
            this.panelLeft.Controls.Add(this.btnHome);
            this.panelLeft.Controls.Add(this.panel2);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(215, 749);
            this.panelLeft.TabIndex = 6;
            this.panelLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLeft_Paint);
            // 
            // btnSetari
            // 
            this.btnSetari.FlatAppearance.BorderSize = 0;
            this.btnSetari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetari.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSetari.ForeColor = System.Drawing.Color.White;
            this.btnSetari.Image = ((System.Drawing.Image)(resources.GetObject("btnSetari.Image")));
            this.btnSetari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetari.Location = new System.Drawing.Point(12, 636);
            this.btnSetari.Name = "btnSetari";
            this.btnSetari.Size = new System.Drawing.Size(200, 50);
            this.btnSetari.TabIndex = 11;
            this.btnSetari.Text = "     Setari";
            this.btnSetari.UseVisualStyleBackColor = true;
            this.btnSetari.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnFurnizor
            // 
            this.btnFurnizor.FlatAppearance.BorderSize = 0;
            this.btnFurnizor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFurnizor.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFurnizor.ForeColor = System.Drawing.Color.White;
            this.btnFurnizor.Image = ((System.Drawing.Image)(resources.GetObject("btnFurnizor.Image")));
            this.btnFurnizor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFurnizor.Location = new System.Drawing.Point(12, 580);
            this.btnFurnizor.Name = "btnFurnizor";
            this.btnFurnizor.Size = new System.Drawing.Size(200, 50);
            this.btnFurnizor.TabIndex = 10;
            this.btnFurnizor.Text = "     Furnizori";
            this.btnFurnizor.UseVisualStyleBackColor = true;
            this.btnFurnizor.Click += new System.EventHandler(this.btnFurnizor_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Registratura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 749);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registratura";
            this.Text = "Registratura";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelRolUser;
        private System.Windows.Forms.Label labelRol;
        private System.Windows.Forms.Label labelNumeUser;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labelSalut;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label labelFront;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonMeniu;
        private System.Windows.Forms.Label labelNumeCabinet;
        private System.Windows.Forms.Label labelDenumireCabinet;
        private System.Windows.Forms.PictureBox pictBoxLogo;
        private System.Windows.Forms.Button btnLaborator;
        private System.Windows.Forms.Button btnUtilizatori;
        private System.Windows.Forms.Button btnContabilitate;
        private System.Windows.Forms.Button btnMedici;
        private System.Windows.Forms.Button btnPacienti;
        private System.Windows.Forms.Button btnAsistenti;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnSetari;
        private System.Windows.Forms.Button btnFurnizor;
    }
}