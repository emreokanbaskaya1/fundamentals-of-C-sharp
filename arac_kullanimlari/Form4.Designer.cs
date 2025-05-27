namespace arac_kullanimlari
{
    partial class Form4
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
            checkBox1 = new CheckBox();
            groupBox1 = new GroupBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            panel1 = new Panel();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(15, 28);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(104, 27);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Mayonez";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(152, 158);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Soslar";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(15, 94);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(88, 27);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Hardal";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(15, 61);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(88, 27);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Ketçap";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(72, 24);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(79, 27);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Kadın";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(72, 57);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(77, 27);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "Erkek";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(radioButton2);
            panel1.Location = new Point(184, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(221, 158);
            panel1.TabIndex = 6;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 176);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(393, 121);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(12, 303);
            button1.Name = "button1";
            button1.Size = new Size(93, 33);
            button1.TabIndex = 8;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(900, 462);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(5);
            Name = "Form4";
            Text = "Form4";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CheckBox checkBox1;
        private GroupBox groupBox1;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Panel panel1;
        private RichTextBox richTextBox1;
        private Button button1;
    }
}