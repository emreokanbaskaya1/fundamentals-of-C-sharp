namespace Methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //
        private void temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
            textBox4.BackColor = Color.White;
            textBox1.Focus();
        }

        void renklendir()
        {
            textBox1.BackColor = Color.LightGreen;
            textBox2.BackColor = Color.Red;
            textBox3.BackColor = Color.Yellow;
            textBox4.BackColor = Color.Tan;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            temizle();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            renklendir();
        }
    }
}
