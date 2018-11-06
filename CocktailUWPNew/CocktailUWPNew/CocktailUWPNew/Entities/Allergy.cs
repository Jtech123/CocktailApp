using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace CocktailUWPNew
{
    public class Allergy
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; }

        public Allergy()
        {

        }

        public Allergy(string name)
        {
            Name = name;
        }

        public static void FillDatabase()
        {

        }
    }
}
