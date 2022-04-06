namespace P07
{
    partial class Form7
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
            this.buttonCode = new System.Windows.Forms.Button();
            this.buttonDecode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(575, 20);
            this.textBox1.TabIndex = 0;
            // 
            // buttonCode
            // 
            this.buttonCode.Location = new System.Drawing.Point(35, 62);
            this.buttonCode.Name = "buttonCode";
            this.buttonCode.Size = new System.Drawing.Size(75, 23);
            this.buttonCode.TabIndex = 1;
            this.buttonCode.Text = "code";
            this.buttonCode.UseVisualStyleBackColor = true;
            this.buttonCode.Click += new System.EventHandler(this.buttonCode_Click);
            // 
            // buttonDecode
            // 
            this.buttonDecode.Location = new System.Drawing.Point(116, 62);
            this.buttonDecode.Name = "buttonDecode";
            this.buttonDecode.Size = new System.Drawing.Size(75, 23);
            this.buttonDecode.TabIndex = 2;
            this.buttonDecode.Text = "decode";
            this.buttonDecode.UseVisualStyleBackColor = true;
            this.buttonDecode.Click += new System.EventHandler(this.buttonDecode_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDecode);
            this.Controls.Add(this.buttonCode);
            this.Controls.Add(this.textBox1);
            this.Name = "Form7";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonCode;
        private System.Windows.Forms.Button buttonDecode;
    }
}

