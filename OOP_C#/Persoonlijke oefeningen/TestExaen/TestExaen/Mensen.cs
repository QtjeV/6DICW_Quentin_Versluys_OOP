using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExaen
{
    internal class Mensen
    {
        protected string _naam;
        protected int _leeftijd;
        protected string _beroep;

        public Mensen(string naam, int leeftijd, string beroep)
        {
            this._naam = naam;
            this._leeftijd = leeftijd;
            this._beroep = beroep;
        }

        public string Naam
        {
            set { _naam = value; }
            get { return _naam; }
        }
        public int Leeftijd
        {
            set { _leeftijd = value; }
            get { return _leeftijd; }
        }
        public string Beroep
        {
            set { _beroep = value; }
            get { return _beroep; }
        }


    }
}
