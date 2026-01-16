namespace _3lagenmodel_test_h3_Versluys_Quentin
{
    public partial class Form1 : Form
    {
        private ComedyShow _comedyShow;
        public Form1()
        {
            _comedyShow = new ComedyShow();
            InitializeComponent();
        }


        //extra dingen die ik per ongeluk heb toegevoegd had niet genoeg tijd om te verwijderen sorry
        private void Gemiddelde_Score_Click(object sender, EventArgs e)
        {

        }

        private void Laatste_Show_Click(object sender, EventArgs e)
        {

        }

        private void Aantal_Shows_Click(object sender, EventArgs e)
        {

        }

        private void Show_Invoer_TextChanged(object sender, EventArgs e)
        {

        }

        private void Score_Show_TextChanged(object sender, EventArgs e)
        {

        }


        //voegt een show toe aan de comedyshow klasse en update de labels
        private void Show_Toevoegen_Click(object sender, EventArgs e)
        {
            _comedyShow.Add(Show_Invoer.Text, Convert.ToDouble(Score_Show.Text));
            Gemiddelde_Score.Text = _comedyShow.BerekenGemiddelde().ToString("0.0");
            Aantal_Shows.Text = _comedyShow.Aantal.ToString();
            Laatste_Show.Text = Show_Invoer.Text;

            Show_Invoer.Text = "";
            Score_Show.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
