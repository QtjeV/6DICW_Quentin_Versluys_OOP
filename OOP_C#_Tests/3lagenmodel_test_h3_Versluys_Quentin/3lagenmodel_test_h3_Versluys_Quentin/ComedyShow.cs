using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3lagenmodel_test_h3_Versluys_Quentin
{
    internal class ComedyShow
    {
        private String _laatst;
        private int _aantal;
        private double _totaalScore;

        //constructor
        public ComedyShow() 
        {
            _laatst = "";
            _aantal = 0;
            _totaalScore = 0.0 ;
        }

        //voegt een show toe aan de comedyshow klasse
        public void Add(string naam, Double score)
        {
            _laatst = naam;
            _aantal++;
            _totaalScore+=score;

        }
        //berekent het gemiddelde van alle scores
        public double BerekenGemiddelde()
        {
            return _totaalScore / Convert.ToDouble(_aantal);
        }

        public String Laatst
        {
            set { _laatst = value; }
        }

        public int Aantal { 
            get { return _aantal; } 
            set { _aantal = value; }
        
        }
    }
}
