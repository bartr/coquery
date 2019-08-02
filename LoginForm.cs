using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coquery
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            // standard constructor
            InitializeComponent();
        }

        private void FrmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            // handle escape key
            if (e.KeyChar == 27)
            {
                e.Handled = true;
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            // save the credentials
            if (DialogResult == DialogResult.OK && chkSaveLoginInfo.Checked)
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\coquery.dat";

                string dat = txtServer.Text.Trim() + "\r\n";
                dat += txtKey.Text.Trim() + "\r\n";
                dat += txtDatabase.Text.Trim() + "\r\n";
                dat += txtCollection.Text.Trim() + "\r\n";

                System.IO.File.WriteAllText(path, dat);
            }
        }
    }
}
