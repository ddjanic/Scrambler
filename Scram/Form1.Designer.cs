namespace Scram
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tBDeScrambled = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tBScrambled = new System.Windows.Forms.TextBox();
            this.tBBinary = new System.Windows.Forms.TextBox();
            this.tBEnter = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1184, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(362, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "Де-скремблирование";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(445, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(300, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Бинарные данные в текст";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(445, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Скремблирование";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tBDeScrambled
            // 
            this.tBDeScrambled.Location = new System.Drawing.Point(751, 155);
            this.tBDeScrambled.Multiline = true;
            this.tBDeScrambled.Name = "tBDeScrambled";
            this.tBDeScrambled.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBDeScrambled.Size = new System.Drawing.Size(424, 134);
            this.tBDeScrambled.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(748, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Де-скремблированные данные";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(751, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Скремблированные данные";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Бинарный код";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Введенные данные";
            // 
            // tBScrambled
            // 
            this.tBScrambled.Location = new System.Drawing.Point(754, 22);
            this.tBScrambled.Multiline = true;
            this.tBScrambled.Name = "tBScrambled";
            this.tBScrambled.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBScrambled.Size = new System.Drawing.Size(424, 107);
            this.tBScrambled.TabIndex = 15;
            // 
            // tBBinary
            // 
            this.tBBinary.Location = new System.Drawing.Point(15, 171);
            this.tBBinary.Multiline = true;
            this.tBBinary.Name = "tBBinary";
            this.tBBinary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBBinary.Size = new System.Drawing.Size(424, 109);
            this.tBBinary.TabIndex = 14;
            // 
            // tBEnter
            // 
            this.tBEnter.Location = new System.Drawing.Point(12, 25);
            this.tBEnter.Multiline = true;
            this.tBEnter.Name = "tBEnter";
            this.tBEnter.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBEnter.Size = new System.Drawing.Size(427, 114);
            this.tBEnter.TabIndex = 13;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1427, 419);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(446, 54);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(299, 23);
            this.button4.TabIndex = 24;
            this.button4.Text = "Открыть файл с текстовыми данными";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1185, 52);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(361, 23);
            this.button5.TabIndex = 25;
            this.button5.Text = "Открыть файл со скремблированными текстовыми данными";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1185, 81);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(361, 23);
            this.button6.TabIndex = 26;
            this.button6.Text = "Сохранить файл со скремблированными текстовыми данными";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1185, 155);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(361, 23);
            this.button7.TabIndex = 27;
            this.button7.Text = "Сохранить файл со де-скремблированными текстовыми данными";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(587, 335);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(375, 23);
            this.button8.TabIndex = 28;
            this.button8.Text = "Открыть аудио файл с данными";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(1002, 335);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(396, 23);
            this.button9.TabIndex = 29;
            this.button9.Text = "Открыть аудио файл со скремблированнными данными";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(584, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Ключ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(999, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Ключ:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(626, 305);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(336, 20);
            this.textBox1.TabIndex = 32;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1041, 305);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(357, 20);
            this.textBox2.TabIndex = 33;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(587, 365);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(375, 20);
            this.textBox3.TabIndex = 34;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(587, 392);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(375, 23);
            this.button10.TabIndex = 35;
            this.button10.Text = "Скремблирование аудио файла с данными, обработка и сохранение";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(587, 422);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(375, 20);
            this.textBox4.TabIndex = 36;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(1002, 365);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(396, 20);
            this.textBox5.TabIndex = 37;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(1002, 392);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(396, 23);
            this.button11.TabIndex = 38;
            this.button11.Text = "Де-скремблирование аудио файла с данными, обработка и сохранение";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(1002, 421);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(396, 20);
            this.textBox6.TabIndex = 39;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1564, 453);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tBDeScrambled);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBScrambled);
            this.Controls.Add(this.tBBinary);
            this.Controls.Add(this.tBEnter);
            this.Controls.Add(this.btnExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formMain";
            this.Text = "Скремблер/Де-скремблер";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tBDeScrambled;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBScrambled;
        private System.Windows.Forms.TextBox tBBinary;
        private System.Windows.Forms.TextBox tBEnter;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox textBox6;
    }
}

