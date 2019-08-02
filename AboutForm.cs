using System;
using System.Windows.Forms;

namespace coquery
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.txtAbout = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtAbout
            // 
            this.txtAbout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAbout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAbout.CausesValidation = false;
            this.txtAbout.Enabled = false;
            this.txtAbout.Location = new System.Drawing.Point(13, 13);
            this.txtAbout.Margin = new System.Windows.Forms.Padding(4);
            this.txtAbout.Multiline = true;
            this.txtAbout.Name = "txtAbout";
            this.txtAbout.Size = new System.Drawing.Size(569, 375);
            this.txtAbout.TabIndex = 0;
            // 
            // frmAbout
            // 
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(595, 401);
            this.Controls.Add(this.txtAbout);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About CosmosDB Query";
            this.Load += new System.EventHandler(this.FrmAbout_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmAbout_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void FrmAbout_Load(object sender, EventArgs e)
        {
            txtAbout.Text = "CosmosDB Query\r\n\r\n";

            txtAbout.Text += "Shortcuts\r\n";
            txtAbout.Text += "* ctl-e\tExecutes the query\r\n";
            txtAbout.Text += "\tWill execute selected text\r\n";
            txtAbout.Text += "* ctl-q\tSet focus to query text box\r\n";
            txtAbout.Text += "* ctl-r\tSet focus to results text box\r\n";
            txtAbout.Text += "\r\n";
            txtAbout.Text += "Not Implemented Yet\r\n";
            txtAbout.Text += "* File Open\r\n";
            txtAbout.Text += "* File Save\r\n";
            txtAbout.Text += "* File Save As\r\n";
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Close();
            }

            return true;
        }

        private void FrmAbout_KeyPress(object sender, KeyPressEventArgs e)
        {
            // escape exits
            if (e.KeyChar == 27)
            {
                Close();
            }

            e.Handled = true;
        }
    }
}
