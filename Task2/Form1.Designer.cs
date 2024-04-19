namespace Task2
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
            listView2 = new ListView();
            buttonAdd = new Button();
            textBox1 = new TextBox();
            button_AddTo = new Button();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            label2 = new Label();
            textBox_since = new TextBox();
            button1 = new Button();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label3 = new Label();
            textBox_after = new TextBox();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Dock = DockStyle.Top;
            listView1.Location = new Point(3, 23);
            listView1.Name = "listView1";
            listView1.Size = new Size(242, 131);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            listView2.Dock = DockStyle.Top;
            listView2.Location = new Point(3, 23);
            listView2.Name = "listView2";
            listView2.Size = new Size(249, 131);
            listView2.TabIndex = 1;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(78, 235);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(17, 202);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(212, 27);
            textBox1.TabIndex = 3;
            // 
            // button_AddTo
            // 
            button_AddTo.Location = new Point(52, 179);
            button_AddTo.Name = "button_AddTo";
            button_AddTo.Size = new Size(159, 59);
            button_AddTo.TabIndex = 4;
            button_AddTo.Text = "Добавить элементы из первого списка";
            button_AddTo.UseVisualStyleBackColor = true;
            button_AddTo.Click += button_AddTo_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(listView1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(buttonAdd);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(248, 394);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "SortedSet";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox_after);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(textBox_since);
            groupBox3.Controls.Add(button1);
            groupBox3.Dock = DockStyle.Bottom;
            groupBox3.Location = new Point(3, 265);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(242, 126);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Удаление первых n элементов:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 29);
            label2.Name = "label2";
            label2.Size = new Size(19, 20);
            label2.TabIndex = 8;
            label2.Text = "с:";
            // 
            // textBox_since
            // 
            textBox_since.Location = new Point(68, 26);
            textBox_since.Name = "textBox_since";
            textBox_since.Size = new Size(125, 27);
            textBox_since.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(75, 92);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Удалить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Location = new Point(17, 157);
            label1.Name = "label1";
            label1.Size = new Size(212, 42);
            label1.TabIndex = 4;
            label1.Text = "Введите элемент, который хотите добавить:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listView2);
            groupBox2.Controls.Add(button_AddTo);
            groupBox2.Location = new Point(266, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(255, 394);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Queue";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 62);
            label3.Name = "label3";
            label3.Size = new Size(30, 20);
            label3.TabIndex = 9;
            label3.Text = "по:";
            // 
            // textBox_after
            // 
            textBox_after.Location = new Point(68, 59);
            textBox_after.Name = "textBox_after";
            textBox_after.Size = new Size(125, 27);
            textBox_after.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 413);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ListView listView2;
        private Button buttonAdd;
        private TextBox textBox1;
        private Button button_AddTo;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private GroupBox groupBox3;
        private TextBox textBox_since;
        private Button button1;
        private Label label2;
        private TextBox textBox_after;
        private Label label3;
    }
}
