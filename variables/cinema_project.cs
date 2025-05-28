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
    public partial class cinema_project : Form
    {
        public cinema_project()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        int kasatutar = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            int misir, bilet, su, cay;
            misir = Convert.ToInt32(TxtMisir.Text);
            bilet = Convert.ToInt32(TxtBilet.Text);
            su = Convert.ToInt32(TxtSu.Text);
            cay = Convert.ToInt32(TxtCay.Text);

            int toplam = (misir * 4) + (bilet * 8) + (su * 1) + (cay * 2);
            lblToplam.Text = toplam.ToString() + " TL";

            kasatutar = kasatutar + toplam;
            lblKasa.Text = kasatutar.ToString() + " TL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtBilet.Text = "";
            TxtCay.Text = "";
            TxtMisir.Text = "";
            TxtSu.Text = "";
            TxtMisir.Focus();

        }
    }
}
