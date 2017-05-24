using Newtonsoft.Json;

namespace MailTracker.Tracker.Models
{
    public class TrackResult
    {
        [JsonProperty("status")]
        public int Status { get; set; }
        [JsonProperty("result")]
        public HistoryItem[] Result { get; set; }
    }
}
