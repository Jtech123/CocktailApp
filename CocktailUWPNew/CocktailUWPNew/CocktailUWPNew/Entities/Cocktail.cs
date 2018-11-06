using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace CocktailUWPNew
{
    public class Cocktail
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double AlcoholPercentage { get; set; }
        public int Category { get; set; }
        public int Glass { get; set; }
        public string Url { get; set; }

        public Cocktail()
        {

        }

        public Cocktail(string name, string description, double alcoholPercentage, int category, int glass, string url)
        {
            Name = name;
            Description = description;
            AlcoholPercentage = alcoholPercentage;
            Category = category;
            Glass = glass;
            Url = url;
        }

        public static List<Cocktail> GetAll()
        {
            if (DatabaseHandler.Instance().currentUser.IsLock)
                return DatabaseHandler.Instance().GetConnection().Query<Cocktail>("SELECT * FROM Cocktail WHERE Category = 2 OR AlcoholPercentage = 0");
            else
                return DatabaseHandler.Instance().GetConnection().Query<Cocktail>("SELECT * FROM Cocktail");
        }

        public static void FillDatabase()
        {
            List<Cocktail> cocktails = new List<Cocktail>
            {
                new Cocktail("43 Aardbeien", "Stamp de aardbeien fijn en doe deze in een cocktailglas met ijs. Schenk vervolgens de ingredienten in het glas en roer stevig.", 12.7, 1, 1, "https://www.cocktailgids.nl/images/43-aardbeien.jpg"),
                new Cocktail("43 Bitter", "Goed shaken met ijs en serveren in een cocktailglas.", 24.9, 1, 1, "https://www.licor43.nl/wp-content/uploads/2016/06/balon-43_1048x1048_White-V1-533x0-c-default.jpg"),
                new Cocktail("43 Blanco", "Schudden en schenken over ijsblokjes", 8, 1, 1, "https://via.placeholder.com/1920x1080")
            };

            DatabaseHandler.Instance().GetConnection().InsertAll(cocktails);
        }
    }
}
