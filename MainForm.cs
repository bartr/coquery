using System;
using System.IO;
using System.Windows.Forms;

namespace coquery
{
    public partial class frmMain : Form
    {
        // CosmosDB class
        private readonly CosmosDB cosmos = new CosmosDB();

        public frmMain()
        {
            // standard constructor

            InitializeComponent();
        }

        private void FormLoad(object sender, EventArgs e)
        {
            // Form Load Handler

            // show the form
            this.Visible = true;

            // login with saved credentials or show the dialog
            if (! Login(true))
            {
                Application.Exit();
            }

            // Open the CosmosDB client connection
            // this does not verify connectivity
            cosmos.OpenCosmosDBConnection();

            // save this for later
            queryHeight = txtQuery.Height;

            // zoom to just query window
            txtQuery.Text = "select *\r\nfrom m\r\n";
            txtQuery.Focus();
            txtQuery.Select(0, 0);
            MnuViewZoom_Click(null, null);
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

                    // auto login with saved credentials
                    if (autoLogin)
                    {
                        return true;
                    }
                }
            }

            // set the values if already logged in
            var login = new frmLogin();
            login.txtServer.Text = cosmos.ConnectionString.Replace("https://", string.Empty).Replace(".documents.azure.com/", string.Empty);
            login.txtKey.Text = cosmos.Key;
            login.txtDatabase.Text = cosmos.Database;
            login.txtCollection.Text = cosmos.Collection;

            // show the login form
            DialogResult res = login.ShowDialog(this);

            // login cancelled
            if (res == DialogResult.Cancel)
            {
                return false;
            }

            // set the login info
            cosmos.ConnectionString = login.txtServer.Text.Trim();
            cosmos.Key = login.txtKey.Text.Trim();
            cosmos.Database = login.txtDatabase.Text.Trim();
            cosmos.Collection = login.txtCollection.Text.Trim();

            return true;
        }
    }
}
