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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // int number;
            // number = 24;
            // label1.Text = number.ToString(); // Convert int to string for display

            //int number1, number2, total;
            //number1 = 10;
            //number2 = 20;
            //total = number1 + number2;
            //label1.Text = total.ToString();

            int kenar, alan, cevre;
            kenar = 10; 
            alan = kenar * kenar; 
            cevre = 4 * kenar;

            label1.Text = "Alan: " + alan + " Çevre: " + cevre + " Kenar: " + kenar;
        }
    }
}
