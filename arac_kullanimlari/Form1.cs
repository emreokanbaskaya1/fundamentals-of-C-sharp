namespace arac_kullanimlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba, C# ile Windows Form uygulamasý geliþtiriyorsunuz!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Baran";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = "Okan";
            label7.Text = "Baskaya";
            label8.Text = "Yazýlýmcý";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "Yazýlýmcý Okan Baskaya";
            label9.Text = textBox1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
