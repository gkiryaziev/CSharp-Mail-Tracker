using MailTracker.Db;
using MailTracker.Db.Models;
using MailTracker.Tracker;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;

namespace MailTracker
{
    public partial class frmMain : Form
    {
        // Database manager
        DbManager dbm = new DbManager("data.db3");
        // TrackerManager
        TrackerManager trm = null;

        string number, language;

        public frmMain()
        {
            InitializeComponent();
        }

        //----------------------------------
        // frmMain Load Method
        //----------------------------------
        private void frmMain_Load(object sender, EventArgs e)
        {
            // default language is English
            mbtnLangEnglish.Checked = true;
            language = "en";
            ssLoging.Image = imageListMain.Images[0];

            trm = new TrackerManager(dbm);
            FillNumberList();
            lstNumbers.SelectedIndex = 0;
        }

        //----------------------------------
        // Fill List with Numbers Method
        //----------------------------------
        private void FillNumberList()
        {
            List<Numbers> nubmers = dbm.GetNumbers();

            foreach (var n in nubmers)
            {
                lstNumbers.Items.Add(n.Number);
            }
        }

        //----------------------------------
        // lstNumbers Selected Index Changed Method
        //----------------------------------
        private void lstNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            number = lstNumbers.GetItemText(lstNumbers.SelectedItem);
        }

        //----------------------------------
        // tbtnUpdate Click Method
        //----------------------------------
        private async void tbtnUpdate_Click(object sender, EventArgs e)
        {
            if (number == null || number.Length != 13)
            {
                return;
            }

            // Logging
            ssLoging.Text = "Updating...";
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            try
            {
                dgvResults.DataSource = await trm.Track(number, language);
            }
            catch (Exception ex)
            {
                dgvResults.DataSource = null;
                ssLoging.Text = "Error!";
                return;
            }

            // Logging
            stopwatch.Stop();
            long elapsed_time = stopwatch.ElapsedMilliseconds;
            ssLoging.Text = $"Done. ({elapsed_time} ms.)";
        }

        //----------------------------------
        // mbtnLangEnglish Click Method
        //----------------------------------
        private void mbtnLangEnglish_Click(object sender, EventArgs e)
        {
            mbtnLangEnglish.Checked = true;
            mbtnLangGreek.Checked = false;
            language = "en";
            ssLoging.Image = imageListMain.Images[0];
        }

        //----------------------------------
        // mbtnLangGreek Click Method
        //----------------------------------
        private void mbtnLangGreek_Click(object sender, EventArgs e)
        {
            mbtnLangEnglish.Checked = false;
            mbtnLangGreek.Checked = true;
            language = "el";
            ssLoging.Image = imageListMain.Images[1];
        }
    }
}

// TODO: add settings (db, debug, url's)
// TODO: numbers (add, update, delete)
