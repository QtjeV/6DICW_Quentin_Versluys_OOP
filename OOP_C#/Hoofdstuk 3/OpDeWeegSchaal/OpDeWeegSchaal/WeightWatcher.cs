using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpDeWeegschaal
{
    public class WeightWatcher
    {
        private int _gewicht;
        private double _grootte;

        public WeightWatcher(int gewicht, double grootte)
        {
            _gewicht = gewicht;
            _grootte = grootte;
        }

        public int Gewicht
        {
            get { return _gewicht; }
            set { _gewicht = value; }
        }

        public double Grootte
        {
            get { return _grootte; }
        }

        public double GeefBMI()
        {
            return _gewicht / (_grootte * _grootte);
        }

        public String GeefStatus()
        {
            double bmi = GeefBMI();
            if (bmi < 20)
            {
                return "Ondergewicht";
            }
            else if (bmi >= 20 && bmi < 25)
            {
                return "Ok";
            }
            else if (bmi >= 25 && bmi < 30)
            {
                return "Overgewicht";
            }
            else
            {
                return "Obees";
            }
        }

    }
}
