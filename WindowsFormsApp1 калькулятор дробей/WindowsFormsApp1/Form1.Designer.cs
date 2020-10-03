namespace WindowsFormsApp1
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
            this.chis1 = new System.Windows.Forms.TextBox();
            this.znam1 = new System.Windows.Forms.TextBox();
            this.znam2 = new System.Windows.Forms.TextBox();
            this.chis2 = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.sum = new System.Windows.Forms.Button();
            this.umn = new System.Windows.Forms.Button();
            this.razn = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chis1
            // 
            this.chis1.Location = new System.Drawing.Point(277, 78);
            this.chis1.Margin = new System.Windows.Forms.Padding(4);
            this.chis1.Name = "chis1";
            this.chis1.Size = new System.Drawing.Size(57, 22);
            this.chis1.TabIndex = 0;
            // 
            // znam1
            // 
            this.znam1.Location = new System.Drawing.Point(277, 130);
            this.znam1.Margin = new System.Windows.Forms.Padding(4);
            this.znam1.Name = "znam1";
            this.znam1.Size = new System.Drawing.Size(57, 22);
            this.znam1.TabIndex = 1;
            // 
            // znam2
            // 
            this.znam2.Location = new System.Drawing.Point(379, 130);
            this.znam2.Margin = new System.Windows.Forms.Padding(4);
            this.znam2.Name = "znam2";
            this.znam2.Size = new System.Drawing.Size(57, 22);
            this.znam2.TabIndex = 3;
            // 
            // chis2
            // 
            this.chis2.Location = new System.Drawing.Point(379, 78);
            this.chis2.Margin = new System.Windows.Forms.Padding(4);
            this.chis2.Name = "chis2";
            this.chis2.Size = new System.Drawing.Size(57, 22);
            this.chis2.TabIndex = 2;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(508, 108);
            this.result.Margin = new System.Windows.Forms.Padding(4);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(91, 22);
            this.result.TabIndex = 4;
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(287, 186);
            this.sum.Margin = new System.Windows.Forms.Padding(4);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(61, 25);
            this.sum.TabIndex = 6;
            this.sum.Text = "+";
            this.sum.UseVisualStyleBackColor = true;
            this.sum.Click += new System.EventHandler(this.sum_Click);
            // 
            // umn
            // 
            this.umn.Location = new System.Drawing.Point(356, 186);
            this.umn.Margin = new System.Windows.Forms.Padding(4);
            this.umn.Name = "umn";
            this.umn.Size = new System.Drawing.Size(61, 25);
            this.umn.TabIndex = 7;
            this.umn.Text = "*";
            this.umn.UseVisualStyleBackColor = true;
            this.umn.Click += new System.EventHandler(this.umn_Click);
            // 
            // razn
            // 
            this.razn.Location = new System.Drawing.Point(287, 218);
            this.razn.Margin = new System.Windows.Forms.Padding(4);
            this.razn.Name = "razn";
            this.razn.Size = new System.Drawing.Size(61, 25);
            this.razn.TabIndex = 8;
            this.razn.Text = "-";
            this.razn.UseVisualStyleBackColor = true;
            this.razn.Click += new System.EventHandler(this.razn_Click);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(356, 218);
            this.del.Margin = new System.Windows.Forms.Padding(4);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(61, 25);
            this.del.TabIndex = 9;
            this.del.Text = "/";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(463, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 446);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.del);
            this.Controls.Add(this.razn);
            this.Controls.Add(this.umn);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.result);
            this.Controls.Add(this.znam2);
            this.Controls.Add(this.chis2);
            this.Controls.Add(this.znam1);
            this.Controls.Add(this.chis1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "------------------";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox chis1;
        private System.Windows.Forms.TextBox znam1;
        private System.Windows.Forms.TextBox znam2;
        private System.Windows.Forms.TextBox chis2;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Button umn;
        private System.Windows.Forms.Button razn;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Label label1;
    }
}

