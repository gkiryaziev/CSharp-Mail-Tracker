using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MailTracker.Tracker.Models
{
    public class MainResult
    {
        [JsonProperty("status")]
        public int Status { get; set; }
        [JsonProperty("result")]
        public Dictionary<string, TrackResult> Results { get; set; }
    }
}
