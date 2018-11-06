using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace CocktailUWPNew
{
    public class AllergyIngredient
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int AllergyId { get; set; }
        public int IngredientId { get; set; }

        public AllergyIngredient()
        {

        }

        public AllergyIngredient(int allergy, int ingredient)
        {
            AllergyId = allergy;
            IngredientId = ingredient;
        }

        public static void FillDatabase()
        {

        }
    }
}
