using Newtonsoft.Json;
using System.Collections.Generic;

namespace MailTracker.Tracker.Models
{
    public class MainResult
    {
        [JsonProperty("status")]
        public int Status { get; set; }
        [JsonProperty("result")]
        public Dictionary<string, TrackResult> Result { get; set; }
    }
}
