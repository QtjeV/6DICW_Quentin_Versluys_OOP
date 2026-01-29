using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3lagenmodel_test_h3_Versluys_Quentin
{
    internal class KindLengteVoorspeller
    {
        //velden
        private double _VaderLengte;
        private double _MoederLengte;
        private int _AantalVoorspellingen;

        //constructor
        public KindLengteVoorspeller()
        {
            _VaderLengte = 0.00;
            _MoederLengte = 0.00;
            _AantalVoorspellingen = 0;
        }

        //getters en setters
        public double VaderLengte
        {
            set { _VaderLengte = value; }
        }
        public double MoederLengte
        {
            set { _MoederLengte = value; }
        }
        public int AantalVoorspellingen
        {
            get { return _AantalVoorspellingen; }
            set { _AantalVoorspellingen = value; }
        }

        //berekent het gemiddelde van de ouders
        public double GemiddeldeOuders()
        {
            return (_VaderLengte + _MoederLengte) / 2.0;
        }

        //berekent de lengte van de dochter
        public double BerekenDochter()
        {
            return GemiddeldeOuders() - 6.5;
        }

        //berekent de lengte van de zoon
        public double BerekenZoon()
        {
            return GemiddeldeOuders() + 6.5;
        }
    }
}
