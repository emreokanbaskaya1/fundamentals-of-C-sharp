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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mevsim = textBox1.Text;
            switch (mevsim)
            {
                case "Yaz": label2.Text = "Yaz ayları: Haziran, Temmuz, Ağustos"; break;
                case "Sonbahar": label2.Text = "Sonbahar ayları: Eylül, Ekim, Kasım"; break;
                case "Kış": label2.Text = "Kış ayları: Aralık, Ocak, Şubat"; break;
                case "İlkbahar": label2.Text = "İlkbahar ayları: Mart, Nisan, Mayıs"; break;
                default: label2.Text = "Geçersiz mevsim adı"; break;

            }
        }
    }
}
