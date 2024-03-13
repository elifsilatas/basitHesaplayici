namespace Homework_Five
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sayi2 = Convert.ToDouble(textBox2.Text);
            string islem = textBox3.Text;
            
            switch(islem)
            {
                case "+" : label5.Text = (sayi1 + sayi2).ToString(); break;
                case "-" : label5.Text = (sayi1 - sayi2).ToString(); break;
                case "x" : label5.Text = (sayi1 * sayi2).ToString(); break;
                case "/" : label5.Text = (sayi1 / sayi2).ToString("0.00"); break;
                default : label5.Text = "Hatalý iþlem ya da hatalý sayý girdiniz!"; break;
            }


        }
    }
}