using MailTracker.Db.Models;
using System.Collections.Generic;

namespace MailTracker.Db
{
    interface IDbManager
    {
        // insert url
        // select all url's
        // select url by language
        string GetUrl(string language);
        // update url
        // delete url

        // insert number
        // select number's
        List<Numbers> GetNumbers();
        // select number
        // update number
        // delete number
    }
}
