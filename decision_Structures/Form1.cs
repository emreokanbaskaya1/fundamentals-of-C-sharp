namespace Decision_Structures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);

            if (sayi % 2 == 0 && sayi >= 10)
            {
                label1.Text = "Say� �ift ve 10'dan b�y�k.";
            }
            else { 
                label1.Text = "Say� �ift de�il veya 10'dan k���k.";
            }
        }
    }
}
