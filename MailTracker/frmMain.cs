using MailTracker.Db;
using MailTracker.Db.Models;
using MailTracker.Tracker;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;

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
            mbtnLangGreek.Checked = true;
            language = "el";
            ssLoging.Image = imageListMain.Images[1];

            trm = new TrackerManager(dbm);

            try
            {
                UpdateNumberList();
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
            List<Numbers> nubmers = dbm.SelectNumbers();

            lstViewNumbers.Items.Clear();

            foreach (var n in nubmers)
            {
                ListViewItem item = new ListViewItem(n.Number);
                if (n.Closed == 1)
                {
                    item.BackColor = Color.Bisque;
                }
                lstViewNumbers.Items.Add(item);
            }

        }

        //----------------------------------
        // lstViewNumbers Selected Index Changed Method
        //----------------------------------
        private void lstViewNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstViewNumbers.SelectedItems.Count > 0)
                number = lstViewNumbers.SelectedItems[0].Text.Trim();
            else
                number = null;
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
            if (lstViewNumbers.SelectedItems.Count <= 0)
            {
                return;
            }

            if (number == null || number.Length != 13)
            {
                return;
            }

            try
            {
                // Logging
                tbtnUpdate.Enabled = false;
                ssLoging.Text = "Updating...";
                var stopwatch = new Stopwatch();
                stopwatch.Start();

                // geting data
                dgvResults.DataSource = await trm.Track(number, language);
                dgvResults.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                //dgvResults.Columns[0].HeaderText = "Date";

                // Logging
                stopwatch.Stop();
                long elapsed_time = stopwatch.ElapsedMilliseconds;
                ssLoging.Text = $"Done. ({elapsed_time} ms.)";
                tbtnUpdate.Enabled = true;
            }
            catch (Exception ex)
            {
                dgvResults.DataSource = null;
                ssLoging.Text = "Error!";
                return;
            }
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
        // numbersCxtMenu btnEdit Click Method
        //----------------------------------
        private void numbersCxtMenu_btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(number))
            {
                return;
            }

            if (lstViewNumbers.SelectedItems.Count <= 0)
            {
                return;
            }

            using (frmNumber n = new frmNumber())
            {
                n.Owner = this;
                n.OpenForm(dbm, number);
            }
        }

        //----------------------------------
        // numbersCxtMenu btnDelete Click Method
        //----------------------------------
        private void numbersCxtMenu_btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(number))
            {
                return;
            }

            if (lstViewNumbers.SelectedItems.Count <= 0)
            {
                return;
            }

            try
            {
                dbm.DeleteNumber(number);
                UpdateNumberList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}

// TODO: add settings (db, debug, url's)
// TODO: add focus and read from clipboard when new
// TODO: doubleclick for editing
// TODO: message box on delete
// TODO: update & update all
// TODO: -- add indication for closed
// TODO: local storage
// TODO: read from local storage when click
// TODO: backup database
// TODO: report generator
// TODO: -- add closed to number form
