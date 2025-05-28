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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, toplam, carpim, fark, bolum;
            int sayi2;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            toplam = sayi1 + sayi2;
            carpim = sayi1 * sayi2;
            fark = sayi1 - sayi2;
            bolum = sayi1 / sayi2;
            MessageBox.Show("Toplam: " + toplam + "\n" +
                            "Çarpım: " + carpim + "\n" +
                            "Fark: " + fark + "\n" +
                            "Bölüm: " + bolum, "Sonuçlar");
        }

    }
}
