using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace variables
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //double a = 1.04534;
            //label1.Text = a.ToString();

            // double note1, note2, note3, average;
            // note1 = 10.5;
            // note2 = 8.5;
            // note3 = 9.0;
            // average = (note1 + note2 + note3) / 3;
            // label1.Text = "Average: " + average.ToString();
            double sayi = Convert.ToDouble(textBox1.Text);
            label1.Text = sayi.ToString();
        }
    }
}
