using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aftelklok
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AftelklokForm formulier = new AftelklokForm(Convert.ToInt32(minutenbox.Text), Convert.ToInt32(secondenbox.Text));
            formulier.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            AftelklokForm formulier = new AftelklokForm(5, 0);
            formulier.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            AftelklokForm formulier = new AftelklokForm(1, 0);
            formulier.Show();
        }
    }
}
