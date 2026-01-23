namespace demoles
{
    public partial class Form1 : Form
    {
        private Lowie _lowie;
        public Form1()
        {
            InitializeComponent();
            _lowie = new Lowie();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            leeftijdbox.Text = _lowie.Leeftijd.ToString();

        }

        private void min_Click(object sender, EventArgs e)
        {
            if (leeftijdbox.Text != "")
            {
                _lowie.Leeftijd--;
                leeftijdbox.Text = _lowie.Leeftijd.ToString();
            }

        }

        private void plus_Click(object sender, EventArgs e)
        {
            if (leeftijdbox.Text != "") {
                _lowie.Leeftijd++;
                leeftijdbox.Text = _lowie.Leeftijd.ToString();
            }

        }
    }
}
