namespace Checkbox_Extra_Oefening
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            true_of_false.Text = "uit";
        }

        private void checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                true_of_false.Text = "aan";
            }
            else
            {
                true_of_false.Text = "uit";
            }
        }
    }
}
