using System;
using System.Collections.Generic;
using System.Text;

namespace CocktailUWPNew
{
    public class StorageContainer
    {
        /*private static StorageContainer _instance = null;

        static internal StorageContainer Instance()
        {
            if (_instance == null)
                _instance = new StorageContainer();

            return _instance;
        }

        private StorageContainer()
        {
            categories = new List<Category>
            {
                new Category(1, "Alcohol"),
                new Category(2, "Non alcohol")
            };
            cocktails = new List<Cocktail>
            {
                new Cocktail(1, "43 Aardbeien", "Stamp de aardbeien fijn en doe deze in een cocktailglas met ijs. Schenk vervolgens de ingredienten in het glas en roer stevig.", 12.7, 1, 0),
                new Cocktail(2, "43 Bitter", "Goed shaken met ijs en serveren in een cocktailglas.", 24.9, 1, 0),
                new Cocktail(3, "43 Blanco", "Schudden en schenken over ijsblokjes.", 8, 1, 0)
            };
        }

        #region data
        public List<Allergy> allergies = new List<Allergy>
        {
        };

        public List<Category> categories = new List<Category>
        {
            new Category(1, "Alcohol"),
            new Category(2, "Non alcohol")
        };

        

        public List<AllergyIngredient> allergyIngredients = new List<AllergyIngredient>
        {

        };

        public List<Ingredient> ingredients = new List<Ingredient>
        {
            new Ingredient(1, "Wodka"),
            new Ingredient(2, "Licor 43"),
            new Ingredient(3, "Cointreau"),
            new Ingredient(4, "Aardbeien"),
            new Ingredient(5, "7 Up"),
            new Ingredient(6, "Ijs"),
            new Ingredient(7, "Kruidenbitter"),
            new Ingredient(8, "Melk")
        };

        public List<Glass> glasses = new List<Glass>
        {
            new Glass(1, "Gin tonic"),
            new Glass(2, "Hurricane"),
            new Glass(3, "Martini"),
            new Glass(4, "Margarita"),
            new Glass(5, "Bacardi"),
            new Glass(6, "Schot Zwiesel"),
            new Glass(7, "Royal Leerdam"),
            new Glass(8, "Longdrink"),
            new Glass(9, "Shot"),
            new Glass(10, "Tiki"),
            new Glass(11, "Tumbler"),
            new Glass(0, "Onbekend")
        };

        public List<User> users = new List<User>
        {
            new User("minoruser", "password", new DateTime(2001, 4, 13)),
            new User("majoruser", "pass", new DateTime(1999, 3, 23)),
            new User("jurriaan", "roelen", new DateTime(2000, 4, 4))
        };

        public System.Collections.Generic.List<Cocktail> cocktails = new System.Collections.Generic.List<Cocktail>
        {
            new Cocktail(1, "43 Aardbeien", "Stamp de aardbeien fijn en doe deze in een cocktailglas met ijs. Schenk vervolgens de ingredienten in het glas en roer stevig.", 12.7, 1, 0),
            new Cocktail(2, "43 Bitter", "Goed shaken met ijs en serveren in een cocktailglas.", 24.9, 1, 0),
            new Cocktail(3, "43 Blanco", "Schudden en schenken over ijsblokjes.", 8, 1, 0)
        };

        public List<CocktailIngredient> cocktailIngredients = new List<CocktailIngredient>
        {
            new CocktailIngredient(1, 1, 1, "30 ml"),
            new CocktailIngredient(2, 1, 2, "10 ml"),
            new CocktailIngredient(3, 1, 3, "10 ml"),
            new CocktailIngredient(4, 1, 4, "2"),
            new CocktailIngredient(5, 1, 5, "1"),
            new CocktailIngredient(6, 1, 6, "1"),
            new CocktailIngredient(7, 2, 2, "60 ml"),
            new CocktailIngredient(8, 2, 7, "30 ml"),
            new CocktailIngredient(9, 2, 6, "2"),
            new CocktailIngredient(10, 3, 2, "30 ml"),
            new CocktailIngredient(11, 3, 8, "90 ml"),
            new CocktailIngredient(12, 3, 6, "1")
        };
        #endregion
/*
        #region findPredicate
        public Allergy FindAllergy(Predicate<Allergy> predicate)
        {
            return allergies.Find(predicate);
        }

        public AllergyIngredient FindAllergyIngredient(Predicate<AllergyIngredient> predicate)
        {
            return allergyIngredients.Find(predicate);
        }

        public Category FindCategory(Predicate<Category> predicate)
        {
            return categories.Find(predicate);
        }

        public Cocktail FindCocktail(Predicate<Cocktail> predicate)
        {
            return cocktails.Find(predicate);
        }

        public CocktailIngredient FindCocktailIngredient(Predicate<CocktailIngredient> predicate)
        {
            return cocktailIngredients.Find(predicate);
        }

        public Glass FindGlass(Predicate<Glass> predicate)
        {
            return glasses.Find(predicate);
        }

        public Ingredient FindIngredient(Predicate<Ingredient> predicate)
        {
            return ingredients.Find(predicate);
        }

        public User FindUser(Predicate<User> predicate)
        {
            return users.Find(predicate);
        }
        #endregion

        #region
        public List<Cocktail> FindMultiCocktail(Predicate<Cocktail> predicate)
        {
            return cocktails.FindAll(predicate);
        }
        #endregion

        #region findById
        public Allergy FindAllergy(int id)
        {
            return FindAllergy(a => a.Id == id);
        }

        public AllergyIngredient FindAllergyIngredient(int id)
        {
            return FindAllergyIngredient(ai => ai.Id == id);
        }

        public Category FindCategory(int id)
        {
            return FindCategory(c => c.Id == id);
        }

        public Cocktail FindCocktail(int id)
        {
            return FindCocktail(c => c.Id == id);
        }

        public CocktailIngredient FindCocktailIngredient(int id)
        {
            return FindCocktailIngredient(ci => ci.Id == id);
        }

        public Glass FindGlass(int id)
        {
            return FindGlass(g => g.Id == id);
        }

        public Ingredient FindIngredient(int id)
        {
            return FindIngredient(i => i.Id == id);
        }

        public User FindUser(int id)
        {
            return FindUser(u => u.Id == id);
        }
        #endregion
        */
    }
}
