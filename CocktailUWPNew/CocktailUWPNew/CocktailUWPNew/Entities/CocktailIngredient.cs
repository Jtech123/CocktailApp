using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace CocktailUWPNew
{
    public class CocktailIngredient
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int Cocktail { get; }
        public int Ingredient { get; }
        public string Amount { get; }

        public CocktailIngredient()
        {

        }

        public CocktailIngredient(int cocktail, int ingredient, string amount)
        {
            Cocktail = cocktail;
            Ingredient = ingredient;
            Amount = amount;
        }

        public static void FillDatabase()
        {
            List<CocktailIngredient> cocktailIngredients = new List<CocktailIngredient>
            {
                new CocktailIngredient(1, 1, "30 ml"),
                new CocktailIngredient(1, 2, "10 ml"),
                new CocktailIngredient(1, 3, "10 ml"),
                new CocktailIngredient(1, 4, "2"),
                new CocktailIngredient(1, 5, "1"),
                new CocktailIngredient(1, 6, "1"),
                new CocktailIngredient(2, 2, "60 ml"),
                new CocktailIngredient(2, 7, "30 ml"),
                new CocktailIngredient(2, 6, "2"),
                new CocktailIngredient(3, 2, "30 ml"),
                new CocktailIngredient(3, 6, "90 ml"),
                new CocktailIngredient(3, 8, "1")
            };

            DatabaseHandler.Instance().GetConnection().InsertAll(cocktailIngredients);
        }
    }
}
