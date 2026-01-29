using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComedyShow
{

    internal class Comedyshow
    {
        private String _laatste;
        private int _aantal;
        private double _totaalscore;

        public Comedyshow()
        {
            _laatste = "";
            _aantal = 0;
            _totaalscore = 0.0;
        }


        public void Add(String naam, double score)
        {
            _laatste = naam;
            _aantal++;
            _totaalscore += score;
        }

        public double berekenGemiddelde()
        {
            return _totaalscore / _aantal;
        }

        public String Laatste {
            get { return _laatste; }
        }

        public int Aantal {
            get { return _aantal; }
            set { _aantal = value; }
        }
    }

}
