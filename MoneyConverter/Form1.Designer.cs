namespace MoneyConverter
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioRuble = new System.Windows.Forms.RadioButton();
            this.radioDollar = new System.Windows.Forms.RadioButton();
            this.radioEuro = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количетсво денег";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 22);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Конвертировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(28, 158);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(329, 245);
            this.result.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.radioEuro);
            this.panel1.Controls.Add(this.radioDollar);
            this.panel1.Controls.Add(this.radioRuble);
            this.panel1.Location = new System.Drawing.Point(27, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 74);
            this.panel1.TabIndex = 4;
            // 
            // radioRuble
            // 
            this.radioRuble.AutoSize = true;
            this.radioRuble.Checked = true;
            this.radioRuble.Location = new System.Drawing.Point(3, 37);
            this.radioRuble.Name = "radioRuble";
            this.radioRuble.Size = new System.Drawing.Size(69, 21);
            this.radioRuble.TabIndex = 0;
            this.radioRuble.TabStop = true;
            this.radioRuble.Text = "Рубли";
            this.radioRuble.UseVisualStyleBackColor = true;
            this.radioRuble.CheckedChanged += new System.EventHandler(this.radioRuble_CheckedChanged);
            // 
            // radioDollar
            // 
            this.radioDollar.AutoSize = true;
            this.radioDollar.Location = new System.Drawing.Point(78, 37);
            this.radioDollar.Name = "radioDollar";
            this.radioDollar.Size = new System.Drawing.Size(90, 21);
            this.radioDollar.TabIndex = 1;
            this.radioDollar.Text = "Доллары";
            this.radioDollar.UseVisualStyleBackColor = true;
            // 
            // radioEuro
            // 
            this.radioEuro.AutoSize = true;
            this.radioEuro.Location = new System.Drawing.Point(174, 37);
            this.radioEuro.Name = "radioEuro";
            this.radioEuro.Size = new System.Drawing.Size(61, 21);
            this.radioEuro.TabIndex = 2;
            this.radioEuro.Text = "Евро";
            this.radioEuro.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-2, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Текущая валюта";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Конвертер валют";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioEuro;
        private System.Windows.Forms.RadioButton radioDollar;
        private System.Windows.Forms.RadioButton radioRuble;
        private System.Windows.Forms.Label label2;
    }
}

