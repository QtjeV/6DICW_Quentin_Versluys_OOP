using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExaen
{
    internal class spaceships
    {
        private Leiders _leider;
        private string _naam;

        public spaceships(string naam, Leiders leider)
        {
            this._naam = naam;
            this._leider = leider;
        }

        public Leiders Leider
        {
            set { _leider = value; }
            get { return _leider; }
        }

        public string Naam
        {
            set { _naam = value; }
            get { return _naam; }
        }


    }
}
