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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = 0;

            for (int i = 2; i <= 10; i+=2)
            {
                toplam += i;
                
            }
            label1.Text = "Toplam: " + toplam.ToString();
        }
    }
}
