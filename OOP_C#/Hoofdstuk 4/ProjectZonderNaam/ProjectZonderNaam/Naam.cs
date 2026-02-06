using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectZonderNaam
{
    public class Naam
    {
        private String _voornaam;
        private String _familienaam;

        public Naam(String voornaam, String familienaam)
        {
            _voornaam = voornaam;
            _familienaam = familienaam;
        }

        public String Voornaam
        {
            get { return _voornaam; }
            set { _voornaam = value; }
        }

        public String Familienaam
        {
            get { return _familienaam; }
            set { _familienaam = value; }
        }

        public String Volledigenaam(bool formeel)
        {
            String naam;

            if (formeel == true)
            {
                naam = _familienaam + " " + _voornaam;
            }
            else
            {
                naam = _voornaam + " " + _familienaam;
             }

            return naam;
        }

        public String Initialen()
        {
            String initialen = "";
                initialen += _voornaam[0] + ".";
                initialen += _familienaam[0] + ".";
            return initialen;
        }

        public String AlfaVoornaam()
        {
            String _string_voornaam = "";
            _string_voornaam += Voornaam.Replace("-", "").ToLower();
            _string_voornaam = _string_voornaam.Replace(" ", "");
            _string_voornaam = _string_voornaam.Replace("é", "e");
            _string_voornaam = _string_voornaam.Replace("è", "e");
            return _string_voornaam;
        }

        public String AlfaFamilienaam()
        {
            String _string_familienaam = "";
            _string_familienaam += Familienaam.Replace("-", "").ToLower();
            _string_familienaam = _string_familienaam.Replace(" ", "");
            _string_familienaam = _string_familienaam.Replace("é", "e");
            _string_familienaam = _string_familienaam.Replace("è", "e");
            return _string_familienaam;
        }
    }
}
