using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace variables
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            int sinav1, sinav2, proje;
            double ortalama;

            ad = textBox3.Text;
            soyad = textBox2.Text;
            sinav1 = Convert.ToInt32(textBox1.Text);
            sinav2 = Convert.ToInt32(textBox4.Text);
            proje = Convert.ToInt32(textBox5.Text);
            ortalama = (sinav1 + sinav2 + proje) / 3;

            listBox1.Items.Add ( 
                "Ad: " + ad + "\n" +
                "Soyad: " + soyad + "\n" +
                "Sınav 1: " + sinav1 + "\n" +
                "Sınav 2: " + sinav2 + "\n" +
                "Proje: " + proje + "\n" +
                "Ortalama: " + ortalama.ToString());

        }
    }
}
