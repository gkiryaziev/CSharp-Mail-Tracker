using MailTracker.Db;
using System;
using System.Windows.Forms;

namespace MailTracker
{
    public partial class frmNumber : Form
    {
        DbManager _dbm = null;
        bool closeForm = false;
        string _oldNumber = null;

        public frmNumber()
        {
            InitializeComponent();
        }

        //----------------------------------
        // Open Form Method (Add)
        //----------------------------------
        public void OpenForm(DbManager dbm)
        {
            _dbm = dbm;
            btnAction.Text = "Add";
            this.ShowDialog();
        }

        //----------------------------------
        // Open Form Method (Update)
        //----------------------------------
        public void OpenForm(DbManager dbm, string number)
        {
            _dbm = dbm;
            _oldNumber = number;
            btnAction.Text = "Update";
            txtNumber.Text = number;
            this.ShowDialog();
        }

        //----------------------------------
        // btnAction Click Method
        //----------------------------------
        private void btnAction_Click(object sender, EventArgs e)
        {
            frmMain f = (frmMain)this.Owner;

            switch (btnAction.Text)
            {
                case "Add":
                    {
                        AddRecord();
                        break;
                    }
                case "Update":
                    {
                        UpdateRecord();
                        break;
                    }
            }

            if (closeForm)
            {
                f.UpdateNumberList();
                this.Close();
            }
        }

        //----------------------------------
        // Add Record Method
        //----------------------------------
        private void AddRecord()
        {
            if (!string.IsNullOrEmpty(txtNumber.Text))
            {
                try
                {
                    _dbm.InsertNumber(txtNumber.Text);
                    closeForm = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        //----------------------------------
        // Update Record Method
        //----------------------------------
        private void UpdateRecord()
        {
            if (!string.IsNullOrEmpty(txtNumber.Text) && !string.IsNullOrEmpty(_oldNumber))
            {
                try
                {
                    _dbm.UpdateNumber(_oldNumber, txtNumber.Text);
                    closeForm = true;
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
