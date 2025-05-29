using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loops_for_while_dowhile_foreach_
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // int sayi;
            // 
            // sayi = Convert.ToInt32(textBox1.Text);
            // 
            // for (int i = 0; i <= sayi; i++) {
            // 
            //     listBox1.Items.Add(i);
            // }

           int sayi = Convert.ToInt32(textBox1.Text);
            int faktoriyel = 1;
            for (int i = 1; i<= sayi; i++)
            {
                faktoriyel *= i;
                listBox1.Items.Add(i + "! = " + faktoriyel);
            }
        }
    }
}
