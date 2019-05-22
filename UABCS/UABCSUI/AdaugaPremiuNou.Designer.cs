namespace UABCSUI
{
    partial class AdaugaPremiuNou
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdaugaPremiuNou));
            this.premiuNou = new System.Windows.Forms.Label();
            this.loculOcupatValue = new System.Windows.Forms.TextBox();
            this.loculOcupatLabel = new System.Windows.Forms.Label();
            this.numeleLoculuiValue = new System.Windows.Forms.TextBox();
            this.numeleLocului = new System.Windows.Forms.Label();
            this.valoarePremiuValue = new System.Windows.Forms.TextBox();
            this.valoarePremiu = new System.Windows.Forms.Label();
            this.procentPremiuValue = new System.Windows.Forms.TextBox();
            this.procentPremiu = new System.Windows.Forms.Label();
            this.sauLabel = new System.Windows.Forms.Label();
            this.salveazaPremiuNou = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // premiuNou
            // 
            this.premiuNou.AutoSize = true;
            this.premiuNou.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.premiuNou.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(175)))));
            this.premiuNou.Location = new System.Drawing.Point(139, 44);
            this.premiuNou.Name = "premiuNou";
            this.premiuNou.Size = new System.Drawing.Size(271, 55);
            this.premiuNou.TabIndex = 13;
            this.premiuNou.Text = "Premiu Nou";
            // 
            // loculOcupatValue
            // 
            this.loculOcupatValue.Location = new System.Drawing.Point(257, 146);
            this.loculOcupatValue.Name = "loculOcupatValue";
            this.loculOcupatValue.Size = new System.Drawing.Size(328, 39);
            this.loculOcupatValue.TabIndex = 15;
            this.loculOcupatValue.TextChanged += new System.EventHandler(this.numeValue_TextChanged);
            // 
            // loculOcupatLabel
            // 
            this.loculOcupatLabel.AutoSize = true;
            this.loculOcupatLabel.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loculOcupatLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(175)))));
            this.loculOcupatLabel.Location = new System.Drawing.Point(33, 149);
            this.loculOcupatLabel.Name = "loculOcupatLabel";
            this.loculOcupatLabel.Size = new System.Drawing.Size(174, 31);
            this.loculOcupatLabel.TabIndex = 14;
            this.loculOcupatLabel.Text = "Locul Ocupat";
            // 
            // numeleLoculuiValue
            // 
            this.numeleLoculuiValue.Location = new System.Drawing.Point(257, 225);
            this.numeleLoculuiValue.Name = "numeleLoculuiValue";
            this.numeleLoculuiValue.Size = new System.Drawing.Size(328, 39);
            this.numeleLoculuiValue.TabIndex = 17;
            // 
            // numeleLocului
            // 
            this.numeleLocului.AutoSize = true;
            this.numeleLocului.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numeleLocului.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(175)))));
            this.numeleLocului.Location = new System.Drawing.Point(33, 228);
            this.numeleLocului.Name = "numeleLocului";
            this.numeleLocului.Size = new System.Drawing.Size(200, 31);
            this.numeleLocului.TabIndex = 16;
            this.numeleLocului.Text = "Numele Locului";
            // 
            // valoarePremiuValue
            // 
            this.valoarePremiuValue.Location = new System.Drawing.Point(257, 311);
            this.valoarePremiuValue.Name = "valoarePremiuValue";
            this.valoarePremiuValue.Size = new System.Drawing.Size(328, 39);
            this.valoarePremiuValue.TabIndex = 19;
            this.valoarePremiuValue.Text = "0";
            // 
            // valoarePremiu
            // 
            this.valoarePremiu.AutoSize = true;
            this.valoarePremiu.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.valoarePremiu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(175)))));
            this.valoarePremiu.Location = new System.Drawing.Point(33, 314);
            this.valoarePremiu.Name = "valoarePremiu";
            this.valoarePremiu.Size = new System.Drawing.Size(198, 31);
            this.valoarePremiu.TabIndex = 18;
            this.valoarePremiu.Text = "Valoare Premiu";
            // 
            // procentPremiuValue
            // 
            this.procentPremiuValue.Location = new System.Drawing.Point(257, 468);
            this.procentPremiuValue.Name = "procentPremiuValue";
            this.procentPremiuValue.Size = new System.Drawing.Size(328, 39);
            this.procentPremiuValue.TabIndex = 21;
            this.procentPremiuValue.Text = "0";
            // 
            // procentPremiu
            // 
            this.procentPremiu.AutoSize = true;
            this.procentPremiu.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.procentPremiu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(175)))));
            this.procentPremiu.Location = new System.Drawing.Point(33, 471);
            this.procentPremiu.Name = "procentPremiu";
            this.procentPremiu.Size = new System.Drawing.Size(198, 31);
            this.procentPremiu.TabIndex = 20;
            this.procentPremiu.Text = "Procent Premiu";
            // 
            // sauLabel
            // 
            this.sauLabel.AutoSize = true;
            this.sauLabel.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sauLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(175)))));
            this.sauLabel.Location = new System.Drawing.Point(278, 393);
            this.sauLabel.Name = "sauLabel";
            this.sauLabel.Size = new System.Drawing.Size(54, 31);
            this.sauLabel.TabIndex = 22;
            this.sauLabel.Text = "sau";
            this.sauLabel.Click += new System.EventHandler(this.sauLabel_Click);
            // 
            // salveazaPremiuNou
            // 
            this.salveazaPremiuNou.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.salveazaPremiuNou.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.salveazaPremiuNou.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.salveazaPremiuNou.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salveazaPremiuNou.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.salveazaPremiuNou.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(175)))));
            this.salveazaPremiuNou.Location = new System.Drawing.Point(39, 617);
            this.salveazaPremiuNou.Name = "salveazaPremiuNou";
            this.salveazaPremiuNou.Size = new System.Drawing.Size(546, 62);
            this.salveazaPremiuNou.TabIndex = 27;
            this.salveazaPremiuNou.Text = "Salvează Premiu Nou";
            this.salveazaPremiuNou.UseVisualStyleBackColor = true;
            this.salveazaPremiuNou.Click += new System.EventHandler(this.salveazaPremiuNou_Click);
            // 
            // AdaugaPremiuNou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(727, 749);
            this.Controls.Add(this.salveazaPremiuNou);
            this.Controls.Add(this.sauLabel);
            this.Controls.Add(this.procentPremiuValue);
            this.Controls.Add(this.procentPremiu);
            this.Controls.Add(this.valoarePremiuValue);
            this.Controls.Add(this.valoarePremiu);
            this.Controls.Add(this.numeleLoculuiValue);
            this.Controls.Add(this.numeleLocului);
            this.Controls.Add(this.loculOcupatValue);
            this.Controls.Add(this.loculOcupatLabel);
            this.Controls.Add(this.premiuNou);
            this.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "AdaugaPremiuNou";
            this.Text = "Adauga Premiu Nou";
            this.Load += new System.EventHandler(this.AdaugaPremiuNou_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label premiuNou;
        private System.Windows.Forms.TextBox loculOcupatValue;
        private System.Windows.Forms.Label loculOcupatLabel;
        private System.Windows.Forms.TextBox numeleLoculuiValue;
        private System.Windows.Forms.Label numeleLocului;
        private System.Windows.Forms.TextBox valoarePremiuValue;
        private System.Windows.Forms.Label valoarePremiu;
        private System.Windows.Forms.TextBox procentPremiuValue;
        private System.Windows.Forms.Label procentPremiu;
        private System.Windows.Forms.Label sauLabel;
        private System.Windows.Forms.Button salveazaPremiuNou;
    }
}