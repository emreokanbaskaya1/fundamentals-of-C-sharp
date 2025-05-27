namespace arac_kullanimlari
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bursa", "Ankara", "Balıkesir", "Gaziantep", "Elazığ", "Malatya", "İstanbul", "İzmir", "Aydın" });
            comboBox1.Location = new Point(174, 49);
            comboBox1.Margin = new Padding(4, 5, 4, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(171, 31);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(174, 88);
            button1.Name = "button1";
            button1.Size = new Size(128, 34);
            button1.TabIndex = 1;
            button1.Text = "Sehir Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(404, 97);
            button2.Name = "button2";
            button2.Size = new Size(100, 31);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(404, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 31);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 23;
            listBox1.Items.AddRange(new object[] { "Öğretmen", "Doktor", "Mühendis", "Hemşire" });
            listBox1.Location = new Point(174, 268);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(171, 188);
            listBox1.TabIndex = 4;
            // 
            // button3
            // 
            button3.Location = new Point(174, 462);
            button3.Name = "button3";
            button3.Size = new Size(75, 31);
            button3.TabIndex = 5;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(681, 410);
            button4.Name = "button4";
            button4.Size = new Size(100, 32);
            button4.TabIndex = 6;
            button4.Text = "Kaydet";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(605, 376);
            label1.Name = "label1";
            label1.Size = new Size(70, 23);
            label1.TabIndex = 7;
            label1.Text = "Meslek:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(681, 373);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 31);
            textBox2.TabIndex = 8;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 568);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form2";
            Text = "Arac_kullanimlari";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private ListBox listBox1;
        private Button button3;
        private Button button4;
        private Label label1;
        private TextBox textBox2;
    }
}