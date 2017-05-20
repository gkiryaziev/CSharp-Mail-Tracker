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
        DbManager _dbm = null;
        // track number
        string _number;

        bool debug = false;

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

            string responseString = await response.Content.ReadAsStringAsync();

            return jsonToObj(responseString);
        }

        //----------------------------------
        // private JsonToObj Method
        //----------------------------------
        private HistoryItem[] jsonToObj(string json)
        {
            MainResult mainResult;

            try
            {
                mainResult = JsonConvert.DeserializeObject<MainResult>(json);
            }
            catch (Exception ex)
            {
                if (debug)
                {
                    MessageBox.Show(ex.Message, $"{_number}", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show($"No results found!", $"{_number}", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return null;
            }

            return mainResult.Result[_number].Result;
        }
    }
}
