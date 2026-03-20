using Business;

namespace DobbelsteenOef
{
    public partial class DobbelsteenForm : Form
    {
       
        private Business.Dobbelsteen _dobbelsteen;
        public DobbelsteenForm(int aantalZijden)
        {
            InitializeComponent();
            
            _dobbelsteen = new Dobbelsteen(aantalZijden);
           
            dobbelsteenTextBox.Text = _dobbelsteen.Werp().ToString();
        }
        private void werpenButton_Click(object sender, EventArgs e)
        {
            dobbelsteenTextBox.Text = _dobbelsteen.Werp().ToString();
        }
    }
}
