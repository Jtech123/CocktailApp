using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace CocktailUWPNew
{
    public abstract class Entity
    {
        [PrimaryKey]
        public int Id { get; set; }
        
        public Entity(int id)
        {
            Id = id;
        }
    }
}
