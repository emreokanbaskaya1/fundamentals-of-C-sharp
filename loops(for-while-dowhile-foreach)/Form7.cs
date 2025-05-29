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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 75;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
            if (progressBar1.Value == 100)
            {
                button1.Enabled = false;

            }
            
            if (progressBar1.Value < 100)
            {
                button1.Enabled = true;
            }
            if (progressBar1.Value == 0)
            {
                button2.Enabled = false;


            }
            if (progressBar1.Value > 0)
            {
                button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
          
            progressBar1.Value -= 10;
            if (progressBar1.Value == 0)
            {
                button2.Enabled = false;
                

            }
            if (progressBar1.Value > 0)
            {
                button2.Enabled = true;
            }
            if (progressBar1.Value == 100)
            {
                button1.Enabled = false;

            }

            if (progressBar1.Value < 100)
            {
                button1.Enabled = true;
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            

        }
    }
}
