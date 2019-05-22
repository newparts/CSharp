namespace UABCSUI
{
    partial class stergeEchipa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stergeEchipa));
            this.headerLabel = new System.Windows.Forms.Label();
            this.competitieNouaValoare = new System.Windows.Forms.TextBox();
            this.numeleCompetitiei = new System.Windows.Forms.Label();
            this.taxaValue = new System.Windows.Forms.TextBox();
            this.taxaParticipare = new System.Windows.Forms.Label();
            this.selectEchipaDropDown = new System.Windows.Forms.ComboBox();
            this.roundLabel = new System.Windows.Forms.Label();
            this.creazaEchipaNouaLink = new System.Windows.Forms.LinkLabel();
            this.adaugaEchipaButon = new System.Windows.Forms.Button();
            this.peremiiButton = new System.Windows.Forms.Button();
            this.competitieListBox = new System.Windows.Forms.ListBox();
            this.echipelabel = new System.Windows.Forms.Label();
            this.stergeEchipaJucator = new System.Windows.Forms.Button();
            this.stergePremiu = new System.Windows.Forms.Button();
            this.premiilabel = new System.Windows.Forms.Label();
            this.listaPremii = new System.Windows.Forms.ListBox();
            this.salveazaComeptitieNouaAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(175)))));
            this.headerLabel.Location = new System.Drawing.Point(219, 52);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(372, 55);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Competiție Nouă";
            // 
            // competitieNouaValoare
            // 
            this.competitieNouaValoare.Location = new System.Drawing.Point(79, 184);
            this.competitieNouaValoare.Name = "competitieNouaValoare";
            this.competitieNouaValoare.Size = new System.Drawing.Size(498, 48);
            this.competitieNouaValoare.TabIndex = 11;
            this.competitieNouaValoare.TextChanged += new System.EventHandler(this.scorPrimaEchipa_TextChanged);
            // 
            // numeleCompetitiei
            // 
            this.numeleCompetitiei.AutoSize = true;
            this.numeleCompetitiei.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numeleCompetitiei.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(175)))));
            this.numeleCompetitiei.Location = new System.Drawing.Point(73, 140);
            this.numeleCompetitiei.Name = "numeleCompetitiei";
            this.numeleCompetitiei.Size = new System.Drawing.Size(247, 31);
            this.numeleCompetitiei.TabIndex = 10;
            this.numeleCompetitiei.Text = "Numele Competiției";
            this.numeleCompetitiei.Click += new System.EventHandler(this.scorulPrimeiEchipe_Click);
            // 
            // taxaValue
            // 
            this.taxaValue.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.taxaValue.Location = new System.Drawing.Point(432, 281);
            this.taxaValue.Name = "taxaValue";
            this.taxaValue.Size = new System.Drawing.Size(145, 29);
            this.taxaValue.TabIndex = 13;
            this.taxaValue.Text = "0";
            // 
            // taxaParticipare
            // 
            this.taxaParticipare.AutoSize = true;
            this.taxaParticipare.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.taxaParticipare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(175)))));
            this.taxaParticipare.Location = new System.Drawing.Point(73, 281);
            this.taxaParticipare.Name = "taxaParticipare";
            this.taxaParticipare.Size = new System.Drawing.Size(211, 31);
            this.taxaParticipare.TabIndex = 12;
            this.taxaParticipare.Text = "Taxa Participare";
            // 
            // selectEchipaDropDown
            // 
            this.selectEchipaDropDown.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectEchipaDropDown.FormattingEnabled = true;
            this.selectEchipaDropDown.Location = new System.Drawing.Point(79, 442);
            this.selectEchipaDropDown.Name = "selectEchipaDropDown";
            this.selectEchipaDropDown.Size = new System.Drawing.Size(498, 34);
            this.selectEchipaDropDown.TabIndex = 15;
            this.selectEchipaDropDown.SelectedIndexChanged += new System.EventHandler(this.selectEchipaDropDown_SelectedIndexChanged);
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.roundLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(175)))));
            this.roundLabel.Location = new System.Drawing.Point(72, 376);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(298, 42);
            this.roundLabel.TabIndex = 14;
            this.roundLabel.Text = "Selectează Echipa";
            this.roundLabel.Click += new System.EventHandler(this.roundLabel_Click);
            // 
            // creazaEchipaNouaLink
            // 
            this.creazaEchipaNouaLink.AutoSize = true;
            this.creazaEchipaNouaLink.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.creazaEchipaNouaLink.Location = new System.Drawing.Point(436, 385);
            this.creazaEchipaNouaLink.Name = "creazaEchipaNouaLink";
            this.creazaEchipaNouaLink.Size = new System.Drawing.Size(141, 31);
            this.creazaEchipaNouaLink.TabIndex = 16;
            this.creazaEchipaNouaLink.TabStop = true;
            this.creazaEchipaNouaLink.Text = "linkLabel1";
            this.creazaEchipaNouaLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.creazaEchipaNouaLink_LinkClicked);
            // 
            // adaugaEchipaButon
            // 
            this.adaugaEchipaButon.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.adaugaEchipaButon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.adaugaEchipaButon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.adaugaEchipaButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adaugaEchipaButon.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.adaugaEchipaButon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(175)))));
            this.adaugaEchipaButon.Location = new System.Drawing.Point(229, 530);
            this.adaugaEchipaButon.Name = "adaugaEchipaButon";
            this.adaugaEchipaButon.Size = new System.Drawing.Size(237, 45);
            this.adaugaEchipaButon.TabIndex = 17;
            this.adaugaEchipaButon.Text = "Adaugă Echipa";
            this.adaugaEchipaButon.UseVisualStyleBackColor = true;
            this.adaugaEchipaButon.Click += new System.EventHandler(this.adaugaEchipaButon_Click);
            // 
            // peremiiButton
            // 
            this.peremiiButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.peremiiButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.peremiiButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.peremiiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.peremiiButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.peremiiButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(175)))));
            this.peremiiButton.Location = new System.Drawing.Point(229, 609);
            this.peremiiButton.Name = "peremiiButton";
            this.peremiiButton.Size = new System.Drawing.Size(237, 45);
            this.peremiiButton.TabIndex = 18;
            this.peremiiButton.Text = "Alege Premii";
            this.peremiiButton.UseVisualStyleBackColor = true;
            this.peremiiButton.Click += new System.EventHandler(this.peremiiButton_Click);
            // 
            // competitieListBox
            // 
            this.competitieListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.competitieListBox.FormattingEnabled = true;
            this.competitieListBox.ItemHeight = 40;
            this.competitieListBox.Location = new System.Drawing.Point(636, 184);
            this.competitieListBox.Name = "competitieListBox";
            this.competitieListBox.Size = new System.Drawing.Size(421, 202);
            this.competitieListBox.TabIndex = 19;
            // 
            // echipelabel
            // 
            this.echipelabel.AutoSize = true;
            this.echipelabel.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.echipelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(175)))));
            this.echipelabel.Location = new System.Drawing.Point(731, 140);
            this.echipelabel.Name = "echipelabel";
            this.echipelabel.Size = new System.Drawing.Size(228, 31);
            this.echipelabel.TabIndex = 20;
            this.echipelabel.Text = "Echipe / Jucători  ";
            // 
            // stergeEchipaJucator
            // 
            this.stergeEchipaJucator.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.stergeEchipaJucator.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.stergeEchipaJucator.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.stergeEchipaJucator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stergeEchipaJucator.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stergeEchipaJucator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(175)))));
            this.stergeEchipaJucator.Location = new System.Drawing.Point(1126, 234);
            this.stergeEchipaJucator.Name = "stergeEchipaJucator";
            this.stergeEchipaJucator.Size = new System.Drawing.Size(129, 90);
            this.stergeEchipaJucator.TabIndex = 21;
            this.stergeEchipaJucator.Text = "Sterge Echipa Jucator";
            this.stergeEchipaJucator.UseVisualStyleBackColor = true;
            // 
            // stergePremiu
            // 
            this.stergePremiu.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.stergePremiu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.stergePremiu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.stergePremiu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stergePremiu.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stergePremiu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(175)))));
            this.stergePremiu.Location = new System.Drawing.Point(1126, 577);
            this.stergePremiu.Name = "stergePremiu";
            this.stergePremiu.Size = new System.Drawing.Size(117, 77);
            this.stergePremiu.TabIndex = 24;
            this.stergePremiu.Text = "Sterge Premiu";
            this.stergePremiu.UseVisualStyleBackColor = true;
            // 
            // premiilabel
            // 
            this.premiilabel.AutoSize = true;
            this.premiilabel.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.premiilabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(175)))));
            this.premiilabel.Location = new System.Drawing.Point(810, 445);
            this.premiilabel.Name = "premiilabel";
            this.premiilabel.Size = new System.Drawing.Size(93, 31);
            this.premiilabel.TabIndex = 23;
            this.premiilabel.Text = "Premii";
            // 
            // listaPremii
            // 
            this.listaPremii.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listaPremii.FormattingEnabled = true;
            this.listaPremii.ItemHeight = 40;
            this.listaPremii.Location = new System.Drawing.Point(636, 511);
            this.listaPremii.Name = "listaPremii";
            this.listaPremii.Size = new System.Drawing.Size(421, 202);
            this.listaPremii.TabIndex = 22;
            // 
            // salveazaComeptitieNouaAdd
            // 
            this.salveazaComeptitieNouaAdd.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.salveazaComeptitieNouaAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.salveazaComeptitieNouaAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.salveazaComeptitieNouaAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salveazaComeptitieNouaAdd.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.salveazaComeptitieNouaAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(175)))));
            this.salveazaComeptitieNouaAdd.Location = new System.Drawing.Point(79, 683);
            this.salveazaComeptitieNouaAdd.Name = "salveazaComeptitieNouaAdd";
            this.salveazaComeptitieNouaAdd.Size = new System.Drawing.Size(498, 45);
            this.salveazaComeptitieNouaAdd.TabIndex = 25;
            this.salveazaComeptitieNouaAdd.Text = "Salvează Competiția Nouă";
            this.salveazaComeptitieNouaAdd.UseVisualStyleBackColor = true;
            // 
            // stergeEchipa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1294, 749);
            this.Controls.Add(this.salveazaComeptitieNouaAdd);
            this.Controls.Add(this.stergePremiu);
            this.Controls.Add(this.premiilabel);
            this.Controls.Add(this.listaPremii);
            this.Controls.Add(this.stergeEchipaJucator);
            this.Controls.Add(this.echipelabel);
            this.Controls.Add(this.competitieListBox);
            this.Controls.Add(this.peremiiButton);
            this.Controls.Add(this.adaugaEchipaButon);
            this.Controls.Add(this.creazaEchipaNouaLink);
            this.Controls.Add(this.selectEchipaDropDown);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.taxaValue);
            this.Controls.Add(this.taxaParticipare);
            this.Controls.Add(this.competitieNouaValoare);
            this.Controls.Add(this.numeleCompetitiei);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "stergeEchipa";
            this.Text = "Adauga Competitie Noua";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox competitieNouaValoare;
        private System.Windows.Forms.Label numeleCompetitiei;
        private System.Windows.Forms.TextBox taxaValue;
        private System.Windows.Forms.Label taxaParticipare;
        private System.Windows.Forms.ComboBox selectEchipaDropDown;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.LinkLabel creazaEchipaNouaLink;
        private System.Windows.Forms.Button adaugaEchipaButon;
        private System.Windows.Forms.Button peremiiButton;
        private System.Windows.Forms.ListBox competitieListBox;
        private System.Windows.Forms.Label echipelabel;
        private System.Windows.Forms.Button stergeEchipaJucator;
        private System.Windows.Forms.Button stergePremiu;
        private System.Windows.Forms.Label premiilabel;
        private System.Windows.Forms.ListBox listaPremii;
        private System.Windows.Forms.Button salveazaComeptitieNouaAdd;
    }
}