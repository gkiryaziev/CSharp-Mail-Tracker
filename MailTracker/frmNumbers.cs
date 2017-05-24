using MailTracker.Db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailTracker
{
    public partial class frmNumbers : Form
    {
        DbManager _dbm = null;

        public frmNumbers()
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
            btnAction.Text = "Update";
            txtNumber.Text = number;
            this.ShowDialog();
        }

        //----------------------------------
        // btnAction Click Method
        //----------------------------------
        private void btnAction_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
