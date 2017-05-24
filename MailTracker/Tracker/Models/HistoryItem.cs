using Newtonsoft.Json;

namespace MailTracker.Tracker.Models
{
    public class HistoryItem
    {
        [JsonProperty("date")]
        public string Date { get; set; }
        [JsonProperty("time")]
        public string Time { get; set; }
        [JsonProperty("place")]
        public string Place { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
