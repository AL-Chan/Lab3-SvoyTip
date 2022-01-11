
namespace Lab03_SvoyTip
{
    partial class Calculator
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
            this.textOne = new System.Windows.Forms.TextBox();
            this.textTwo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.summa = new System.Windows.Forms.Button();
            this.raznost = new System.Windows.Forms.Button();
            this.proizved = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textRes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.sravnit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textOne
            // 
            this.textOne.Location = new System.Drawing.Point(26, 121);
            this.textOne.Name = "textOne";
            this.textOne.Size = new System.Drawing.Size(100, 20);
            this.textOne.TabIndex = 0;
            this.textOne.TextChanged += new System.EventHandler(this.textOne_TextChanged);
            // 
            // textTwo
            // 
            this.textTwo.Location = new System.Drawing.Point(24, 261);
            this.textTwo.Name = "textTwo";
            this.textTwo.Size = new System.Drawing.Size(102, 20);
            this.textTwo.TabIndex = 1;
            this.textTwo.TextChanged += new System.EventHandler(this.textTwo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Первое значение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Второе значение";
            // 
            // summa
            // 
            this.summa.Location = new System.Drawing.Point(30, 152);
            this.summa.Name = "summa";
            this.summa.Size = new System.Drawing.Size(92, 25);
            this.summa.TabIndex = 5;
            this.summa.Text = "СЛОЖИТЬ";
            this.summa.UseVisualStyleBackColor = true;
            this.summa.Click += new System.EventHandler(this.summa_Click);
            // 
            // raznost
            // 
            this.raznost.Location = new System.Drawing.Point(137, 152);
            this.raznost.Name = "raznost";
            this.raznost.Size = new System.Drawing.Size(92, 25);
            this.raznost.TabIndex = 6;
            this.raznost.Text = "ВЫЧЕСТЬ";
            this.raznost.UseVisualStyleBackColor = true;
            this.raznost.Click += new System.EventHandler(this.raznost_Click);
            // 
            // proizved
            // 
            this.proizved.Location = new System.Drawing.Point(30, 196);
            this.proizved.Name = "proizved";
            this.proizved.Size = new System.Drawing.Size(92, 25);
            this.proizved.TabIndex = 7;
            this.proizved.Text = "УМНОЖИТЬ";
            this.proizved.UseVisualStyleBackColor = true;
            this.proizved.Click += new System.EventHandler(this.proizved_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(160, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(48, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(160, 120);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(48, 21);
            this.comboBox2.TabIndex = 9;
            // 
            // textRes
            // 
            this.textRes.Location = new System.Drawing.Point(30, 33);
            this.textRes.Name = "textRes";
            this.textRes.Size = new System.Drawing.Size(101, 20);
            this.textRes.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ответ";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(160, 260);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(48, 21);
            this.comboBox3.TabIndex = 12;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(262, 32);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(68, 20);
            this.button4.TabIndex = 13;
            this.button4.Text = "СПРАВКА";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // sravnit
            // 
            this.sravnit.Location = new System.Drawing.Point(137, 196);
            this.sravnit.Name = "sravnit";
            this.sravnit.Size = new System.Drawing.Size(92, 25);
            this.sravnit.TabIndex = 14;
            this.sravnit.Text = "СРАВНИТЬ";
            this.sravnit.UseVisualStyleBackColor = true;
            this.sravnit.Click += new System.EventHandler(this.sravnit_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 403);
            this.Controls.Add(this.sravnit);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textRes);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.proizved);
            this.Controls.Add(this.raznost);
            this.Controls.Add(this.summa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textTwo);
            this.Controls.Add(this.textOne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Calculator";
            this.Text = "Калькулятор температур";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textOne;
        private System.Windows.Forms.TextBox textTwo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button summa;
        private System.Windows.Forms.Button raznost;
        private System.Windows.Forms.Button proizved;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textRes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button sravnit;
    }
}

