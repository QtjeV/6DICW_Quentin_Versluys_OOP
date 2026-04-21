using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDPresentation
{
    using DnDBusiness;
    public partial class DetailForm : Form
    {
        private Dnd _dnd;
        public DetailForm(String Name, int Strength)
        {
            InitializeComponent();
            _dnd = new Dnd();
            NaamLabel.Text= Name;
            StrengthLabel.Text= Strength.ToString();
        }
    }
}
