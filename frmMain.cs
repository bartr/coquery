using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using System.Diagnostics;
using Microsoft.Azure.Documents.Linq;
using System.Linq;

namespace coquery
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            // constructor

            InitializeComponent();
        }

        private void FormLoad(object sender, EventArgs e)
        {
            // Form Load Handler

            this.Visible = true;

            // Use auto login
            if (! Login(false))
            {
                Application.Exit();
            }

            // Open the CosmosDB client connection
            OpenCosmosDBConnection();

            // save this for later
            queryHeight = txtQuery.Height;

            // zoom to just query window
            txtQuery.Text = "select * from m";
            txtQuery.Focus();
            txtQuery.Select(0, 0);
            mnuViewZoom_Click(null, null);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // handle hot keys
            // menu handlers handle the menu accerators

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private bool Login(bool autoLogin)
        {
            // get the login information

            string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\coquery.dat";

            // read saved credentials
            if (File.Exists(path))
            {
                // read the file
                string[] lines = File.ReadAllLines(path);

                if (lines.Length == 4)
                {
                    // format the URL correctly
                    if (!lines[0].ToLower().StartsWith("http"))
                    {
                        lines[0] = string.Format("https://{0}.documents.azure.com/", lines[0].Trim());
                    }

                    connString = lines[0].Trim();
                    key = lines[1].Trim();
                    database = lines[2].Trim();
                    collection = lines[3].Trim();

                    if (autoLogin)
                    {
                        return true;
                    }
                }
            }

            // show the login form
            var login = new frmLogin();

            // set the values if already logged in
            login.txtServer.Text = connString.Replace("https://", string.Empty).Replace(".documents.azure.com/", string.Empty);
            login.txtKey.Text = key;
            login.txtDatabase.Text = database;
            login.txtCollection.Text = collection;

            // show the login form
            DialogResult res = login.ShowDialog(this);

            if (res == DialogResult.Cancel)
            {
                return false;
            }

            // save the login info
            connString = login.txtServer.Text.Trim();
            key = login.txtKey.Text.Trim();
            database = login.txtDatabase.Text.Trim();
            collection = login.txtCollection.Text.Trim();

            return true;
        }
    }
}
