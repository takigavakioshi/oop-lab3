namespace Arrays2DWinForms
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.mm = new System.Windows.Forms.NumericUpDown();
            this.nn = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewArray = new System.Windows.Forms.DataGridView();
            this.Text_s = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArray)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(578, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Згенерувати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(696, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "розв\'язати";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mm
            // 
            this.mm.Location = new System.Drawing.Point(25, 25);
            this.mm.Name = "mm";
            this.mm.Size = new System.Drawing.Size(120, 20);
            this.mm.TabIndex = 1;
            // 
            // nn
            // 
            this.nn.Location = new System.Drawing.Point(178, 25);
            this.nn.Name = "nn";
            this.nn.Size = new System.Drawing.Size(120, 20);
            this.nn.TabIndex = 1;
            // 
            // dataGridViewArray
            // 
            this.dataGridViewArray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArray.Location = new System.Drawing.Point(42, 67);
            this.dataGridViewArray.Name = "dataGridViewArray";
            this.dataGridViewArray.Size = new System.Drawing.Size(746, 246);
            this.dataGridViewArray.TabIndex = 2;
            // 
            // Text_s
            // 
            this.Text_s.Location = new System.Drawing.Point(300, 353);
            this.Text_s.Name = "Text_s";
            this.Text_s.Size = new System.Drawing.Size(160, 20);
            this.Text_s.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "max from minimal ";
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Text_s);
            this.Controls.Add(this.dataGridViewArray);
            this.Controls.Add(this.nn);
            this.Controls.Add(this.mm);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArray)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown mm;
        private System.Windows.Forms.NumericUpDown nn;
        private System.Windows.Forms.DataGridView dataGridViewArray;
        private System.Windows.Forms.TextBox Text_s;
        private System.Windows.Forms.Label label1;
    }
}

