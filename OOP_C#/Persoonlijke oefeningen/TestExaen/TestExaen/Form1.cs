namespace TestExaen
{
    public partial class Form1 : Form
    {

        private spaceships schip1;

        public Form1()
        {
            InitializeComponent();

            Leiders leider1 = new Leiders("Jan", 45, "Kapitein", "Commodore");
            Mensen ondergedante1 = new Mensen("Klaas", 30, "Bemanningslid");
            Mensen ondergedante2 = new Mensen("Henk", 28, "Technicus");

            leider1.VoegOndergedanteToe(ondergedante1);
            leider1.VoegOndergedanteToe(ondergedante2);

            schip1 = new spaceships("USS Enterprise", leider1);
        }


        private void invisible()
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            invisible();
            Leider_Label.Text = schip1.Leider.Naam;
            Leider_Label.Visible = true;
        }

        private void Leider_Label_Click(object sender, EventArgs e)
        {

        }
    }
}
