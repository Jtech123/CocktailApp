using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace CocktailUWPNew
{
    public class Glass
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; }

        public Glass()
        {

        }

        public Glass(string name)
        {
            Name = name;
        }

        public static void FillDatabase()
        {
            List<Glass> glasses = new List<Glass>
            {
                new Glass("Onbekend"),
                new Glass("Gin tonic"),
                new Glass("Hurricane"),
                new Glass("Martini"),
                new Glass("Margarita"),
                new Glass("Bacardi"),
                new Glass("Schot Zwiedel"),
                new Glass("Royal Leerdam"),
                new Glass("Longdrink"),
                new Glass("Shot"),
                new Glass("Tiki"),
                new Glass("Tumbler")
            };

            DatabaseHandler.Instance().GetConnection().InsertAll(glasses);
        }
    }
}
