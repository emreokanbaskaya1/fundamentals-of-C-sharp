using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string[] sehirler = {"Ankara", "İstanbul", "İzmir", "Bursa", "Adana", "Antalya" };
            //for(int i = 0; i < sehirler.Length; i++)
            //{
            //    listBox1.Items.Add(sehirler[i]);
            //}

            int[] sayilar = { 4, 2, 3, 1, 5, 6, 7, 9 };
            for(int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] % 2 == 0){
                    listBox1.Items.Add(sayilar[i]);
                }
            }

        }
    }
}
