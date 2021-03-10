namespace WorkWithCollection
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.generate = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.min = new System.Windows.Forms.Button();
            this.max = new System.Windows.Forms.Button();
            this.count = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 22);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 62);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сортировка по возрастанию";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(121, 53);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(163, 62);
            this.generate.TabIndex = 2;
            this.generate.Text = "Сгенерировать коллекцию";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(290, 53);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 62);
            this.button3.TabIndex = 3;
            this.button3.Text = "Сортировка по убыванию";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(23, 121);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(75, 23);
            this.min.TabIndex = 4;
            this.min.Text = "min";
            this.min.UseVisualStyleBackColor = true;
            this.min.Click += new System.EventHandler(this.min_Click);
            // 
            // max
            // 
            this.max.Location = new System.Drawing.Point(162, 121);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(75, 23);
            this.max.TabIndex = 5;
            this.max.Text = "max";
            this.max.UseVisualStyleBackColor = true;
            this.max.Click += new System.EventHandler(this.max_Click);
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(308, 121);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(75, 23);
            this.count.TabIndex = 6;
            this.count.Text = "count";
            this.count.UseVisualStyleBackColor = true;
            this.count.Click += new System.EventHandler(this.count_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(88, 150);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(226, 150);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.SmallIcon;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 305);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.count);
            this.Controls.Add(this.max);
            this.Controls.Add(this.min);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.MaximumSize = new System.Drawing.Size(423, 352);
            this.MinimumSize = new System.Drawing.Size(423, 352);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button min;
        private System.Windows.Forms.Button max;
        private System.Windows.Forms.Button count;
        private System.Windows.Forms.ListView listView1;
    }
}

