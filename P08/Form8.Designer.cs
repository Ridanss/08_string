namespace P08
{
    partial class Form8
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
            this.radioButton12px = new System.Windows.Forms.RadioButton();
            this.radioButton20px = new System.Windows.Forms.RadioButton();
            this.radioButtonBlack = new System.Windows.Forms.RadioButton();
            this.radioButtonRed = new System.Windows.Forms.RadioButton();
            this.checkBoxCount = new System.Windows.Forms.CheckBox();
            this.checkBoxLongest = new System.Windows.Forms.CheckBox();
            this.labelEdit = new System.Windows.Forms.Label();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCheckedFinish = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(348, 20);
            this.textBox1.TabIndex = 0;
            // 
            // radioButton12px
            // 
            this.radioButton12px.AutoSize = true;
            this.radioButton12px.Checked = true;
            this.radioButton12px.Location = new System.Drawing.Point(40, 78);
            this.radioButton12px.Name = "radioButton12px";
            this.radioButton12px.Size = new System.Drawing.Size(48, 17);
            this.radioButton12px.TabIndex = 1;
            this.radioButton12px.TabStop = true;
            this.radioButton12px.Text = "12px";
            this.radioButton12px.UseVisualStyleBackColor = true;
            // 
            // radioButton20px
            // 
            this.radioButton20px.AutoSize = true;
            this.radioButton20px.Location = new System.Drawing.Point(40, 101);
            this.radioButton20px.Name = "radioButton20px";
            this.radioButton20px.Size = new System.Drawing.Size(48, 17);
            this.radioButton20px.TabIndex = 2;
            this.radioButton20px.Text = "20px";
            this.radioButton20px.UseVisualStyleBackColor = true;
            // 
            // radioButtonBlack
            // 
            this.radioButtonBlack.AutoSize = true;
            this.radioButtonBlack.Checked = true;
            this.radioButtonBlack.Location = new System.Drawing.Point(7, 4);
            this.radioButtonBlack.Name = "radioButtonBlack";
            this.radioButtonBlack.Size = new System.Drawing.Size(51, 17);
            this.radioButtonBlack.TabIndex = 3;
            this.radioButtonBlack.TabStop = true;
            this.radioButtonBlack.Text = "black";
            this.radioButtonBlack.UseVisualStyleBackColor = true;
            // 
            // radioButtonRed
            // 
            this.radioButtonRed.AutoSize = true;
            this.radioButtonRed.Location = new System.Drawing.Point(7, 27);
            this.radioButtonRed.Name = "radioButtonRed";
            this.radioButtonRed.Size = new System.Drawing.Size(40, 17);
            this.radioButtonRed.TabIndex = 4;
            this.radioButtonRed.Text = "red";
            this.radioButtonRed.UseVisualStyleBackColor = true;
            // 
            // checkBoxCount
            // 
            this.checkBoxCount.AutoSize = true;
            this.checkBoxCount.Location = new System.Drawing.Point(131, 79);
            this.checkBoxCount.Name = "checkBoxCount";
            this.checkBoxCount.Size = new System.Drawing.Size(75, 17);
            this.checkBoxCount.TabIndex = 5;
            this.checkBoxCount.Text = "počet slov";
            this.checkBoxCount.UseVisualStyleBackColor = true;
            // 
            // checkBoxLongest
            // 
            this.checkBoxLongest.AutoSize = true;
            this.checkBoxLongest.Location = new System.Drawing.Point(131, 102);
            this.checkBoxLongest.Name = "checkBoxLongest";
            this.checkBoxLongest.Size = new System.Drawing.Size(91, 17);
            this.checkBoxLongest.TabIndex = 6;
            this.checkBoxLongest.Text = "nejdelší slovo";
            this.checkBoxLongest.UseVisualStyleBackColor = true;
            // 
            // labelEdit
            // 
            this.labelEdit.AutoSize = true;
            this.labelEdit.Location = new System.Drawing.Point(37, 189);
            this.labelEdit.Name = "labelEdit";
            this.labelEdit.Size = new System.Drawing.Size(45, 13);
            this.labelEdit.TabIndex = 7;
            this.labelEdit.Text = "Úprava:";
            // 
            // buttonExecute
            // 
            this.buttonExecute.Location = new System.Drawing.Point(244, 78);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(75, 23);
            this.buttonExecute.TabIndex = 8;
            this.buttonExecute.Text = "zadat";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonRed);
            this.panel1.Controls.Add(this.radioButtonBlack);
            this.panel1.Location = new System.Drawing.Point(33, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(98, 49);
            this.panel1.TabIndex = 9;
            // 
            // labelCheckedFinish
            // 
            this.labelCheckedFinish.AutoSize = true;
            this.labelCheckedFinish.Location = new System.Drawing.Point(128, 129);
            this.labelCheckedFinish.Name = "labelCheckedFinish";
            this.labelCheckedFinish.Size = new System.Drawing.Size(52, 13);
            this.labelCheckedFinish.TabIndex = 10;
            this.labelCheckedFinish.Text = "Výsledky:";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCheckedFinish);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.labelEdit);
            this.Controls.Add(this.checkBoxLongest);
            this.Controls.Add(this.checkBoxCount);
            this.Controls.Add(this.radioButton20px);
            this.Controls.Add(this.radioButton12px);
            this.Controls.Add(this.textBox1);
            this.Name = "Form8";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton12px;
        private System.Windows.Forms.RadioButton radioButton20px;
        private System.Windows.Forms.RadioButton radioButtonBlack;
        private System.Windows.Forms.RadioButton radioButtonRed;
        private System.Windows.Forms.CheckBox checkBoxCount;
        private System.Windows.Forms.CheckBox checkBoxLongest;
        private System.Windows.Forms.Label labelEdit;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelCheckedFinish;
    }
}

