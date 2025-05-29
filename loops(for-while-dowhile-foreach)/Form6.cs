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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        int saat = 0, saniye = 0, dakika = 0;

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            label1.Text = saniye.ToString();

            if(saniye == 60)
            {
                saniye = 0;
                dakika++;
                label2.Text = dakika.ToString();

                if(dakika == 3)
                {
                    saat++;
                    label3.Text = saat.ToString();
                    dakika = 0;
                }
            }
        }
    }
}
