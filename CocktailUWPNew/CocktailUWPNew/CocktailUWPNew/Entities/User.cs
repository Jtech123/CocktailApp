using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace CocktailUWPNew
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [Unique]
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsLock
        {
            get
            {
                return BirthDate.AddYears(18) > DateTime.Now;
            }
        }

        public User()
        {

        }

        public User(string username, string password, DateTime birthDate)
        {
            Username = username;
            Password = password;
            BirthDate = birthDate;
        }

        public static User Query(string query, object[] param)
        {
            return DatabaseHandler.Instance().GetConnection().FindWithQuery<User>(query, param);
        }

        public static User Login(string username, string password)
        {
            return Query("SELECT * FROM User WHERE Username = ? AND Password = ?", new object[] { username, password });
        }

        public static User Register(string username, string password, DateTime birthDate)
        {
            //Check if username is unique
            if (Query("SELECT * FROM User WHERE Username = ?", new object[] { username }) != null)
            {
                return null;
            }
            User u = new User(username, password, birthDate);
            DatabaseHandler.Instance().GetConnection().Insert(u);
            return Query("SELECT * FROM User WHERE Username = ? AND BirthDate = ?", new object[] { username, birthDate });
        }

        public static void FillDatabase()
        {
            List<User> users = new List<User>
            {
                new User("minoruser", "password", new DateTime(2001, 4, 13)),
                new User("majoruser", "pass", new DateTime(1999, 3, 23)),
                new User("jurriaan", "roelen", new DateTime(2000, 4, 4))
            };
            DatabaseHandler.Instance().GetConnection().InsertAll(users);
        }
    }
}
