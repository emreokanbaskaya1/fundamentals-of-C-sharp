namespace Enum_structure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum sehirler {x, Adana, Ad�yaman, Afyon, A�r�, Amasya, Ankara, Antalya, Artvin, Ayd�n}
        private void button1_Click(object sender, EventArgs e)
        {
            int plaka = Convert.ToInt32(textBox1.Text);
            sehirler s;
            s = (sehirler)plaka;
            label1.Text = s.ToString();
        }
    }
}
