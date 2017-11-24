namespace MailTracker
{
    partial class frmNumber
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
            this.btnAction = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.chkBoxClosed = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(249, 8);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(54, 23);
            this.btnAction.TabIndex = 0;
            this.btnAction.Text = "Save";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(76, 10);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(167, 20);
            this.txtNumber.TabIndex = 1;
            // 
            // chkBoxClosed
            // 
            this.chkBoxClosed.AutoSize = true;
            this.chkBoxClosed.Location = new System.Drawing.Point(12, 12);
            this.chkBoxClosed.Name = "chkBoxClosed";
            this.chkBoxClosed.Size = new System.Drawing.Size(58, 17);
            this.chkBoxClosed.TabIndex = 2;
            this.chkBoxClosed.Text = "Closed";
            this.chkBoxClosed.UseVisualStyleBackColor = true;
            // 
            // frmNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 41);
            this.Controls.Add(this.chkBoxClosed);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.btnAction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Track Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.CheckBox chkBoxClosed;
    }
}