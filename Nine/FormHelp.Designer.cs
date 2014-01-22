namespace Nine
{
    partial class FormHelp
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.helptextL = new System.Windows.Forms.Label();
            this.closeBU = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // helptextL
            // 
            this.helptextL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.helptextL.AutoEllipsis = true;
            this.helptextL.Location = new System.Drawing.Point(13, 13);
            this.helptextL.Name = "helptextL";
            this.helptextL.Size = new System.Drawing.Size(283, 295);
            this.helptextL.TabIndex = 0;
            this.helptextL.Text = "label1";
            // 
            // closeBU
            // 
            this.closeBU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.closeBU.Location = new System.Drawing.Point(16, 322);
            this.closeBU.Name = "closeBU";
            this.closeBU.Size = new System.Drawing.Size(75, 23);
            this.closeBU.TabIndex = 1;
            this.closeBU.Text = "Schließen";
            this.closeBU.UseVisualStyleBackColor = true;
            this.closeBU.Click += new System.EventHandler(this.closeBU_Click);
            // 
            // FormHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 357);
            this.Controls.Add(this.closeBU);
            this.Controls.Add(this.helptextL);
            this.Name = "FormHelp";
            this.Text = "IX - Hilfe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label helptextL;
        private System.Windows.Forms.Button closeBU;
    }
}