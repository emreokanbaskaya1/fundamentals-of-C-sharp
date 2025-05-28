namespace variables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name, profession;
            name = "Okan";
            profession= "Software Developer";

            label1.Text = "Name : " + name + ", Profession: " + profession;
        }
    }
}
