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

        private void MnuHelpAbout_Click(object sender, EventArgs e)
        {
            // show help
            new frmAbout().ShowDialog(this);
        }

        private void MnuViewQuery_Click(object sender, EventArgs e)
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

        private void MnuViewResults_Click(object sender, EventArgs e)
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

        private void MnuViewZoom_Click(object sender, EventArgs e)
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

        private void MnuToolsExecute_Click(object sender, EventArgs e)
        {
            // execute the query

            this.Cursor = Cursors.WaitCursor;

            List<dynamic> results = new List<dynamic>();

            if (ActiveControl == txtQuery)
            {
                Unzoom();

                string sql = txtQuery.Text.Trim();

                if (! string.IsNullOrEmpty(sql))
                {
                    // get the query from selected text
                    if (txtQuery.SelectionLength > 0)
                    {
                        sql = txtQuery.SelectedText.Trim();
                    }

                    if (!string.IsNullOrEmpty(sql))
                    {
                        txtResults.Text = string.Empty;
                        lblStatus.Text = "Executing query ...";

                        try
                        {
                            results = cosmos.ExecQuery(sql).GetAwaiter().GetResult();

                            // elapsed ms will be the first item in the list and RUs will be the second
                            lblStatus.Text = string.Format("{0} documents retrieved in {1}ms - {2} request units", results.Count - 2, results[0], results[1]);

                            // remove elaspsed time and RUs
                            results.RemoveAt(0);
                            results.RemoveAt(0);

                            // convert the List to json
                            txtResults.Text += JsonConvert.SerializeObject(results, Formatting.Indented);
                        }
                        catch (Exception ex)
                        {
                            lblStatus.Text = ex.GetType().ToString();
                            txtResults.Text = ex.ToString();
                        }
                    }
                }

                // makes it easier to use
                txtResults.Select(0, 0);
                txtQuery.Focus();

                this.Cursor = Cursors.Default;
            }
        }

        private void MnuFileExit_Click(object sender, EventArgs e)
        {
            // see ya

            Application.Exit();
        }

        private void MnuFileOpen_Click(object sender, EventArgs e)
        {
            // open a query file

            MessageBox.Show("Sorry, File Open not implemented yet", "Contributions Welcomed!", MessageBoxButtons.OK);
        }

        private void MnuFileSave_Click(object sender, EventArgs e)
        {
            // save the query or results based on focus

            MessageBox.Show("Sorry, File Save not implemented yet", "Contributions Welcomed!", MessageBoxButtons.OK);
        }

        private void MnuFileSaveAs_Click(object sender, EventArgs e)
        {
            // save the query or results based on focus

            MessageBox.Show("Sorry, File Save As not implemented yet", "Contributions Welcomed!", MessageBoxButtons.OK);
        }

        private void MnuToolsLogin_Click(object sender, EventArgs e)
        {
            // open CosmosDB connection with new login info

            if (Login(false))
            {
                cosmos.OpenCosmosDBConnection();
            }
        }
    }
}
