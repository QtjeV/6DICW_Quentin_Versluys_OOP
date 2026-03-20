using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailBar
{
    internal class Cocktail
    {
        private String _naam;
        private decimal _kostprijs;
        private List<Ingredient> _ingredienten;

        public Cocktail(String naam, decimal kostprijs)
        {
            _naam = naam;
            _kostprijs = kostprijs;
            _ingredienten = new List<Ingredient>();
        }

        public String Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }

        public decimal Kostprijs
        {
            get { return _kostprijs; }
            set { _kostprijs = value; }
        }

        public List<Ingredient> Ingredienten
        {
            get { return _ingredienten; }
        }

        public void VoegIngredientToe(Ingredient ingredient)
        {
            _ingredienten.Add(ingredient);
        }

        public int HoeveelIngredienten()
        {
            return _ingredienten.Count;
        }

        public int InhoudCocktail()
        {
            int inhoud = 0;
            foreach (Ingredient ingredient in _ingredienten)
            {
                inhoud += ingredient.Hoeveelheid;
            }
            return inhoud;
        }

        public int HoeveelAlcoholischeIngredienten()
        {
            int aantal = 0;
            foreach (Ingredient ingredient in _ingredienten)
            {
                if (ingredient.IsAlcoholisch())
                {
                    aantal++;
                }
            }
            return aantal;
        }

        public bool IsAlcoholisch()
        {
            return HoeveelAlcoholischeIngredienten() > 0;
        }

        public String AlleIngredienten()
        {
            String alleIngredienten = "";
            foreach (Ingredient ingredient in _ingredienten)
            {
                alleIngredienten += ingredient.Naam + " ";
            }
            return alleIngredienten;
        }

        public Ingredient GeefIngredient(int index)
        {
            if (index >= 0 && index < _ingredienten.Count)
            {
                return _ingredienten[index];
            }
            else
            {
                return null;
            }
        }

        public String GeefNaamIngredient(int index)
        {
            if (index >= 0 && index < _ingredienten.Count)
            {
                return _ingredienten[index].Naam;
            }
            else
            {
                return null;
            }
        }

        public void VerwijderIngredient(int index)
        {
            if (index >= 0 && index < _ingredienten.Count)
            {
                _ingredienten.RemoveAt(index);
            }
        }

        public void MaakAlcoholVrij(decimal nieuweprijs)
        {
            for (int i = 0; i < _ingredienten.Count; i++)
            {
                if (_ingredienten[i].IsAlcoholisch())
                {
                    _ingredienten.RemoveAt(i);
                    i--;
                }
            }
            _naam += " ( - alcoholvrij)";
            _kostprijs = _kostprijs - nieuweprijs;
        }

        public double Alcoholpercentage()
        {
            double totaalAlcohol = 0;
            int totaalInhoud = InhoudCocktail();
            foreach (Ingredient ingredient in _ingredienten)
            {
                totaalAlcohol += ingredient.Hoeveelheid * ingredient.Alcoholpercentage / 100;
            }
            return (totaalAlcohol / totaalInhoud) * 100;
        }

        public List<Ingredient> AlcoholischeIngredienten()
        {
            List<Ingredient> alcoholischeIngredienten = new List<Ingredient>();
            foreach (Ingredient ingredient in _ingredienten)
            {
                if (ingredient.IsAlcoholisch())
                {
                    alcoholischeIngredienten.Add(ingredient);
                }
            }
            return alcoholischeIngredienten;
        }

        public List<Ingredient> NietAlcoholischeIngredienten()
        {
            List<Ingredient> nietAlcoholischeIngredienten = new List<Ingredient>();
            foreach (Ingredient ingredient in _ingredienten)
            {
                if (!ingredient.IsAlcoholisch())
                {
                    nietAlcoholischeIngredienten.Add(ingredient);
                }
            }
            return nietAlcoholischeIngredienten;
        }


    }
}
