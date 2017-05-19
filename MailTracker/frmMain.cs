using MailTracker.Db;
using MailTracker.Tracker;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MailTracker
{
    public partial class frmMain : Form
    {
        // Languages
        Dictionary<string, string> languages = new Dictionary<string, string>()
        {
            { "English", "en" },
            { "Ελληνικά", "el" }
        };

        // TrackerManager
        TrackerManager trm = null;

        public frmMain()
        {
            InitializeComponent();
        }

        //----------------------------------
        // async btnTrack Click Method
        //----------------------------------
        private async void btnTrack_Click(object sender, EventArgs e)
        {
            if (txtTrackNumber.TextLength != 13)
            {
                return;
            }

            dgvResults.DataSource = await trm.Track(txtTrackNumber.Text, languages[cmbLanguage.Text]);
        }

        //----------------------------------
        // frmMain Load Method
        //----------------------------------
        private void frmMain_Load(object sender, EventArgs e)
        {
            trm = new TrackerManager(new DbManager("data.db3"));

            cmbLanguage.Items.Add("English");
            cmbLanguage.Items.Add("Ελληνικά");
            cmbLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLanguage.SelectedIndex = 0;
        }
    }
}
