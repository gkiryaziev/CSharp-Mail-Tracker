using Dapper;
using MailTracker.Db.Models;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;

namespace MailTracker.Db
{
    public class DbManager : IDbManager
    {
        string connString;

        public DbManager(string dbName)
        {
            connString = $"Data Source={dbName};Version=3;";
        }

        // ----------------------------------
        // Get URL by language
        // ----------------------------------
        public string SelectUrl(string language)
        {
            using (SQLiteConnection db = new SQLiteConnection(connString))
            {
                return db.Query<Url>("select url as URL from url where language = @language",
                    new { language }).SingleOrDefault().URL;
            }
        }

        // ----------------------------------
        // Get All Numbers
        // ----------------------------------
        public List<Numbers> SelectNumbers()
        {
            using (SQLiteConnection db = new SQLiteConnection(connString))
            {
                return db.Query<Numbers>("select id as Id, number as Number, closed as Closed from number order by id").ToList();
            }
        }

        // ----------------------------------
        // Create Tables If Not Exists
        // ----------------------------------
        public void CreateTables()
        {
            using (SQLiteConnection db = new SQLiteConnection(connString))
            {
                var i = db.Execute(@"CREATE TABLE IF NOT EXISTS url(
                    id       INTEGER     PRIMARY KEY AUTOINCREMENT,
                    language VARCHAR(50) UNIQUE NOT NULL,
                    url      TEXT        NOT NULL);");

                var n = db.Execute(@"CREATE TABLE IF NOT EXISTS number (
                    id     INTEGER      PRIMARY KEY AUTOINCREMENT,
                    number VARCHAR (20) NOT NULL,
                    closed INTEGER      DEFAULT (0));");
            }
        }

        // ----------------------------------
        // Insert Number Method
        // ----------------------------------
        public void InsertNumber(string number)
        {
            using (SQLiteConnection db = new SQLiteConnection(connString))
            {
                db.Execute("INSERT INTO number(number) VALUES(?);", new { number });
            }
        }

        // ----------------------------------
        // Update Number Method
        // ----------------------------------
        public void UpdateNumber(string oldNumber, string newNumber)
        {
            using (SQLiteConnection db = new SQLiteConnection(connString))
            {
                db.Execute("UPDATE number SET number = ? WHERE number = ?;", new { newNumber, oldNumber });
            }
        }

        // ----------------------------------
        // Delete Number Method
        // ----------------------------------
        public void DeleteNumber(string number)
        {
            using (SQLiteConnection db = new SQLiteConnection(connString))
            {
                db.Execute("DELETE FROM number WHERE number = ?;", new { number });
            }
        }
    }
}
