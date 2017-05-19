using MailTracker.Tracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailTracker.Tracker
{
    interface ITrackerManager
    {
        Task<HistoryItem[]> Track(string number, string language);
    }
}
