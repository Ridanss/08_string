namespace P04
{
    partial class Form4
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
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.buttonRemoveUnwanted = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(44, 49);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(193, 20);
            this.textBoxInput.TabIndex = 0;
            // 
            // buttonExecute
            // 
            this.buttonExecute.Location = new System.Drawing.Point(243, 47);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(75, 23);
            this.buttonExecute.TabIndex = 1;
            this.buttonExecute.Text = "zadat";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(44, 75);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(193, 20);
            this.textBoxOutput.TabIndex = 2;
            // 
            // buttonRemoveUnwanted
            // 
            this.buttonRemoveUnwanted.Location = new System.Drawing.Point(243, 73);
            this.buttonRemoveUnwanted.Name = "buttonRemoveUnwanted";
            this.buttonRemoveUnwanted.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveUnwanted.TabIndex = 3;
            this.buttonRemoveUnwanted.Text = "bez *";
            this.buttonRemoveUnwanted.UseVisualStyleBackColor = true;
            this.buttonRemoveUnwanted.Click += new System.EventHandler(this.buttonRemoveUnwanted_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 214);
            this.Controls.Add(this.buttonRemoveUnwanted);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.textBoxInput);
            this.Name = "Form4";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button buttonRemoveUnwanted;
    }
}

