﻿namespace Context_Menu_Strip
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            maviToolStripMenuItem = new ToolStripMenuItem();
            yeşilToolStripMenuItem = new ToolStripMenuItem();
            ayarlarToolStripMenuItem = new ToolStripMenuItem();
            hakkımızdaToolStripMenuItem = new ToolStripMenuItem();
            çıkışToolStripMenuItem = new ToolStripMenuItem();
            kolayErişimToolStripMenuItem = new ToolStripMenuItem();
            hesapMakinesiToolStripMenuItem = new ToolStripMenuItem();
            paintToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { maviToolStripMenuItem, yeşilToolStripMenuItem, ayarlarToolStripMenuItem, kolayErişimToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(139, 92);
            // 
            // maviToolStripMenuItem
            // 
            maviToolStripMenuItem.Name = "maviToolStripMenuItem";
            maviToolStripMenuItem.Size = new Size(138, 22);
            maviToolStripMenuItem.Text = "Mavi";
            maviToolStripMenuItem.Click += maviToolStripMenuItem_Click;
            // 
            // yeşilToolStripMenuItem
            // 
            yeşilToolStripMenuItem.Name = "yeşilToolStripMenuItem";
            yeşilToolStripMenuItem.Size = new Size(138, 22);
            yeşilToolStripMenuItem.Text = "Yeşil";
            // 
            // ayarlarToolStripMenuItem
            // 
            ayarlarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hakkımızdaToolStripMenuItem, çıkışToolStripMenuItem });
            ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            ayarlarToolStripMenuItem.Size = new Size(138, 22);
            ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // hakkımızdaToolStripMenuItem
            // 
            hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            hakkımızdaToolStripMenuItem.Size = new Size(136, 22);
            hakkımızdaToolStripMenuItem.Text = "Hakkımızda";
            hakkımızdaToolStripMenuItem.Click += hakkımızdaToolStripMenuItem_Click;
            // 
            // çıkışToolStripMenuItem
            // 
            çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            çıkışToolStripMenuItem.Size = new Size(136, 22);
            çıkışToolStripMenuItem.Text = "Çıkış";
            çıkışToolStripMenuItem.Click += çıkışToolStripMenuItem_Click;
            // 
            // kolayErişimToolStripMenuItem
            // 
            kolayErişimToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hesapMakinesiToolStripMenuItem, paintToolStripMenuItem });
            kolayErişimToolStripMenuItem.Name = "kolayErişimToolStripMenuItem";
            kolayErişimToolStripMenuItem.Size = new Size(138, 22);
            kolayErişimToolStripMenuItem.Text = "Kolay Erişim";
            // 
            // hesapMakinesiToolStripMenuItem
            // 
            hesapMakinesiToolStripMenuItem.Name = "hesapMakinesiToolStripMenuItem";
            hesapMakinesiToolStripMenuItem.Size = new Size(180, 22);
            hesapMakinesiToolStripMenuItem.Text = "Hesap Makinesi";
            hesapMakinesiToolStripMenuItem.Click += hesapMakinesiToolStripMenuItem_Click;
            // 
            // paintToolStripMenuItem
            // 
            paintToolStripMenuItem.Name = "paintToolStripMenuItem";
            paintToolStripMenuItem.Size = new Size(180, 22);
            paintToolStripMenuItem.Text = "Paint";
            paintToolStripMenuItem.Click += paintToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ContextMenuStrip = contextMenuStrip1;
            Name = "Form1";
            Text = "Form1";
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem maviToolStripMenuItem;
        private ToolStripMenuItem yeşilToolStripMenuItem;
        private ToolStripMenuItem ayarlarToolStripMenuItem;
        private ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private ToolStripMenuItem çıkışToolStripMenuItem;
        private ToolStripMenuItem kolayErişimToolStripMenuItem;
        private ToolStripMenuItem hesapMakinesiToolStripMenuItem;
        private ToolStripMenuItem paintToolStripMenuItem;
    }
}
