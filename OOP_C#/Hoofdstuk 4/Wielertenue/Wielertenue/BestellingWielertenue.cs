using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wielertenue
{
    class BestellingWielertenue
    {
        private int _aantal;  // hoeveel stuks bestel je
        private bool _waterdichtZakje;  // is er in het truitje een waterdicht GSM-opbergzakje voorzien
        private bool _broek;  // neem je ook de wielerbroek (of anders enkel het wielertruitje)
        private bool _superZeem; // is de wielerbroek voorzien van een zeem met hogere kwaliteit

        public BestellingWielertenue(int aantal, bool waterdichtZakje, bool broek, bool superZeem)
        {
            _aantal = aantal;
            _waterdichtZakje = waterdichtZakje;
            _broek = broek;
            _superZeem = superZeem;
        }

        public int Aantal
        {
            get { return _aantal; }
            set { _aantal = value; }
        }
        public bool WaterdichtZakje
        {
            get { return _waterdichtZakje; }
            set { _waterdichtZakje = value; }
        }
        public bool Broek
        {
            get { return _broek; }
            set { _broek = value; }
        }
        public bool SuperZeem
        {
            get { return _superZeem; }
            set { _superZeem = value; }
        }
        public decimal GeefPrijs()
        {
            decimal prijsPerStuk = 0m;
            if (_broek)
                prijsPerStuk = 80m;
            else
                prijsPerStuk = 45m;
            if (_waterdichtZakje)
                prijsPerStuk += 3.50m;
            if (_broek && _superZeem)
                prijsPerStuk += 5.50m;

            decimal totaal = prijsPerStuk * _aantal;

            if (_aantal >= 5)
                totaal *= 0.9m;

            return totaal;
        }

    }
}
