﻿using System;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label1.Text = sayac.ToString();
            if(sayac == 10)
            {
                this.BackColor = Color.Red;
            }
            if (sayac == 30)
            {
                this.BackColor = Color.Green;
                sayac = 0;
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
