namespace Decision_Structures
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            richTextBox1 = new RichTextBox();
            BtnA = new Button();
            BtnB = new Button();
            BtnC = new Button();
            BtnD = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblSoruno = new Label();
            lblDogru = new Label();
            lblYanlis = new Label();
            BtnSonraki = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(46, 31);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(568, 193);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // BtnA
            // 
            BtnA.Location = new Point(48, 230);
            BtnA.Name = "BtnA";
            BtnA.Size = new Size(130, 37);
            BtnA.TabIndex = 1;
            BtnA.Text = "A";
            BtnA.UseVisualStyleBackColor = true;
            BtnA.Click += BtnA_Click;
            // 
            // BtnB
            // 
            BtnB.Location = new Point(216, 230);
            BtnB.Name = "BtnB";
            BtnB.Size = new Size(130, 37);
            BtnB.TabIndex = 2;
            BtnB.Text = "B";
            BtnB.UseVisualStyleBackColor = true;
            BtnB.Click += BtnB_Click;
            // 
            // BtnC
            // 
            BtnC.Location = new Point(48, 287);
            BtnC.Name = "BtnC";
            BtnC.Size = new Size(130, 36);
            BtnC.TabIndex = 3;
            BtnC.Text = "C";
            BtnC.UseVisualStyleBackColor = true;
            // 
            // BtnD
            // 
            BtnD.Location = new Point(216, 287);
            BtnD.Name = "BtnD";
            BtnD.Size = new Size(130, 36);
            BtnD.TabIndex = 4;
            BtnD.Text = "D";
            BtnD.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(620, 31);
            label1.Name = "label1";
            label1.Size = new Size(82, 24);
            label1.TabIndex = 5;
            label1.Text = "Soru No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(637, 68);
            label2.Name = "label2";
            label2.Size = new Size(65, 24);
            label2.TabIndex = 6;
            label2.Text = "Dogru:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(637, 104);
            label3.Name = "label3";
            label3.Size = new Size(65, 24);
            label3.TabIndex = 7;
            label3.Text = "Yanlış:";
            // 
            // lblSoruno
            // 
            lblSoruno.AutoSize = true;
            lblSoruno.Location = new Point(708, 31);
            lblSoruno.Name = "lblSoruno";
            lblSoruno.Size = new Size(21, 24);
            lblSoruno.TabIndex = 8;
            lblSoruno.Text = "0";
            // 
            // lblDogru
            // 
            lblDogru.AutoSize = true;
            lblDogru.Location = new Point(708, 68);
            lblDogru.Name = "lblDogru";
            lblDogru.Size = new Size(21, 24);
            lblDogru.TabIndex = 9;
            lblDogru.Text = "0";
            // 
            // lblYanlis
            // 
            lblYanlis.AutoSize = true;
            lblYanlis.Location = new Point(708, 104);
            lblYanlis.Name = "lblYanlis";
            lblYanlis.Size = new Size(21, 24);
            lblYanlis.TabIndex = 10;
            lblYanlis.Text = "0";
            //lblYanlis.Click += lblYanlis_Click;
            // 
            // BtnSonraki
            // 
            BtnSonraki.Location = new Point(620, 167);
            BtnSonraki.Name = "BtnSonraki";
            BtnSonraki.Size = new Size(146, 54);
            BtnSonraki.TabIndex = 11;
            BtnSonraki.Text = "Sonraki";
            BtnSonraki.UseVisualStyleBackColor = true;
            BtnSonraki.Click += BtnSonraki_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(376, 227);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(483, 227);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 93);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(615, 266);
            label4.Name = "label4";
            label4.Size = new Size(60, 24);
            label4.TabIndex = 14;
            label4.Text = "label4";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(691, 266);
            label5.Name = "label5";
            label5.Size = new Size(60, 24);
            label5.TabIndex = 15;
            label5.Text = "label5";
            label5.Visible = false;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 387);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(BtnSonraki);
            Controls.Add(lblYanlis);
            Controls.Add(lblDogru);
            Controls.Add(lblSoruno);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnD);
            Controls.Add(BtnC);
            Controls.Add(BtnB);
            Controls.Add(BtnA);
            Controls.Add(richTextBox1);
            Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form5";
            Text = "Sonraki";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button BtnA;
        private Button BtnB;
        private Button BtnC;
        private Button BtnD;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblSoruno;
        private Label lblDogru;
        private Label lblYanlis;
        private Button BtnSonraki;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label5;
    }
}