namespace _3lagenmodel_test_h3_Versluys_Quentin
{
    public partial class Form1 : Form
    {
        private KindLengteVoorspeller _LengteVoorspeller;
        // Constructor
        public Form1()
        {
            _LengteVoorspeller = new KindLengteVoorspeller();
            InitializeComponent();
        }

        //Button om dochter lengte te berekenen
        private void DochterButton_Click(object sender, EventArgs e)
        {
            //waarden checken en berekenen
            _LengteVoorspeller.VaderLengte = Convert.ToDouble(ManTextBox.Text);
            _LengteVoorspeller.MoederLengte = Convert.ToDouble(VrouwTextBox.Text);
            _LengteVoorspeller.AantalVoorspellingen += 1;
            HoogteLabel.Text = _LengteVoorspeller.BerekenDochter().ToString("0.00");
            AantalVoorspellingenLabel.Text = _LengteVoorspeller.AantalVoorspellingen.ToString();

            HoogteLabel.Visible = true;
        }

        //Button om zoon lengte te berekenen
        private void ZoonButton_Click(object sender, EventArgs e)
        {
            //waarden checken en berekenen
            _LengteVoorspeller.VaderLengte = Convert.ToDouble(ManTextBox.Text);
            _LengteVoorspeller.MoederLengte = Convert.ToDouble(VrouwTextBox.Text);
            _LengteVoorspeller.AantalVoorspellingen += 1;
            HoogteLabel.Text = _LengteVoorspeller.BerekenZoon().ToString("0.00");
            AantalVoorspellingenLabel.Text = _LengteVoorspeller.AantalVoorspellingen.ToString();

            HoogteLabel.Visible = true;
        }
    }
}
