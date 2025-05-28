using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decision_Structures
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sinav1, sinav2, proje;
            sinav1 = Convert.ToDouble(textBox1.Text);
            sinav2 = Convert.ToDouble(textBox2.Text);
            proje = Convert.ToDouble(textBox3.Text);

            double ortalama = (sinav1 + sinav2 + proje) / 3.0;

            textBox4.Text = ortalama.ToString();
            if (ortalama >= 60) {
                textBox4.Text = "Tebrikler, Sınıfı Geçtiniz! " + ortalama.ToString();
            }
            else
            {
                textBox4.Text = "Üzgünüz, Sınıfta Kaldınız! " + ortalama.ToString();
            }

        }
    }
}
