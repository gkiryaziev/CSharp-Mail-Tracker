using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
