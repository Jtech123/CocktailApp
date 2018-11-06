using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using SQLite;

namespace CocktailUWPNew
{
    public class DatabaseHandler
    {
        private static DatabaseHandler _instance = null;
        private string dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "cocktails.db3");
        private SQLiteConnection connection = null;
        public User currentUser = null;

        static internal DatabaseHandler Instance()
        {
            if (_instance == null)
                _instance = new DatabaseHandler();

            return _instance;
        }

        private DatabaseHandler()
        {
            if (connection == null)
                connection = new SQLiteConnection(dbpath);
            connection.CreateTable<Allergy>();
            connection.CreateTable<AllergyIngredient>();
            connection.CreateTable<Category>();
            connection.CreateTable<Cocktail>();
            connection.CreateTable<CocktailIngredient>();
            connection.CreateTable<Glass>();
            connection.CreateTable<Ingredient>();
            connection.CreateTable<User>();
        }

        public SQLiteConnection GetConnection()
        {
            return connection;
        }
    }
}
