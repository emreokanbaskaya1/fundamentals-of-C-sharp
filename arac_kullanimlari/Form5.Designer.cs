namespace arac_kullanimlari
{
    partial class Form5
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            label1 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            textBox1 = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            checkBox1 = new CheckBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 211);
            label1.Name = "label1";
            label1.Size = new Size(102, 21);
            label1.TabIndex = 0;
            label1.Text = "TC Kimlik No:";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(181, 211);
            maskedTextBox1.Mask = "00000000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(202, 29);
            maskedTextBox1.TabIndex = 1;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(181, 246);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(202, 29);
            textBox1.TabIndex = 3;
            textBox1.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(130, 244);
            label2.Name = "label2";
            label2.Size = new Size(45, 21);
            label2.TabIndex = 4;
            label2.Text = "Şifre:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(655, 145);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Info;
            panel2.Location = new Point(12, 419);
            panel2.Name = "panel2";
            panel2.Size = new Size(655, 39);
            panel2.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(279, 281);
            button1.Name = "button1";
            button1.Size = new Size(104, 28);
            button1.TabIndex = 0;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(389, 250);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(145, 25);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Şifremi Unuttum";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Snap ITC", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(150, 48);
            label3.Name = "label3";
            label3.Size = new Size(372, 31);
            label3.TabIndex = 0;
            label3.Text = "Online Ders Giriş Paneli";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(544, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(676, 465);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(maskedTextBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form5";
            Text = "Kullanıcı Giriş Paneli";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MaskedTextBox maskedTextBox1;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox textBox1;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private CheckBox checkBox1;
        private Label label3;
        private PictureBox pictureBox1;
    }
}