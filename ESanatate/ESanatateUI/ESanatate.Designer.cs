namespace ESanatateUI
{
    partial class EsanatateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EsanatateForm));
            this.numeCabinet = new System.Windows.Forms.Label();
            this.panelBackground = new System.Windows.Forms.Panel();
            this.buttonProgramari = new System.Windows.Forms.Button();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numeCabinet
            // 
            this.numeCabinet.AutoSize = true;
            this.numeCabinet.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numeCabinet.Location = new System.Drawing.Point(380, 33);
            this.numeCabinet.Name = "numeCabinet";
            this.numeCabinet.Size = new System.Drawing.Size(374, 55);
            this.numeCabinet.TabIndex = 0;
            this.numeCabinet.Text = "Cabinet Medical ";
            // 
            // panelBackground
            // 
            this.panelBackground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelBackground.BackgroundImage")));
            this.panelBackground.Location = new System.Drawing.Point(50, 120);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(1088, 444);
            this.panelBackground.TabIndex = 1;
            // 
            // buttonProgramari
            // 
            this.buttonProgramari.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonProgramari.Location = new System.Drawing.Point(194, 587);
            this.buttonProgramari.Name = "buttonProgramari";
            this.buttonProgramari.Size = new System.Drawing.Size(300, 100);
            this.buttonProgramari.TabIndex = 2;
            this.buttonProgramari.Text = "Programari";
            this.buttonProgramari.UseVisualStyleBackColor = true;
            this.buttonProgramari.Click += new System.EventHandler(this.buttonProgramari_Click);
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAdmin.Location = new System.Drawing.Point(721, 587);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(300, 100);
            this.buttonAdmin.TabIndex = 3;
            this.buttonAdmin.Text = "Administrare";
            this.buttonAdmin.UseVisualStyleBackColor = true;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // EsanatateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 749);
            this.Controls.Add(this.buttonAdmin);
            this.Controls.Add(this.buttonProgramari);
            this.Controls.Add(this.panelBackground);
            this.Controls.Add(this.numeCabinet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EsanatateForm";
            this.Text = "ESanatate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numeCabinet;
        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Button buttonProgramari;
        private System.Windows.Forms.Button buttonAdmin;
    }
}

