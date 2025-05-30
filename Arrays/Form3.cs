using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // string[] kisiler = { "Ali", "Ahmet", "Mehmet", "Mesut", "Pınar", "Berna" };
            // foreach (string k in kisiler)
            // {
            //     listBox1.Items.Add(k);
            // }
            int toplam = 0;
            int avarage = 0;

            int[] sinavlar = { 70, 65, 85, 100, 90 };
            foreach (int x in sinavlar)
            {
                listBox1.Items.Add(x);
                toplam = toplam + x;
                avarage = toplam / sinavlar.Length;
            }
            label1.Text = "Toplam: " + toplam.ToString();
            label2.Text = "Ortalama: " + avarage.ToString();
        }
    }
}
