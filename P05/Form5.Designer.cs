namespace P05
{
    partial class Form5
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
            this.buttonExecute1 = new System.Windows.Forms.Button();
            this.labelPocetSlov1 = new System.Windows.Forms.Label();
            this.buttonExecute2 = new System.Windows.Forms.Button();
            this.labelPocetSlov2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(339, 20);
            this.textBox1.TabIndex = 0;
            // 
            // buttonExecute1
            // 
            this.buttonExecute1.Location = new System.Drawing.Point(52, 64);
            this.buttonExecute1.Name = "buttonExecute1";
            this.buttonExecute1.Size = new System.Drawing.Size(75, 23);
            this.buttonExecute1.TabIndex = 1;
            this.buttonExecute1.Text = "zadat";
            this.buttonExecute1.UseVisualStyleBackColor = true;
            this.buttonExecute1.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // labelPocetSlov1
            // 
            this.labelPocetSlov1.AutoSize = true;
            this.labelPocetSlov1.Location = new System.Drawing.Point(133, 69);
            this.labelPocetSlov1.Name = "labelPocetSlov1";
            this.labelPocetSlov1.Size = new System.Drawing.Size(59, 13);
            this.labelPocetSlov1.TabIndex = 2;
            this.labelPocetSlov1.Text = "počet slov:";
            // 
            // buttonExecute2
            // 
            this.buttonExecute2.Location = new System.Drawing.Point(52, 93);
            this.buttonExecute2.Name = "buttonExecute2";
            this.buttonExecute2.Size = new System.Drawing.Size(75, 23);
            this.buttonExecute2.TabIndex = 3;
            this.buttonExecute2.Text = "zadat";
            this.buttonExecute2.UseVisualStyleBackColor = true;
            this.buttonExecute2.Click += new System.EventHandler(this.buttonExecute2_Click);
            // 
            // labelPocetSlov2
            // 
            this.labelPocetSlov2.AutoSize = true;
            this.labelPocetSlov2.Location = new System.Drawing.Point(133, 98);
            this.labelPocetSlov2.Name = "labelPocetSlov2";
            this.labelPocetSlov2.Size = new System.Drawing.Size(59, 13);
            this.labelPocetSlov2.TabIndex = 4;
            this.labelPocetSlov2.Text = "počet slov:";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelPocetSlov2);
            this.Controls.Add(this.buttonExecute2);
            this.Controls.Add(this.labelPocetSlov1);
            this.Controls.Add(this.buttonExecute1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form5";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonExecute1;
        private System.Windows.Forms.Label labelPocetSlov1;
        private System.Windows.Forms.Button buttonExecute2;
        private System.Windows.Forms.Label labelPocetSlov2;
    }
}

