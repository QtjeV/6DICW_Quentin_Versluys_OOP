namespace Aftelklok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    internal class Aftelklok
    {
        private int _minuten;
        private int _seconden;

        public Aftelklok(int minuten, int seconden)
        {
            _minuten = minuten;
            _seconden = seconden;
        }

        public int GetMinuten()
        {
            return _minuten;
        }
        public int GetSeconden() {
            return _seconden;
        }
        public void SetMinuten(int minuten)
        {
            _minuten = minuten;
        }
        public void SetSeconden(int seconden)
        {
            _seconden = seconden;
        }

        public void TijdInstellen(int minuten, int seconden)
        {
            _minuten = minuten;
            _seconden = seconden;
        }

        public void Aftellen()
        {
            if (_minuten == 0 && _seconden == 0)
                return;

            if (_seconden == 0)
            {
                _minuten--;
                _seconden = 59;
            }
            else
            {
                _seconden--;
            }
        }

        public string ResterendeTijd()
        {
            return DisplayTweeCijfers(_minuten) + ":" + DisplayTweeCijfers(_seconden);
        }

        private string DisplayTweeCijfers(int getal)
        {
            return getal < 10 ? "0" + getal : getal.ToString();
        }
    }

    
}

