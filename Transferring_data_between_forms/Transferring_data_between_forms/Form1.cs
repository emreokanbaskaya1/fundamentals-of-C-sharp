namespace Transferring_data_between_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.mesaj = textBox1.Text;
            f2.Show();
            this.Hide();

        }
    }
}
