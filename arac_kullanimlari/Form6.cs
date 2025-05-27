using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arac_kullanimlari
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota: " + comboBox1.Text + "-" + comboBox2.Text + "Tarih: " + dateTimePicker1.Text
              + "Saat: " + maskedTextBox1.Text + "Yolcu Bilgileri || Ad: " + textBox1.Text + "TC: " + maskedTextBox2.Text
              + "Telefon: " + maskedTextBox3.Text);
            MessageBox.Show("Biletiniz Alınmıştır. İyi Yolculuklar Dileriz.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label9.Text;
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
