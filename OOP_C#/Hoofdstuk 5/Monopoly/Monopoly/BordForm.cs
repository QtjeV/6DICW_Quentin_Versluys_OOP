using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monopoly
{
    public partial class BordForm : Form
    {
        public BordForm()
        {
            InitializeComponent();
        }

        private void vak23Button_Click(object sender, EventArgs e)
        {
            StraatForm formulier = new StraatForm(new MonopolyStraat("Veldstraat", "Gent", 22, 120, 360, 850, 1025, 1200), vak23Button.BackColor);
            formulier.Show();
        }

        private void vak24Button_Click(object sender, EventArgs e)
        {
            StraatForm formulier = new StraatForm(new MonopolyStraat("Grote Markt", "Gent", 22, 120, 360, 850, 1025, 1200), vak24Button.BackColor);
            formulier.Show();
        }

        private void vak26Button_Click(object sender, EventArgs e)
        {
            StraatForm formulier = new StraatForm(new MonopolyStraat("Groenplaats", "Gent", 22, 120, 360, 850, 1025, 1200), vak26Button.BackColor);
            formulier.Show();
        }
    }
}
