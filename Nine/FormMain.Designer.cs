namespace Nine
{
    partial class FormMain
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.l8 = new System.Windows.Forms.Label();
            this.l6 = new System.Windows.Forms.Label();
            this.l7 = new System.Windows.Forms.Label();
            this.l4 = new System.Windows.Forms.Label();
            this.l5 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.l0 = new System.Windows.Forms.Label();
            this.l1 = new System.Windows.Forms.Label();
            this.guessedWordsLB = new System.Windows.Forms.ListBox();
            this.newGameBU = new System.Windows.Forms.Button();
            this.exitGameBU = new System.Windows.Forms.Button();
            this.guessTB = new System.Windows.Forms.TextBox();
            this.solveBU = new System.Windows.Forms.Button();
            this.ptsL = new System.Windows.Forms.Label();
            this.helpBU = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33553F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33223F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33223F));
            this.tableLayoutPanel1.Controls.Add(this.l8, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.l6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.l7, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.l4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.l5, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.l2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.l3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.l0, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.l1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33533F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33233F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33233F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(268, 225);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // l8
            // 
            this.l8.AutoSize = true;
            this.l8.BackColor = System.Drawing.Color.White;
            this.l8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.l8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l8.Font = new System.Drawing.Font("Lucida Console", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l8.Location = new System.Drawing.Point(178, 149);
            this.l8.Margin = new System.Windows.Forms.Padding(0);
            this.l8.Name = "l8";
            this.l8.Size = new System.Drawing.Size(90, 76);
            this.l8.TabIndex = 8;
            this.l8.Text = "X";
            this.l8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l8.Click += new System.EventHandler(this.NewWord_Click);
            // 
            // l6
            // 
            this.l6.AutoSize = true;
            this.l6.BackColor = System.Drawing.Color.White;
            this.l6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.l6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l6.Font = new System.Drawing.Font("Lucida Console", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l6.Location = new System.Drawing.Point(0, 149);
            this.l6.Margin = new System.Windows.Forms.Padding(0);
            this.l6.Name = "l6";
            this.l6.Size = new System.Drawing.Size(89, 76);
            this.l6.TabIndex = 6;
            this.l6.Text = "X";
            this.l6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l6.Click += new System.EventHandler(this.NewWord_Click);
            // 
            // l7
            // 
            this.l7.AutoSize = true;
            this.l7.BackColor = System.Drawing.Color.White;
            this.l7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.l7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l7.Font = new System.Drawing.Font("Lucida Console", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l7.Location = new System.Drawing.Point(89, 149);
            this.l7.Margin = new System.Windows.Forms.Padding(0);
            this.l7.Name = "l7";
            this.l7.Size = new System.Drawing.Size(89, 76);
            this.l7.TabIndex = 7;
            this.l7.Text = "X";
            this.l7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l7.Click += new System.EventHandler(this.NewWord_Click);
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.BackColor = System.Drawing.Color.Gold;
            this.l4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.l4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l4.Font = new System.Drawing.Font("Lucida Console", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l4.Location = new System.Drawing.Point(89, 75);
            this.l4.Margin = new System.Windows.Forms.Padding(0);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(89, 74);
            this.l4.TabIndex = 4;
            this.l4.Text = "X";
            this.l4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l4.Click += new System.EventHandler(this.NewWord_Click);
            // 
            // l5
            // 
            this.l5.AutoSize = true;
            this.l5.BackColor = System.Drawing.Color.White;
            this.l5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.l5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l5.Font = new System.Drawing.Font("Lucida Console", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l5.Location = new System.Drawing.Point(178, 75);
            this.l5.Margin = new System.Windows.Forms.Padding(0);
            this.l5.Name = "l5";
            this.l5.Size = new System.Drawing.Size(90, 74);
            this.l5.TabIndex = 5;
            this.l5.Text = "X";
            this.l5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l5.Click += new System.EventHandler(this.NewWord_Click);
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.BackColor = System.Drawing.Color.White;
            this.l2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.l2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l2.Font = new System.Drawing.Font("Lucida Console", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2.Location = new System.Drawing.Point(178, 0);
            this.l2.Margin = new System.Windows.Forms.Padding(0);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(90, 75);
            this.l2.TabIndex = 2;
            this.l2.Text = "X";
            this.l2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l2.Click += new System.EventHandler(this.NewWord_Click);
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.BackColor = System.Drawing.Color.White;
            this.l3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.l3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l3.Font = new System.Drawing.Font("Lucida Console", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l3.Location = new System.Drawing.Point(0, 75);
            this.l3.Margin = new System.Windows.Forms.Padding(0);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(89, 74);
            this.l3.TabIndex = 3;
            this.l3.Text = "X";
            this.l3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l3.Click += new System.EventHandler(this.NewWord_Click);
            // 
            // l0
            // 
            this.l0.AutoSize = true;
            this.l0.BackColor = System.Drawing.Color.White;
            this.l0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.l0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l0.Font = new System.Drawing.Font("Lucida Console", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l0.Location = new System.Drawing.Point(0, 0);
            this.l0.Margin = new System.Windows.Forms.Padding(0);
            this.l0.Name = "l0";
            this.l0.Size = new System.Drawing.Size(89, 75);
            this.l0.TabIndex = 0;
            this.l0.Text = "X";
            this.l0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l0.Click += new System.EventHandler(this.NewWord_Click);
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.BackColor = System.Drawing.Color.White;
            this.l1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.l1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l1.Font = new System.Drawing.Font("Lucida Console", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1.Location = new System.Drawing.Point(89, 0);
            this.l1.Margin = new System.Windows.Forms.Padding(0);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(89, 75);
            this.l1.TabIndex = 1;
            this.l1.Text = "X";
            this.l1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l1.Click += new System.EventHandler(this.NewWord_Click);
            // 
            // guessedWordsLB
            // 
            this.guessedWordsLB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.guessedWordsLB.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessedWordsLB.FormattingEnabled = true;
            this.guessedWordsLB.Location = new System.Drawing.Point(288, 12);
            this.guessedWordsLB.Name = "guessedWordsLB";
            this.guessedWordsLB.Size = new System.Drawing.Size(183, 225);
            this.guessedWordsLB.TabIndex = 1;
            // 
            // newGameBU
            // 
            this.newGameBU.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGameBU.Location = new System.Drawing.Point(12, 287);
            this.newGameBU.Name = "newGameBU";
            this.newGameBU.Size = new System.Drawing.Size(113, 23);
            this.newGameBU.TabIndex = 2;
            this.newGameBU.Text = "Neues Wort";
            this.newGameBU.UseVisualStyleBackColor = true;
            this.newGameBU.Click += new System.EventHandler(this.newGameBU_Click);
            // 
            // exitGameBU
            // 
            this.exitGameBU.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitGameBU.Location = new System.Drawing.Point(12, 316);
            this.exitGameBU.Name = "exitGameBU";
            this.exitGameBU.Size = new System.Drawing.Size(113, 23);
            this.exitGameBU.TabIndex = 3;
            this.exitGameBU.Text = "Beenden";
            this.exitGameBU.UseVisualStyleBackColor = true;
            this.exitGameBU.Click += new System.EventHandler(this.exitGameBU_Click);
            // 
            // guessTB
            // 
            this.guessTB.AcceptsReturn = true;
            this.guessTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.guessTB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.guessTB.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessTB.Location = new System.Drawing.Point(13, 244);
            this.guessTB.MaxLength = 9;
            this.guessTB.Name = "guessTB";
            this.guessTB.Size = new System.Drawing.Size(267, 31);
            this.guessTB.TabIndex = 0;
            this.guessTB.TextChanged += new System.EventHandler(this.guessTB_TextChanged);
            this.guessTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.guessTB_KeyDown);
            this.guessTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.guessTB_KeyPress);
            this.guessTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.guessTB_KeyUp);
            // 
            // solveBU
            // 
            this.solveBU.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solveBU.Location = new System.Drawing.Point(151, 316);
            this.solveBU.Name = "solveBU";
            this.solveBU.Size = new System.Drawing.Size(108, 23);
            this.solveBU.TabIndex = 4;
            this.solveBU.Text = "Lösung";
            this.solveBU.UseVisualStyleBackColor = true;
            this.solveBU.Click += new System.EventHandler(this.solveBU_Click);
            // 
            // ptsL
            // 
            this.ptsL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ptsL.Font = new System.Drawing.Font("Lucida Console", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptsL.Location = new System.Drawing.Point(288, 244);
            this.ptsL.Name = "ptsL";
            this.ptsL.Size = new System.Drawing.Size(183, 55);
            this.ptsL.TabIndex = 7;
            this.ptsL.Text = "000";
            this.ptsL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // helpBU
            // 
            this.helpBU.Location = new System.Drawing.Point(296, 315);
            this.helpBU.Name = "helpBU";
            this.helpBU.Size = new System.Drawing.Size(114, 23);
            this.helpBU.TabIndex = 8;
            this.helpBU.Text = "Hilfe";
            this.helpBU.UseVisualStyleBackColor = true;
            this.helpBU.Click += new System.EventHandler(this.helpBU_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 353);
            this.Controls.Add(this.helpBU);
            this.Controls.Add(this.ptsL);
            this.Controls.Add(this.solveBU);
            this.Controls.Add(this.guessTB);
            this.Controls.Add(this.exitGameBU);
            this.Controls.Add(this.newGameBU);
            this.Controls.Add(this.guessedWordsLB);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormMain";
            this.Text = "IX";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label l8;
        private System.Windows.Forms.Label l6;
        private System.Windows.Forms.Label l7;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.Label l5;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label l0;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.ListBox guessedWordsLB;
        private System.Windows.Forms.Button newGameBU;
        private System.Windows.Forms.Button exitGameBU;
        private System.Windows.Forms.TextBox guessTB;
        private System.Windows.Forms.Button solveBU;
        private System.Windows.Forms.Label ptsL;
        private System.Windows.Forms.Button helpBU;
    }
}

