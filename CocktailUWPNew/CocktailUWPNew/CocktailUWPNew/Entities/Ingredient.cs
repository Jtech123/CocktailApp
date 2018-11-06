using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace CocktailUWPNew
{
    public class Ingredient
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; }

        public Ingredient()
        {

        }

        public Ingredient(string name)
        {
            Name = name;
        }

        public static void FillDatabase()
        {
            List<Ingredient> ingredients = new List<Ingredient>
            {
                new Ingredient("Wodka"),
                new Ingredient("Licor 43"),
                new Ingredient("Cointreau"),
                new Ingredient("Aardbeien"),
                new Ingredient("7 Up"),
                new Ingredient("Ijs"),
                new Ingredient("Kruidenbitter"),
                new Ingredient("Melk")
            };

            DatabaseHandler.Instance().GetConnection().InsertAll(ingredients);
        }
    }
}
