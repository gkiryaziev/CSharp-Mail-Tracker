using Dapper;
using MailTracker.Db.Models;
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
        public string GetUrl(string language)
        {
            using (SQLiteConnection db = new SQLiteConnection(connString))
            {
                return db.Query<Url>("select url as URL from url where language = @language",
                    new { language }).SingleOrDefault().URL;
            }
        }
    }
}
