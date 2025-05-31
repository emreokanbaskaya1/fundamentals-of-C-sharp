namespace MenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Series["Kitap"].Points.AddXY("Akdeniz", 5);
            chart1.Series["Kitap"].Points.AddXY("Ege", 10);
            chart1.Series["Kitap"].Points.AddXY("нч Anadolu", 3);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
