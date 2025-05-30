using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Methods
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        int Kup(int sayi) { 
        
            sayi = Convert.ToInt32(textBox1.Text);

            return sayi * sayi * sayi;

            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Kup(5);

            label1.Text = Kup(5).ToString();
        }
    }
}
