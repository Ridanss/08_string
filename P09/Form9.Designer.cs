namespace P09
{
    partial class Form9
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonCorrect = new System.Windows.Forms.Button();
            this.checkBoxDot = new System.Windows.Forms.CheckBox();
            this.checkBoxUpper = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 32);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(389, 198);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "no tak to ne....\r\nA\r\nje to no...\r\nale neni mu nic";
            // 
            // buttonCorrect
            // 
            this.buttonCorrect.Location = new System.Drawing.Point(427, 48);
            this.buttonCorrect.Name = "buttonCorrect";
            this.buttonCorrect.Size = new System.Drawing.Size(98, 30);
            this.buttonCorrect.TabIndex = 1;
            this.buttonCorrect.Text = "Opravit";
            this.buttonCorrect.UseVisualStyleBackColor = true;
            this.buttonCorrect.Click += new System.EventHandler(this.buttonCorrect_Click);
            // 
            // checkBoxDot
            // 
            this.checkBoxDot.AutoSize = true;
            this.checkBoxDot.Location = new System.Drawing.Point(427, 84);
            this.checkBoxDot.Name = "checkBoxDot";
            this.checkBoxDot.Size = new System.Drawing.Size(53, 17);
            this.checkBoxDot.TabIndex = 2;
            this.checkBoxDot.Text = "tečka";
            this.checkBoxDot.UseVisualStyleBackColor = true;
            // 
            // checkBoxUpper
            // 
            this.checkBoxUpper.AutoSize = true;
            this.checkBoxUpper.Location = new System.Drawing.Point(427, 107);
            this.checkBoxUpper.Name = "checkBoxUpper";
            this.checkBoxUpper.Size = new System.Drawing.Size(96, 17);
            this.checkBoxUpper.TabIndex = 3;
            this.checkBoxUpper.Text = "velké písmeno";
            this.checkBoxUpper.UseVisualStyleBackColor = true;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 304);
            this.Controls.Add(this.checkBoxUpper);
            this.Controls.Add(this.checkBoxDot);
            this.Controls.Add(this.buttonCorrect);
            this.Controls.Add(this.textBox1);
            this.Name = "Form9";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonCorrect;
        private System.Windows.Forms.CheckBox checkBoxDot;
        private System.Windows.Forms.CheckBox checkBoxUpper;
    }
}

