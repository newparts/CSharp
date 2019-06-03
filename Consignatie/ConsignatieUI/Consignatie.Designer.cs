namespace ConsignatieUI
{
    partial class Consignatie
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
            this.headerText = new System.Windows.Forms.Label();
            this.listaProduse = new System.Windows.Forms.ListBox();
            this.produseLabel = new System.Windows.Forms.Label();
            this.adaugaProdusul = new System.Windows.Forms.Button();
            this.listaCosProduse = new System.Windows.Forms.ListBox();
            this.cosProduseLabel = new System.Windows.Forms.Label();
            this.butonComanda = new System.Windows.Forms.Button();
            this.Furnizori = new System.Windows.Forms.Label();
            this.listaFurnizori = new System.Windows.Forms.ListBox();
            this.profitulConsignatiei = new System.Windows.Forms.Label();
            this.profitValoare = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.headerText.Location = new System.Drawing.Point(374, 30);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(383, 73);
            this.headerText.TabIndex = 0;
            this.headerText.Text = "Consignatie";
            // 
            // listaProduse
            // 
            this.listaProduse.FormattingEnabled = true;
            this.listaProduse.ItemHeight = 20;
            this.listaProduse.Location = new System.Drawing.Point(71, 171);
            this.listaProduse.Name = "listaProduse";
            this.listaProduse.Size = new System.Drawing.Size(395, 204);
            this.listaProduse.TabIndex = 1;
            // 
            // produseLabel
            // 
            this.produseLabel.AutoSize = true;
            this.produseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.produseLabel.Location = new System.Drawing.Point(66, 143);
            this.produseLabel.Name = "produseLabel";
            this.produseLabel.Size = new System.Drawing.Size(190, 25);
            this.produseLabel.TabIndex = 2;
            this.produseLabel.Text = "Lista de Produse";
            this.produseLabel.Click += new System.EventHandler(this.produseLabel_Click);
            // 
            // adaugaProdusul
            // 
            this.adaugaProdusul.Location = new System.Drawing.Point(486, 253);
            this.adaugaProdusul.Name = "adaugaProdusul";
            this.adaugaProdusul.Size = new System.Drawing.Size(144, 35);
            this.adaugaProdusul.TabIndex = 3;
            this.adaugaProdusul.Text = "Adauga in Cos";
            this.adaugaProdusul.UseVisualStyleBackColor = true;
            this.adaugaProdusul.Click += new System.EventHandler(this.adaugaProdusul_Click);
            // 
            // listaCosProduse
            // 
            this.listaCosProduse.FormattingEnabled = true;
            this.listaCosProduse.ItemHeight = 20;
            this.listaCosProduse.Location = new System.Drawing.Point(651, 171);
            this.listaCosProduse.Name = "listaCosProduse";
            this.listaCosProduse.Size = new System.Drawing.Size(472, 204);
            this.listaCosProduse.TabIndex = 4;
            // 
            // cosProduseLabel
            // 
            this.cosProduseLabel.AutoSize = true;
            this.cosProduseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cosProduseLabel.Location = new System.Drawing.Point(646, 143);
            this.cosProduseLabel.Name = "cosProduseLabel";
            this.cosProduseLabel.Size = new System.Drawing.Size(240, 25);
            this.cosProduseLabel.TabIndex = 5;
            this.cosProduseLabel.Text = "Cosul de Cumparaturi";
            // 
            // butonComanda
            // 
            this.butonComanda.Location = new System.Drawing.Point(979, 381);
            this.butonComanda.Name = "butonComanda";
            this.butonComanda.Size = new System.Drawing.Size(144, 35);
            this.butonComanda.TabIndex = 6;
            this.butonComanda.Text = "Comanda";
            this.butonComanda.UseVisualStyleBackColor = true;
            this.butonComanda.Click += new System.EventHandler(this.butonComanda_Click);
            // 
            // Furnizori
            // 
            this.Furnizori.AutoSize = true;
            this.Furnizori.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Furnizori.Location = new System.Drawing.Point(66, 428);
            this.Furnizori.Name = "Furnizori";
            this.Furnizori.Size = new System.Drawing.Size(196, 25);
            this.Furnizori.TabIndex = 8;
            this.Furnizori.Text = "Lista de Furnizori";
            // 
            // listaFurnizori
            // 
            this.listaFurnizori.FormattingEnabled = true;
            this.listaFurnizori.ItemHeight = 20;
            this.listaFurnizori.Location = new System.Drawing.Point(71, 456);
            this.listaFurnizori.Name = "listaFurnizori";
            this.listaFurnizori.Size = new System.Drawing.Size(395, 204);
            this.listaFurnizori.TabIndex = 7;
            // 
            // profitulConsignatiei
            // 
            this.profitulConsignatiei.AutoSize = true;
            this.profitulConsignatiei.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.profitulConsignatiei.Location = new System.Drawing.Point(661, 456);
            this.profitulConsignatiei.Name = "profitulConsignatiei";
            this.profitulConsignatiei.Size = new System.Drawing.Size(225, 25);
            this.profitulConsignatiei.TabIndex = 9;
            this.profitulConsignatiei.Text = "Profitul Consignatiei";
            // 
            // profitValoare
            // 
            this.profitValoare.AutoSize = true;
            this.profitValoare.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.profitValoare.Location = new System.Drawing.Point(927, 456);
            this.profitValoare.Name = "profitValoare";
            this.profitValoare.Size = new System.Drawing.Size(97, 25);
            this.profitValoare.TabIndex = 10;
            this.profitValoare.Text = "0.00 Lei";
            // 
            // Consignatie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.profitValoare);
            this.Controls.Add(this.profitulConsignatiei);
            this.Controls.Add(this.Furnizori);
            this.Controls.Add(this.listaFurnizori);
            this.Controls.Add(this.butonComanda);
            this.Controls.Add(this.cosProduseLabel);
            this.Controls.Add(this.listaCosProduse);
            this.Controls.Add(this.adaugaProdusul);
            this.Controls.Add(this.produseLabel);
            this.Controls.Add(this.listaProduse);
            this.Controls.Add(this.headerText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Consignatie";
            this.Text = "Consignatie";
            this.Load += new System.EventHandler(this.Consignatie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.ListBox listaProduse;
        private System.Windows.Forms.Label produseLabel;
        private System.Windows.Forms.Button adaugaProdusul;
        private System.Windows.Forms.ListBox listaCosProduse;
        private System.Windows.Forms.Label cosProduseLabel;
        private System.Windows.Forms.Button butonComanda;
        private System.Windows.Forms.Label Furnizori;
        private System.Windows.Forms.ListBox listaFurnizori;
        private System.Windows.Forms.Label profitulConsignatiei;
        private System.Windows.Forms.Label profitValoare;
    }
}

