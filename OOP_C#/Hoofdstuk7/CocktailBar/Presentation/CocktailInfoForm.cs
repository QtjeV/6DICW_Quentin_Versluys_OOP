using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business;

namespace Presentation
{
    public partial class CocktailInfoForm : Form
    {
        private Cocktail _cocktail;

        public CocktailInfoForm(Cocktail cocktail)
        {
            InitializeComponent();

            _cocktail = cocktail;

            naamTextBox.Text = _cocktail.Naam;
            kostprijsTextBox.Text = _cocktail.Kostprijs.ToString("C");
            inhoudTextBox.Text = _cocktail.InhoudCocktail().ToString();
            alcoholpercentageTextBox.Text = _cocktail.Alcoholpercentage().ToString("P0");
            foreach (Ingredient ingredient in _cocktail.Ingredienten)
            {
                if (ingredient.IsAlcoholisch())
                {
                    AlcaholischeBox.Items.Add(ingredient);
                }
                else
                {
                    NietAlcaholischeBox.Items.Add(ingredient);
                }
            }
        }

        private void toonButton_Click(object sender, EventArgs e)
        {
            Ingredient ingredient = (Ingredient)AlcaholischeBox.SelectedItem;
            IngredientForm formulier = new IngredientForm(ingredient);
            formulier.Show();
        }

        private void toonButton2_Click(object sender, EventArgs e)
        {
            Ingredient ingredient = (Ingredient)NietAlcaholischeBox.SelectedItem;
            IngredientForm formulier = new IngredientForm(ingredient);
            formulier.Show();
        }

        private void pittigerButton_Click(object sender, EventArgs e)
        {
            _cocktail.MaakPittiger();
            inhoudTextBox.Text = _cocktail.InhoudCocktail().ToString();
            alcoholpercentageTextBox.Text = _cocktail.Alcoholpercentage().ToString("P0");
            AlcaholischeBox.DataSource = null;
            AlcaholischeBox.Items.Clear();
            NietAlcaholischeBox.DataSource = null;
            NietAlcaholischeBox.Items.Clear();

            _cocktail.Ingredienten.RemoveAll(i => i.Hoeveelheid <= 0);
            foreach (Ingredient ingredient in _cocktail.Ingredienten)
            {
                if (ingredient.IsAlcoholisch())
                {
                    AlcaholischeBox.Items.Add(ingredient);
                }
                else
                {
                    NietAlcaholischeBox.Items.Add(ingredient);
                }
            }
        }

    }
}
