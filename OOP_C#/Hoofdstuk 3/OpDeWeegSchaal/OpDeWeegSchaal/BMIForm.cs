using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpDeWeegschaal
{
    public partial class BMIForm : Form
    {
        private WeightWatcher _weightWatcher;

        public BMIForm()
        {
            InitializeComponent();
            _weightWatcher = new WeightWatcher(58, 1.80);
            groote_box.Text = _weightWatcher.Grootte.ToString("0.00");
            gewicht_box.Text = _weightWatcher.Gewicht.ToString();
            status_box.Text = _weightWatcher.GeefStatus();
            bmi_box.Text = _weightWatcher.GeefBMI().ToString("0.00");
        }

      

        private void minus_button_Click(object sender, EventArgs e)
        {
            _weightWatcher.Gewicht-=1;
            gewicht_box.Text = (_weightWatcher.Gewicht).ToString();
            status_box.Text = _weightWatcher.GeefStatus();
            bmi_box.Text = _weightWatcher.GeefBMI().ToString("0.00");
        }

        private void plus_button_Click(object sender, EventArgs e)
        {
            _weightWatcher.Gewicht +=1;
            gewicht_box.Text = (_weightWatcher.Gewicht).ToString(); ;
            status_box.Text = _weightWatcher.GeefStatus();
            bmi_box.Text = _weightWatcher.GeefBMI().ToString("0.00");
        }
    }
}
