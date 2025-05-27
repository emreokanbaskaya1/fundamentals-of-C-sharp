namespace arac_kullanimlari
{
    partial class Form6
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
            groupBox1 = new GroupBox();
            label9 = new Label();
            button2 = new Button();
            maskedTextBox1 = new MaskedTextBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button1 = new Button();
            label7 = new Label();
            label6 = new Label();
            maskedTextBox3 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            listBox1 = new ListBox();
            panel1 = new Panel();
            label8 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 197);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(310, 215);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Uçuş Bilgileri";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(153, 194);
            label9.Name = "label9";
            label9.Size = new Size(50, 18);
            label9.TabIndex = 8;
            label9.Text = "label9";
            label9.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(229, 24);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(103, 153);
            maskedTextBox1.Mask = "00:00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(147, 26);
            maskedTextBox1.TabIndex = 7;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 156);
            label4.Name = "label4";
            label4.Size = new Size(44, 18);
            label4.TabIndex = 6;
            label4.Text = "Saat:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(103, 118);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(147, 26);
            dateTimePicker1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 124);
            label3.Name = "label3";
            label3.Size = new Size(52, 18);
            label3.TabIndex = 4;
            label3.Text = "Tarih:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Ankara", "Bursa", "Adana", "Elazığ", "Samsun" });
            comboBox2.Location = new Point(103, 86);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(147, 26);
            comboBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Ankara", "Bursa", "Adana", "Elazığ", "Samsun" });
            comboBox1.Location = new Point(103, 53);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(147, 26);
            comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 89);
            label2.Name = "label2";
            label2.Size = new Size(65, 18);
            label2.TabIndex = 1;
            label2.Text = "Nereye:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 53);
            label1.Name = "label1";
            label1.Size = new Size(74, 18);
            label1.TabIndex = 0;
            label1.Text = "Nereden:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(maskedTextBox3);
            groupBox2.Controls.Add(maskedTextBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(369, 197);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(319, 215);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Yolcu Bilgileri";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(207, 176);
            button1.Name = "button1";
            button1.Size = new Size(75, 28);
            button1.TabIndex = 2;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(95, 94);
            label7.Name = "label7";
            label7.Size = new Size(34, 18);
            label7.TabIndex = 12;
            label7.Text = "TC:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(63, 141);
            label6.Name = "label6";
            label6.Size = new Size(66, 18);
            label6.TabIndex = 11;
            label6.Text = "Telefon:";
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(135, 133);
            maskedTextBox3.Mask = "(999) 000-0000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(147, 26);
            maskedTextBox3.TabIndex = 10;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(135, 89);
            maskedTextBox2.Mask = "00000000000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(147, 26);
            maskedTextBox2.TabIndex = 8;
            maskedTextBox2.ValidatingType = typeof(int);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(135, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(147, 26);
            textBox1.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 53);
            label5.Name = "label5";
            label5.Size = new Size(123, 18);
            label5.TabIndex = 8;
            label5.Text = "Yolcu Ad Soyad:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 18;
            listBox1.Location = new Point(12, 434);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(676, 94);
            listBox1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label8);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(676, 179);
            panel1.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Gill Sans Ultra Bold", 21.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(153, 57);
            label8.Name = "label8";
            label8.Size = new Size(381, 42);
            label8.TabIndex = 0;
            label8.Text = "Jupiter Hava Yolları";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 540);
            Controls.Add(panel1);
            Controls.Add(listBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "Form6";
            Text = "Form6";
            Load += Form6_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private MaskedTextBox maskedTextBox1;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label2;
        private Label label1;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox maskedTextBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label6;
        private Button button1;
        private Label label7;
        private ListBox listBox1;
        private Panel panel1;
        private Label label8;
        private Button button2;
        private Label label9;
    }
}