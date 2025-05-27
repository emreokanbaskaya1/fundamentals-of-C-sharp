namespace arac_kullanimlari
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            maskedTextBox1 = new MaskedTextBox();
            label1 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            label2 = new Label();
            maskedTextBox3 = new MaskedTextBox();
            label3 = new Label();
            maskedTextBox4 = new MaskedTextBox();
            label4 = new Label();
            button1 = new Button();
            listBox1 = new ListBox();
            pictureBox1 = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(90, 42);
            maskedTextBox1.Margin = new Padding(4);
            maskedTextBox1.Mask = "(999) 000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(134, 27);
            maskedTextBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 50);
            label1.Name = "label1";
            label1.Size = new Size(63, 19);
            label1.TabIndex = 1;
            label1.Text = "Telefon:";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(90, 88);
            maskedTextBox2.Margin = new Padding(4);
            maskedTextBox2.Mask = "00000000000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(134, 27);
            maskedTextBox2.TabIndex = 2;
            maskedTextBox2.ValidatingType = typeof(int);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 91);
            label2.Name = "label2";
            label2.Size = new Size(31, 19);
            label2.TabIndex = 3;
            label2.Text = "TC:";
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(90, 132);
            maskedTextBox3.Margin = new Padding(4);
            maskedTextBox3.Mask = "00/00/0000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(134, 27);
            maskedTextBox3.TabIndex = 4;
            maskedTextBox3.ValidatingType = typeof(DateTime);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 135);
            label3.Name = "label3";
            label3.Size = new Size(47, 19);
            label3.TabIndex = 5;
            label3.Text = "Tarih:";
            label3.Click += label3_Click;
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.Location = new Point(90, 178);
            maskedTextBox4.Margin = new Padding(4);
            maskedTextBox4.Mask = "00:00";
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(134, 27);
            maskedTextBox4.TabIndex = 6;
            maskedTextBox4.ValidatingType = typeof(DateTime);
            maskedTextBox4.MaskInputRejected += maskedTextBox4_MaskInputRejected;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 186);
            label4.Name = "label4";
            label4.Size = new Size(44, 19);
            label4.TabIndex = 7;
            label4.Text = "Saat:";
            // 
            // button1
            // 
            button1.Location = new Point(41, 221);
            button1.Name = "button1";
            button1.Size = new Size(134, 30);
            button1.TabIndex = 8;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 19;
            listBox1.Location = new Point(36, 298);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(393, 118);
            listBox1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(265, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 163);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(250, 211);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(179, 27);
            dateTimePicker1.TabIndex = 11;
            // 
            // button2
            // 
            button2.Location = new Point(311, 244);
            button2.Name = "button2";
            button2.Size = new Size(118, 30);
            button2.TabIndex = 12;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 474);
            Controls.Add(button2);
            Controls.Add(dateTimePicker1);
            Controls.Add(pictureBox1);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(maskedTextBox4);
            Controls.Add(label3);
            Controls.Add(maskedTextBox3);
            Controls.Add(label2);
            Controls.Add(maskedTextBox2);
            Controls.Add(label1);
            Controls.Add(maskedTextBox1);
            Font = new Font("Corbel", 12F);
            Margin = new Padding(4);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox maskedTextBox1;
        private Label label1;
        private MaskedTextBox maskedTextBox2;
        private Label label2;
        private MaskedTextBox maskedTextBox3;
        private Label label3;
        private MaskedTextBox maskedTextBox4;
        private Label label4;
        private Button button1;
        private ListBox listBox1;
        private PictureBox pictureBox1;
        private DateTimePicker dateTimePicker1;
        private Button button2;
    }
}