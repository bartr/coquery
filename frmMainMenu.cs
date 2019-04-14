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
        // for zooming the query and results
        bool isZoomed = false;
        int queryHeight = 240;

        private void Unzoom()
        {
            // unzoom the query and results

            isZoomed = false;
            txtQuery.Visible = true;
            txtQuery.Height = queryHeight;

            txtResults.Visible = true;
            txtResults.Top = txtQuery.Top + queryHeight;
            txtResults.Height = status.Top - txtResults.Top - 1;
        }

        // menu handlers

        private void mnuHelpAbout_Click(object sender, EventArgs e)
        {
            // show help
            new frmAbout().ShowDialog(this);
        }

        private void mnuViewQuery_Click(object sender, EventArgs e)
        {
            // set focus to query

            if (isZoomed)
            {
                // make sure query is visible
                if (!txtQuery.Visible)
                {
                    Unzoom();
                }
            }

            txtQuery.Focus();
        }

        private void mnuViewResults_Click(object sender, EventArgs e)
        {
            // set focus to results
            if (isZoomed)
            {
                // make sure results is visible
                if (!txtResults.Visible)
                {
                    Unzoom();
                }
            }

            txtResults.Focus();
        }

        private void mnuViewZoom_Click(object sender, EventArgs e)
        {
            // zoom / unzoom the query or results

            if (isZoomed)
            {
                Unzoom();
                return;
            }
            if (ActiveControl != null)
            {
                if (ActiveControl.Name == "txtQuery")
                {
                    // zoom the query
                    Unzoom();
                    isZoomed = true;
                    txtResults.Visible = false;
                    txtQuery.Height = status.Top - txtQuery.Top - 1;
                    return;
                }

                if (ActiveControl.Name == "txtResults")
                {
                    // zoom the results
                    Unzoom();
                    isZoomed = true;
                    txtQuery.Visible = false;
                    txtResults.Top = txtQuery.Top;
                    txtResults.Height = status.Top - txtResults.Top - 1;
                    return;
                }
            }
        }

        private void mnuToolsExecute_Click(object sender, EventArgs e)
        {
            // execute the query

            if (ActiveControl == txtQuery)
            {
                Unzoom();
                ExecQuery().Wait();
            }
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            // see ya
            Application.Exit();
        }

        private void mnuFileOpen_Click(object sender, EventArgs e)
        {
            // open a query file

            MessageBox.Show("Sorry, File Open not implemented yet");
        }

        private void mnuFileSave_Click(object sender, EventArgs e)
        {
            // save the query or results based on focus

            MessageBox.Show("Sorry, File Save not implemented yet");
        }

        private void mnuFileSaveAs_Click(object sender, EventArgs e)
        {
            // save the query or results based on focus

            MessageBox.Show("Sorry, File Save As not implemented yet");
        }

        private void mnuToolsLogin_Click(object sender, EventArgs e)
        {
            // open CosmosDB connection with new login info

            if (Login(false))
            {
                OpenCosmosDBConnection();
            }
        }
    }
}
