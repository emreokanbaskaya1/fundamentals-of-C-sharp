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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // char takim;
            // takim = 'A';
            // label1.Text = takim.ToString();

           char ders =  Convert.ToChar(textBox1.Text);
           label1.Text = ders.ToString();
        }
    }
}
