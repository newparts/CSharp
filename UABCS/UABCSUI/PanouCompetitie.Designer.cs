namespace UABCSUI
{
    partial class PanouCompetitie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanouCompetitie));
            this.premiuNou = new System.Windows.Forms.Label();
            this.SelectCompetitieDropDown = new System.Windows.Forms.ComboBox();
            this.competitieActivaLabel = new System.Windows.Forms.Label();
            this.incarcaCompetitie = new System.Windows.Forms.Button();
            this.adaugaCompetitie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // premiuNou
            // 
            this.premiuNou.AutoSize = true;
            this.premiuNou.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.premiuNou.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(175)))));
            this.premiuNou.Location = new System.Drawing.Point(210, 61);
            this.premiuNou.Name = "premiuNou";
            this.premiuNou.Size = new System.Drawing.Size(511, 55);
            this.premiuNou.TabIndex = 14;
            this.premiuNou.Text = "Panou  Competiții UAB";
            this.premiuNou.Click += new System.EventHandler(this.premiuNou_Click);
            // 
            // SelectCompetitieDropDown
            // 
            this.SelectCompetitieDropDown.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SelectCompetitieDropDown.FormattingEnabled = true;
            this.SelectCompetitieDropDown.Location = new System.Drawing.Point(216, 264);
            this.SelectCompetitieDropDown.Name = "SelectCompetitieDropDown";
            this.SelectCompetitieDropDown.Size = new System.Drawing.Size(498, 34);
            this.SelectCompetitieDropDown.TabIndex = 21;
            // 
            // competitieActivaLabel
            // 
            this.competitieActivaLabel.AutoSize = true;
            this.competitieActivaLabel.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.competitieActivaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(175)))));
            this.competitieActivaLabel.Location = new System.Drawing.Point(302, 202);
            this.competitieActivaLabel.Name = "competitieActivaLabel";
            this.competitieActivaLabel.Size = new System.Drawing.Size(326, 42);
            this.competitieActivaLabel.TabIndex = 20;
            this.competitieActivaLabel.Text = "Încarcă Competiție ";
            // 
            // incarcaCompetitie
            // 
            this.incarcaCompetitie.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.incarcaCompetitie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.incarcaCompetitie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.incarcaCompetitie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.incarcaCompetitie.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.incarcaCompetitie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(175)))));
            this.incarcaCompetitie.Location = new System.Drawing.Point(281, 346);
            this.incarcaCompetitie.Name = "incarcaCompetitie";
            this.incarcaCompetitie.Size = new System.Drawing.Size(368, 47);
            this.incarcaCompetitie.TabIndex = 27;
            this.incarcaCompetitie.Text = "Încarcă Competiție Activă";
            this.incarcaCompetitie.UseVisualStyleBackColor = true;
            // 
            // adaugaCompetitie
            // 
            this.adaugaCompetitie.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.adaugaCompetitie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.adaugaCompetitie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.adaugaCompetitie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adaugaCompetitie.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.adaugaCompetitie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(175)))));
            this.adaugaCompetitie.Location = new System.Drawing.Point(192, 443);
            this.adaugaCompetitie.Name = "adaugaCompetitie";
            this.adaugaCompetitie.Size = new System.Drawing.Size(546, 62);
            this.adaugaCompetitie.TabIndex = 28;
            this.adaugaCompetitie.Text = "Adaugă Competiție ";
            this.adaugaCompetitie.UseVisualStyleBackColor = true;
            // 
            // PanouCompetitie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(899, 749);
            this.Controls.Add(this.adaugaCompetitie);
            this.Controls.Add(this.incarcaCompetitie);
            this.Controls.Add(this.SelectCompetitieDropDown);
            this.Controls.Add(this.competitieActivaLabel);
            this.Controls.Add(this.premiuNou);
            this.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "PanouCompetitie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panou Admin Competitie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label premiuNou;
        private System.Windows.Forms.ComboBox SelectCompetitieDropDown;
        private System.Windows.Forms.Label competitieActivaLabel;
        private System.Windows.Forms.Button incarcaCompetitie;
        private System.Windows.Forms.Button adaugaCompetitie;
    }
}