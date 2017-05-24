using MailTracker.Tracker.Models;
using System.Threading.Tasks;

namespace MailTracker.Tracker
{
    interface ITrackerManager
    {
        Task<HistoryItem[]> Track(string number, string language);
    }
}
