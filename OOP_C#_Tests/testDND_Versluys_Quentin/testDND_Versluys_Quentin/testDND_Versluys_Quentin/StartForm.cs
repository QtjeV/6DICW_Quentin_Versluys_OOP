namespace testDND_Versluys_Quentin
{
    using DnDBusiness;
    using DnDPresentation;

    public partial class StartForm : Form
    {
        private Dnd _DnD;
        public StartForm()
        {

            InitializeComponent();
            _DnD = new Dnd();
        }

        public void VoegToeButton_Click(object sender, EventArgs e)
        {
            String naam = NaamBox.Text;
            int strength = Convert.ToInt32(StrengthBox.Text);
            _DnD.VoegToe(naam, strength);
            CharachterBox.DataSource = null;
            CharachterBox.DataSource = _DnD.Karakters;

        }

        private void FormulierButton_Click(object sender, EventArgs e)
        {
            String _naam = CharachterBox.SelectedItem.ToString(); ;
            var karakter = _DnD.GeefKarakter(_naam);
            if (karakter != null)
            {
                int _strength = karakter.Sterkte;
                DetailForm detailForm = new DetailForm(_naam, _strength);
                detailForm.Show();
            }
            
        }

        private void ToonHierButton_Click(object sender, EventArgs e)
        {
            String _naam = CharachterBox.SelectedItem.ToString(); ;
            var karakter = _DnD.GeefKarakter(_naam);
            if (karakter != null)
            {
                int _strength = karakter.Sterkte;
                ToonHierLabel.Text = "Naam: " + _naam + ", " + "Sterkte: " + _strength;
            }
            
        }
    }
}
