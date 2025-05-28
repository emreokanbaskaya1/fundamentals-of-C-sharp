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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kitapsayisi;
            double toplam;

            kitapsayisi = Convert.ToInt32(textBox1.Text);

            if (kitapsayisi >= 0 && kitapsayisi <= 20)
            {
                toplam = (kitapsayisi * 8)* 0.8;
                label3.Text = toplam.ToString();
            }
            else
            {
                toplam = (kitapsayisi * 8) * 0.5;
                label3.Text = toplam.ToString();
            }
        }
    }
}
