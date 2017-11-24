using MailTracker.Db.Models;
using System.Collections.Generic;

namespace MailTracker.Db
{
    interface IDbManager
    {
        // insert url
        // select all url's
        // select url by language
        string SelectUrl(string language);
        // update url
        // delete url

        // insert number
        void InsertNumber(string number);
        // select number's
        List<Numbers> SelectNumbers();
        // select number
        // update number
        void UpdateNumber(string oldNumber, string newNumber, int closed);
        // delete number
        void DeleteNumber(string number);
        // check if number is closed
        int IsNumberClosed(string number);

        // create tables
        void CreateTables();
    }
}
