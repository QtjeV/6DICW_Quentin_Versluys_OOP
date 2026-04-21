using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Karakter
    {
        private String _naam;
        private int _sterkte;

        public Karakter(string naam, int sterkte)
        {
            _naam = naam;
            _sterkte = sterkte;
        }

        public String Naam
        {
            get { return _naam; }
        }

        public int Sterkte
        {
            get { return _sterkte; }
        }
        public override String ToString()
        {
            return _naam;
        }
    }
}
