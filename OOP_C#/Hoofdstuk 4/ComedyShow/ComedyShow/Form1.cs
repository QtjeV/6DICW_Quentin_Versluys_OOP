namespace ComedyShow
{
    public partial class Form1 : Form
    {
        private Comedyshow _comedyshow;

        public Form1()
        {
            InitializeComponent();
            _comedyshow = new Comedyshow();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _comedyshow.Add(textBox1.Text, Convert.ToDouble(textBox2.Text));
            textBox5.Text = _comedyshow.berekenGemiddelde().ToString("0.00");
            textBox3.Text = _comedyshow.Laatste;
            textBox4.Text = _comedyshow.Aantal.ToString();
        }
    }
}
