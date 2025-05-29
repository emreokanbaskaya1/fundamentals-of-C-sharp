namespace loops_for_while_dowhile_foreach_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
         
         for(int i = 1; i < 11; i++)
         {
            listBox1.Items.Add(i);
         }
            
        }
    }
}
