using MailTracker.Db;
using MailTracker.Tracker.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailTracker.Tracker
{
    public class TrackerManager : ITrackerManager
    {
        // Http client
        HttpClient client = new HttpClient();
        // Database manager
        DbManager _dbm;
        // track number
        string _number;

        public TrackerManager(DbManager dbm)
        {
            _dbm = dbm;
        }

        //----------------------------------
        // Track Method
        //----------------------------------
        public async Task<HistoryItem[]> Track(string number, string language)
        {
            _number = number;
            string URL = _dbm.GetUrl(language);

            Dictionary<string, string> values = new Dictionary<string, string>
            {
               { "number", number },
            };

            FormUrlEncodedContent content = new FormUrlEncodedContent(values);
            HttpResponseMessage response = await client.PostAsync(URL, content);

            return jsonToObj(await response.Content.ReadAsStringAsync());
        }

        //----------------------------------
        // private JsonToObj Method
        //----------------------------------
        private HistoryItem[] jsonToObj(string json)
        {
            MainResult result;

            try
            {
                result = JsonConvert.DeserializeObject<MainResult>(json);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

            return result.Results[_number].Items;
        }
    }
}
