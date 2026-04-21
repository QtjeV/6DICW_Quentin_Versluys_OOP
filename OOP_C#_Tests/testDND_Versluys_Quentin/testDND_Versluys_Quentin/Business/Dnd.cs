using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDBusiness
{
    public class Dnd
    {
        private List<Karakter> _lstKarakters;

        public Dnd()
        {
            _lstKarakters = new List<Karakter>();
        }

        public List<Karakter> Karakters
        {
            get { return _lstKarakters; }
        }

        public bool Aanwezig(String naam)
        {
            foreach (Karakter karakter in _lstKarakters)
            {
                if (karakter.Naam == naam)
                {
                    return true;
                }
            }
            return false;
        }

        public Karakter GeefKarakter(String naam)
        {
            foreach (Karakter karakter in _lstKarakters)
            {
                if (karakter.Naam == naam)
                {
                    return karakter;
                }
            }
            return null;
        }

        public void VoegToe(String naam, int sterkte)
        {
            _lstKarakters.Add(new Karakter(naam, sterkte));
        }

    }
}
