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
            // create database and tables if not exists
            dbm.CreateTables();

            // default language is English
            mbtnLangEnglish.Checked = true;
            language = "en";
            ssLoging.Image = imageListMain.Images[0];

            trm = new TrackerManager(dbm);

            try
            {
                UpdateNumberList();
                lstNumbers.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please add settings and restart.", "Empty database", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        //----------------------------------
        // Update List with Numbers Method
        //----------------------------------
        public void UpdateNumberList()
        {
            lstNumbers.Items.Clear();

            List<Numbers> nubmers = dbm.SelectNumbers();

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
        private void tbtnUpdate_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        //----------------------------------
        // Load Data Method
        //----------------------------------
        private async void LoadData()
        {
            if (number == null || number.Length != 13)
            {
                return;
            }

            // Logging
            tbtnUpdate.Enabled = false;
            ssLoging.Text = "Updating...";
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            try
            {
                dgvResults.DataSource = await trm.Track(number, language);
                dgvResults.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                //dgvResults.Columns[0].HeaderText = "Date";
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
            tbtnUpdate.Enabled = true;
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

        //----------------------------------
        // lstNumbers MouseDown Method
        //----------------------------------
        private void lstNumbers_MouseDown(object sender, MouseEventArgs e)
        {
            lstNumbers.SelectedIndex = lstNumbers.IndexFromPoint(e.X, e.Y);
        }

        //----------------------------------
        // numbersCxtMenu btnAdd Click Method
        //----------------------------------
        private void numbersCxtMenu_btnAdd_Click(object sender, EventArgs e)
        {
            using (frmNumber n = new frmNumber())
            {
                n.Owner = this;
                n.OpenForm(dbm);
            }
        }

        //----------------------------------
        // numbersCxtMenu btnUpdate Click Method
        //----------------------------------
        private void numbersCxtMenu_btnUpdate_Click(object sender, EventArgs e)
        {
            using (frmNumber n = new frmNumber())
            {
                if (string.IsNullOrEmpty(number))
                {
                    return;
                }

                n.Owner = this;
                n.OpenForm(dbm, number);
            }
        }

        //----------------------------------
        // numbersCxtMenu btnDelete Click Method
        //----------------------------------
        private void numbersCxtMenu_btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(number))
            {
                try
                {
                    dbm.DeleteNumber(number);
                    UpdateNumberList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }
    }
}

// TODO: add settings (db, debug, url's)
