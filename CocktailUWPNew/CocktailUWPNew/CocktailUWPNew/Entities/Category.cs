using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;

namespace CocktailUWPNew
{
    public class Category
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [Unique]
        public string Name { get; set; }

        public Category()
        {

        }

        public Category(string name)
        {
            Name = name;
        }

        public static void FillDatabase()
        {
            List<Category> categories = new List<Category>
            {
                new Category("Non-alcohol"),
                new Category("Alcohol")
            };
            DatabaseHandler.Instance().GetConnection().InsertAll(categories);
        }
    }
}
