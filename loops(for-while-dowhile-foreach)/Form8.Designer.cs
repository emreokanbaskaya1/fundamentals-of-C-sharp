﻿namespace loops_for_while_dowhile_foreach_
{
    partial class Form8
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
            progressBar1 = new ProgressBar();
            label1 = new Label();
            label2 = new Label();
            progressBar2 = new ProgressBar();
            label3 = new Label();
            progressBar3 = new ProgressBar();
            label4 = new Label();
            progressBar4 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            timer4 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(30, 73);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(501, 31);
            progressBar1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 40);
            label1.Name = "label1";
            label1.Size = new Size(200, 19);
            label1.TabIndex = 1;
            label1.Text = "Un ve Yumurta Karıştırılıyor...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 132);
            label2.Name = "label2";
            label2.Size = new Size(174, 19);
            label2.TabIndex = 3;
            label2.Text = "Çırpma İşlemi  Yapılıyor...";
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(30, 165);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(501, 31);
            progressBar2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 227);
            label3.Name = "label3";
            label3.Size = new Size(183, 19);
            label3.TabIndex = 5;
            label3.Text = "Malzemeler Karıştırılıyor...";
            // 
            // progressBar3
            // 
            progressBar3.Location = new Point(30, 260);
            progressBar3.Name = "progressBar3";
            progressBar3.Size = new Size(501, 31);
            progressBar3.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 320);
            label4.Name = "label4";
            label4.Size = new Size(122, 19);
            label4.TabIndex = 7;
            label4.Text = "Pasta pişiriliyor...";
            // 
            // progressBar4
            // 
            progressBar4.Location = new Point(30, 351);
            progressBar4.Name = "progressBar4";
            progressBar4.Size = new Size(501, 31);
            progressBar4.TabIndex = 6;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // timer3
            // 
            timer3.Tick += timer3_Tick;
            // 
            // timer4
            // 
            timer4.Tick += timer4_Tick;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 570);
            Controls.Add(label4);
            Controls.Add(progressBar4);
            Controls.Add(label3);
            Controls.Add(progressBar3);
            Controls.Add(label2);
            Controls.Add(progressBar2);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form8";
            Text = "Form8";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Label label1;
        private Label label2;
        private ProgressBar progressBar2;
        private Label label3;
        private ProgressBar progressBar3;
        private Label label4;
        private ProgressBar progressBar4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
    }
}