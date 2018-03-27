namespace Arrays1DWinForms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewArray = new System.Windows.Forms.DataGridView();
            this.Randomize = new System.Windows.Forms.Button();
            this.findmark = new System.Windows.Forms.Button();
            this.Text_s = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArray)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(53, 13);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // dataGridViewArray
            // 
            this.dataGridViewArray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArray.Location = new System.Drawing.Point(53, 57);
            this.dataGridViewArray.Name = "dataGridViewArray";
            this.dataGridViewArray.Size = new System.Drawing.Size(686, 268);
            this.dataGridViewArray.TabIndex = 1;
            // 
            // Randomize
            // 
            this.Randomize.Location = new System.Drawing.Point(189, 10);
            this.Randomize.Name = "Randomize";
            this.Randomize.Size = new System.Drawing.Size(91, 23);
            this.Randomize.TabIndex = 2;
            this.Randomize.Text = "Згенерувати ";
            this.Randomize.UseVisualStyleBackColor = true;
            this.Randomize.Click += new System.EventHandler(this.Randomize_Click);
            // 
            // findmark
            // 
            this.findmark.Location = new System.Drawing.Point(312, 10);
            this.findmark.Name = "findmark";
            this.findmark.Size = new System.Drawing.Size(75, 23);
            this.findmark.TabIndex = 2;
            this.findmark.Text = "Розв\'язати";
            this.findmark.UseVisualStyleBackColor = true;
            this.findmark.Click += new System.EventHandler(this.findmark_Click);
            // 
            // Text_s
            // 
            this.Text_s.Location = new System.Drawing.Point(189, 351);
            this.Text_s.Name = "Text_s";
            this.Text_s.Size = new System.Drawing.Size(100, 20);
            this.Text_s.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(126, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "сума ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Text_s);
            this.Controls.Add(this.findmark);
            this.Controls.Add(this.Randomize);
            this.Controls.Add(this.dataGridViewArray);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArray)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridView dataGridViewArray;
        private System.Windows.Forms.Button Randomize;
        private System.Windows.Forms.Button findmark;
        private System.Windows.Forms.TextBox Text_s;
        private System.Windows.Forms.Label label3;
    }
}

