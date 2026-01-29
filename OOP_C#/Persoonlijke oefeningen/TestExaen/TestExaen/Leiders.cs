using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExaen
{
    internal class Leiders : Mensen
    {
        private string _titel;
        private List<Mensen> _ondergedanten;
        public Leiders(string naam, int leeftijd, string beroep, string titel) : base(naam, leeftijd, beroep)
        {
            this._titel = titel;
            this._ondergedanten = new List<Mensen>();
        }

        public string Titel
        {
            set { _titel = value; }
            get { return _titel; }
        }

        public void VoegOndergedanteToe(Mensen ondergedante)
        {
            _ondergedanten.Add(ondergedante);
        }

        public List<Mensen> OnderGedanten
        {
            get { return _ondergedanten; }
        }
    }
}
