namespace MailTracker
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.lstNumbers = new System.Windows.Forms.ListBox();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.ssLoging = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.tbtnUpdate = new System.Windows.Forms.ToolStripButton();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.mbtnFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtnLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtnLangEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtnLangGreek = new System.Windows.Forms.ToolStripMenuItem();
            this.imageListMain = new System.Windows.Forms.ImageList(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.numbersCxtMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.numbersCxtMenu_btnAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.numbersCxtMenu_btnUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.numbersCxtMenu_btnDelete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.statusStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.numbersCxtMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvResults
            // 
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResults.Location = new System.Drawing.Point(0, 0);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.Size = new System.Drawing.Size(531, 380);
            this.dgvResults.TabIndex = 4;
            // 
            // lstNumbers
            // 
            this.lstNumbers.ContextMenuStrip = this.numbersCxtMenu;
            this.lstNumbers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstNumbers.FormattingEnabled = true;
            this.lstNumbers.Location = new System.Drawing.Point(0, 0);
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.Size = new System.Drawing.Size(173, 380);
            this.lstNumbers.TabIndex = 5;
            this.lstNumbers.SelectedIndexChanged += new System.EventHandler(this.lstNumbers_SelectedIndexChanged);
            this.lstNumbers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstNumbers_MouseDown);
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssLoging});
            this.statusStripMain.Location = new System.Drawing.Point(0, 435);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(708, 22);
            this.statusStripMain.TabIndex = 6;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // ssLoging
            // 
            this.ssLoging.Name = "ssLoging";
            this.ssLoging.Size = new System.Drawing.Size(10, 17);
            this.ssLoging.Text = " ";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 52);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lstNumbers);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvResults);
            this.splitContainer1.Size = new System.Drawing.Size(708, 380);
            this.splitContainer1.SplitterDistance = 173;
            this.splitContainer1.TabIndex = 7;
            // 
            // toolStripMain
            // 
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnUpdate,
            this.toolStripSeparator1});
            this.toolStripMain.Location = new System.Drawing.Point(0, 24);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripMain.Size = new System.Drawing.Size(708, 25);
            this.toolStripMain.TabIndex = 9;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // tbtnUpdate
            // 
            this.tbtnUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbtnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("tbtnUpdate.Image")));
            this.tbtnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnUpdate.Name = "tbtnUpdate";
            this.tbtnUpdate.Size = new System.Drawing.Size(49, 22);
            this.tbtnUpdate.Text = "Update";
            this.tbtnUpdate.Click += new System.EventHandler(this.tbtnUpdate_Click);
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbtnFile,
            this.mbtnLanguage});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStripMain.Size = new System.Drawing.Size(708, 24);
            this.menuStripMain.TabIndex = 8;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // mbtnFile
            // 
            this.mbtnFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbtnExit});
            this.mbtnFile.Name = "mbtnFile";
            this.mbtnFile.Size = new System.Drawing.Size(37, 20);
            this.mbtnFile.Text = "&File";
            // 
            // mbtnExit
            // 
            this.mbtnExit.Name = "mbtnExit";
            this.mbtnExit.Size = new System.Drawing.Size(92, 22);
            this.mbtnExit.Text = "&Exit";
            // 
            // mbtnLanguage
            // 
            this.mbtnLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbtnLangEnglish,
            this.mbtnLangGreek});
            this.mbtnLanguage.Name = "mbtnLanguage";
            this.mbtnLanguage.Size = new System.Drawing.Size(71, 20);
            this.mbtnLanguage.Text = "&Language";
            // 
            // mbtnLangEnglish
            // 
            this.mbtnLangEnglish.Name = "mbtnLangEnglish";
            this.mbtnLangEnglish.Size = new System.Drawing.Size(121, 22);
            this.mbtnLangEnglish.Text = "English";
            this.mbtnLangEnglish.Click += new System.EventHandler(this.mbtnLangEnglish_Click);
            // 
            // mbtnLangGreek
            // 
            this.mbtnLangGreek.Name = "mbtnLangGreek";
            this.mbtnLangGreek.Size = new System.Drawing.Size(121, 22);
            this.mbtnLangGreek.Text = "Ελληνικά";
            this.mbtnLangGreek.Click += new System.EventHandler(this.mbtnLangGreek_Click);
            // 
            // imageListMain
            // 
            this.imageListMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListMain.ImageStream")));
            this.imageListMain.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListMain.Images.SetKeyName(0, "en");
            this.imageListMain.Images.SetKeyName(1, "el");
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // numbersCxtMenu
            // 
            this.numbersCxtMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numbersCxtMenu_btnAdd,
            this.numbersCxtMenu_btnUpdate,
            this.numbersCxtMenu_btnDelete});
            this.numbersCxtMenu.Name = "numbersCxtMenu";
            this.numbersCxtMenu.Size = new System.Drawing.Size(113, 70);
            // 
            // numbersCxtMenu_btnAdd
            // 
            this.numbersCxtMenu_btnAdd.Name = "numbersCxtMenu_btnAdd";
            this.numbersCxtMenu_btnAdd.Size = new System.Drawing.Size(152, 22);
            this.numbersCxtMenu_btnAdd.Text = "Add";
            this.numbersCxtMenu_btnAdd.Click += new System.EventHandler(this.numbersCxtMenu_btnAdd_Click);
            // 
            // numbersCxtMenu_btnUpdate
            // 
            this.numbersCxtMenu_btnUpdate.Name = "numbersCxtMenu_btnUpdate";
            this.numbersCxtMenu_btnUpdate.Size = new System.Drawing.Size(152, 22);
            this.numbersCxtMenu_btnUpdate.Text = "Update";
            this.numbersCxtMenu_btnUpdate.Click += new System.EventHandler(this.numbersCxtMenu_btnUpdate_Click);
            // 
            // numbersCxtMenu_btnDelete
            // 
            this.numbersCxtMenu_btnDelete.Name = "numbersCxtMenu_btnDelete";
            this.numbersCxtMenu_btnDelete.Size = new System.Drawing.Size(112, 22);
            this.numbersCxtMenu_btnDelete.Text = "Delete";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 457);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail Tracker";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.numbersCxtMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.ListBox lstNumbers;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton tbtnUpdate;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem mbtnFile;
        private System.Windows.Forms.ToolStripMenuItem mbtnExit;
        private System.Windows.Forms.ToolStripMenuItem mbtnLanguage;
        private System.Windows.Forms.ToolStripMenuItem mbtnLangEnglish;
        private System.Windows.Forms.ToolStripMenuItem mbtnLangGreek;
        private System.Windows.Forms.ToolStripStatusLabel ssLoging;
        private System.Windows.Forms.ImageList imageListMain;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ContextMenuStrip numbersCxtMenu;
        private System.Windows.Forms.ToolStripMenuItem numbersCxtMenu_btnAdd;
        private System.Windows.Forms.ToolStripMenuItem numbersCxtMenu_btnUpdate;
        private System.Windows.Forms.ToolStripMenuItem numbersCxtMenu_btnDelete;
    }
}

