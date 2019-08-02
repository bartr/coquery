using System;
using System.IO;
using System.Windows.Forms;

namespace coquery
{
    public partial class frmMain : Form
    {
        private readonly CosmosDB cosmos = new CosmosDB();

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
            cosmos.OpenCosmosDBConnection();

            // save this for later
            queryHeight = txtQuery.Height;

            // zoom to just query window
            txtQuery.Text = "select * from m";
            txtQuery.Focus();
            txtQuery.Select(0, 0);
            MnuViewZoom_Click(null, null);
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

                    cosmos.ConnectionString = lines[0].Trim();
                    cosmos.Key = lines[1].Trim();
                    cosmos.Database = lines[2].Trim();
                    cosmos.Collection = lines[3].Trim();

                    if (autoLogin)
                    {
                        return true;
                    }
                }
            }

            // show the login form
            var login = new frmLogin();

            // set the values if already logged in
            login.txtServer.Text = cosmos.ConnectionString.Replace("https://", string.Empty).Replace(".documents.azure.com/", string.Empty);
            login.txtKey.Text = cosmos.Key;
            login.txtDatabase.Text = cosmos.Database;
            login.txtCollection.Text = cosmos.Collection;

            // show the login form
            DialogResult res = login.ShowDialog(this);

            if (res == DialogResult.Cancel)
            {
                return false;
            }

            // save the login info
            cosmos.ConnectionString = login.txtServer.Text.Trim();
            cosmos.Key = login.txtKey.Text.Trim();
            cosmos.Database = login.txtDatabase.Text.Trim();
            cosmos.Collection = login.txtCollection.Text.Trim();

            return true;
        }
    }
}
