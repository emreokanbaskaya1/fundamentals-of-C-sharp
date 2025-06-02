namespace Dynamic_Tools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            Point btnkonum = new Point(20,10);
            btn.Location = btnkonum;
            btn.Name= "Button1";
            btn.Text = "Týkla";
            btn.BackColor = Color.Red;
            btn.Height = 50;
            btn.Width = 75;
            this.Controls.Add(btn);

            Label lbl = new Label();
            Point lblkonum = new Point(20, 75);
            lbl.Location = lblkonum;
            lbl.Name = "Label1";
            lbl.Text = "Merhaba";
            lbl.BackColor = Color.Yellow;
            this.Controls.Add(lbl);
            lbl.AutoSize = true;

            

            for (int i = 1; i<=5; i++)
            {
                TextBox txt = new TextBox();
                Point txtkonum = new Point(20, 100 + (i * 30));
                txt.Location = txtkonum;
                txt.Name = "TextBox" + i.ToString();
                txt.Text = i.ToString();
                this.Controls.Add(txt);
            }
        }
    }
}
