namespace Day11
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listView1 = new ListView();
            button1 = new Button();
            textBox_count = new TextBox();
            textBox_sum = new TextBox();
            textBox_countmas = new TextBox();
            groupBox1 = new GroupBox();
            textBox_x = new TextBox();
            label4 = new Label();
            label1 = new Label();
            button2 = new Button();
            groupBox2 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Dock = DockStyle.Fill;
            listView1.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listView1.Location = new Point(3, 23);
            listView1.Name = "listView1";
            listView1.Size = new Size(327, 365);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            button1.Location = new Point(6, 126);
            button1.Name = "button1";
            button1.Size = new Size(157, 52);
            button1.TabIndex = 1;
            button1.Text = "Обычные числа";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox_count
            // 
            textBox_count.Location = new Point(6, 265);
            textBox_count.Name = "textBox_count";
            textBox_count.Size = new Size(148, 27);
            textBox_count.TabIndex = 2;
            // 
            // textBox_sum
            // 
            textBox_sum.Location = new Point(6, 354);
            textBox_sum.Name = "textBox_sum";
            textBox_sum.Size = new Size(261, 27);
            textBox_sum.TabIndex = 3;
            // 
            // textBox_countmas
            // 
            textBox_countmas.Location = new Point(178, 36);
            textBox_countmas.Name = "textBox_countmas";
            textBox_countmas.Size = new Size(125, 27);
            textBox_countmas.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listView1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(333, 391);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Генерация массива";
            // 
            // textBox_x
            // 
            textBox_x.Location = new Point(178, 79);
            textBox_x.Name = "textBox_x";
            textBox_x.Size = new Size(125, 27);
            textBox_x.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 82);
            label4.Name = "label4";
            label4.Size = new Size(153, 20);
            label4.TabIndex = 7;
            label4.Text = "X(для ряда тейлора):";
            // 
            // label1
            // 
            label1.Location = new Point(24, 22);
            label1.Name = "label1";
            label1.Size = new Size(157, 50);
            label1.TabIndex = 6;
            label1.Text = "Количество элементов массива:";
            // 
            // button2
            // 
            button2.Location = new Point(177, 126);
            button2.Name = "button2";
            button2.Size = new Size(149, 52);
            button2.TabIndex = 5;
            button2.Text = "Числа ряда Тейлора";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox_x);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(textBox_count);
            groupBox2.Controls.Add(textBox_sum);
            groupBox2.Controls.Add(textBox_countmas);
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(351, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(332, 391);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            // 
            // label3
            // 
            label3.Location = new Point(6, 305);
            label3.Name = "label3";
            label3.Size = new Size(313, 46);
            label3.TabIndex = 5;
            label3.Text = "Сумма элементов между первым и последним положительными числами:\r\n";
            // 
            // label2
            // 
            label2.Location = new Point(6, 235);
            label2.Name = "label2";
            label2.Size = new Size(251, 27);
            label2.TabIndex = 4;
            label2.Text = "Количество элемнтов меньше 0,9:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 411);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private Button button1;
        private TextBox textBox_count;
        private TextBox textBox_sum;
        private TextBox textBox_countmas;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private Button button2;
        private Label label3;
        private Label label2;
        private TextBox textBox_x;
        private Label label4;
    }
}
