using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Wielertenue
{
    public partial class BestellingForm : Form
    {
        private BestellingWielertenue _bestelling;
        public BestellingForm()
        {
            InitializeComponent();
            _bestelling = new BestellingWielertenue(1, false, false, false);
            prijsTextBox.Text = _bestelling.GeefPrijs().ToString();
        }

        private void wielbroekje_CheckedChanged(object sender, EventArgs e)
        {
            _bestelling.Broek = wielbroekje.Checked;
            prijsTextBox.Text = _bestelling.GeefPrijs().ToString();
            
            if (wielbroekje.Checked)
            {
                wielertenuePictureBox.Visible = true;
                wielertruiPictureBox.Visible = false;
                superzeemcheckbox.Visible = true;
                superzeemcheckbox.Checked = true;
            }
            else
            {
                wielertenuePictureBox.Visible = false;
                wielertruiPictureBox.Visible = true;
                superzeemcheckbox.Visible = false;
                superzeemcheckbox.Checked = false;
            }
        }


        private void waterdichtzakje_CheckedChanged(object sender, EventArgs e)
        {
            _bestelling.WaterdichtZakje = waterdichtzakje.Checked;
            prijsTextBox.Text = _bestelling.GeefPrijs().ToString();
        }

        private void aantalBox_ValueChanged(object sender, EventArgs e)
        {
            _bestelling.Aantal = Convert.ToInt32(aantalBox.Value);
            prijsTextBox.Text = _bestelling.GeefPrijs().ToString();
        }

        private void superzeemcheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
