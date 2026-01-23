using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoles
{
    internal class Lowie
    {
        private int _leeftijd;
        public Lowie()
        {
            _leeftijd = 17;
        }

        public int Leeftijd
        {
            get { return _leeftijd; }
            set { _leeftijd = value; }

        }
    }
}
