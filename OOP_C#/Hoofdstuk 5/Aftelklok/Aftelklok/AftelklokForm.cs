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
    public partial class AftelklokForm : Form
    {
        private Aftelklok _klokje;  // het veld _klokje declareren
        private int _startMinuten;
        private int _startSeconden;

        public AftelklokForm(int minuten, int seconden)
        {
            InitializeComponent();

            // het veld _klokje initialiseren als een nieuw Aftelklok-object
            // _klokje wordt hierbij ingesteld op 1 minuut 30 seconden
            _klokje = new Aftelklok(minuten, seconden);
            _startMinuten = minuten;
            _startSeconden = seconden;

            // de tijd van _klokje in het tekstvak tonen
            displayTextBox.Text = _klokje.ResterendeTijd();
        }

        private void aftelklokTimer_Tick(object sender, EventArgs e)
        {
            // _klokje met één seconde verminderen
            _klokje.Aftellen();

            // nieuwe resterende tijd van _klokje in tekstvak zetten
            displayTextBox.Text = _klokje.ResterendeTijd();
        }

        private void opnieuwOpStarttijd_Click(object sender, EventArgs e)
        {            
            // _klokje opnieuw instellen op 1 minuut en 30 seconden
            _klokje.TijdInstellen(_startMinuten, _startSeconden);

            // tekstvak vernieuwen
            displayTextBox.Text = _klokje.ResterendeTijd();

            // de Timer uitschakelen
            aftelklokTimer.Stop();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            // de Timer inschakelen
            aftelklokTimer.Start();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            // de Timer uitschakelen
            aftelklokTimer.Stop();
        }
    }
}
