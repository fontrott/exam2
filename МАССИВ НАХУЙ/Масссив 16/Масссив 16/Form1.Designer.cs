namespace Масссив_16
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.TextBox();
            this.Min = new System.Windows.Forms.TextBox();
            this.Max = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.Make = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Make_double = new System.Windows.Forms.Button();
            this.Pos = new System.Windows.Forms.TextBox();
            this.Neg = new System.Windows.Forms.TextBox();
            this.Nul = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сколько чисел";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "От";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "До";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Массив";
            // 
            // Count
            // 
            this.Count.Location = new System.Drawing.Point(112, 51);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(51, 20);
            this.Count.TabIndex = 4;
            // 
            // Min
            // 
            this.Min.Location = new System.Drawing.Point(112, 77);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(51, 20);
            this.Min.TabIndex = 5;
            // 
            // Max
            // 
            this.Max.Location = new System.Drawing.Point(112, 104);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(51, 20);
            this.Max.TabIndex = 6;
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(112, 133);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(371, 20);
            this.Result.TabIndex = 7;
            // 
            // Make
            // 
            this.Make.Location = new System.Drawing.Point(27, 175);
            this.Make.Name = "Make";
            this.Make.Size = new System.Drawing.Size(144, 22);
            this.Make.TabIndex = 8;
            this.Make.Text = "Сгенерировать целые ";
            this.Make.UseVisualStyleBackColor = true;
            this.Make.Click += new System.EventHandler(this.Make_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Положительных";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Отрицательных";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Нулей";
            // 
            // Make_double
            // 
            this.Make_double.Location = new System.Drawing.Point(177, 175);
            this.Make_double.Name = "Make_double";
            this.Make_double.Size = new System.Drawing.Size(144, 22);
            this.Make_double.TabIndex = 12;
            this.Make_double.Text = "Сгенерировать вещ";
            this.Make_double.UseVisualStyleBackColor = true;
            this.Make_double.Click += new System.EventHandler(this.Make_double_Click);
            // 
            // Pos
            // 
            this.Pos.Location = new System.Drawing.Point(120, 212);
            this.Pos.Name = "Pos";
            this.Pos.Size = new System.Drawing.Size(51, 20);
            this.Pos.TabIndex = 13;
            // 
            // Neg
            // 
            this.Neg.Location = new System.Drawing.Point(120, 238);
            this.Neg.Name = "Neg";
            this.Neg.Size = new System.Drawing.Size(51, 20);
            this.Neg.TabIndex = 14;
            // 
            // Nul
            // 
            this.Nul.Location = new System.Drawing.Point(120, 264);
            this.Nul.Name = "Nul";
            this.Nul.Size = new System.Drawing.Size(51, 20);
            this.Nul.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Nul);
            this.Controls.Add(this.Neg);
            this.Controls.Add(this.Pos);
            this.Controls.Add(this.Make_double);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Make);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Max);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Count;
        private System.Windows.Forms.TextBox Min;
        private System.Windows.Forms.TextBox Max;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button Make;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Make_double;
        private System.Windows.Forms.TextBox Pos;
        private System.Windows.Forms.TextBox Neg;
        private System.Windows.Forms.TextBox Nul;
    }
}

