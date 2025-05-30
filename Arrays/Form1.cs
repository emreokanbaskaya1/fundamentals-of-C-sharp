namespace Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string[] kisiler = { "Ali", "Ahmet", "Mehmet", "Aslý", "Hakan" ,"Ayþe" ,"Demet" };
            //label1.Text = kisiler[4];
            int[] sayilar = { 4, 7, 5, 6, 9, 8, 2, 3 };
            label1.Text = sayilar[5].ToString();
        }

    }
}
