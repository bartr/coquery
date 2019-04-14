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
        // CosmosDB connection info
        private string connString = string.Empty;
        private string key = string.Empty;
        private string database = string.Empty;
        private string collection = string.Empty;

        // CosmosDB client
        private DocumentClient client;
        private Uri collectionLink;

        // CosmosDB Options
        private readonly ConnectionPolicy policy = new ConnectionPolicy { ConnectionMode = ConnectionMode.Direct, ConnectionProtocol = Protocol.Tcp };
        private readonly FeedOptions options = new FeedOptions { EnableCrossPartitionQuery = true, MaxItemCount = 2000 };

        private void OpenCosmosDBConnection()
        {
            string conn = connString;

            // format the connection string correctly
            if (!conn.ToLower().StartsWith("http"))
            {
                conn = string.Format("https://{0}.documents.azure.com/", conn.Trim());
            }

            // Open the CosmosDB client connection
            client = new DocumentClient(new Uri(conn), key, policy);
            client.OpenAsync();

            // set database and collection
            collectionLink = UriFactory.CreateDocumentCollectionUri(database, collection);
        }

        async Task ExecQuery()
        {
            // execute the CosmosDB query

            if (txtQuery.Text.Trim().Length > 0)
            {
                this.Cursor = Cursors.WaitCursor;

                // get the query from selected text or entire text
                string sql = txtQuery.Text.Trim();

                if (txtQuery.SelectionLength > 0)
                {
                    sql = txtQuery.SelectedText.Trim();
                }

                txtResults.Text = string.Empty;

                // timing
                Stopwatch sw = new Stopwatch();
                sw.Start();

                try
                {
                    IQueryable<dynamic> mQuery = client.CreateDocumentQuery<dynamic>(collectionLink, sql, options);

                    // show the results
                    txtResults.Text = JsonConvert.SerializeObject(mQuery, Formatting.Indented);

                    sw.Stop();

                    // update the status
                    lblStatus.Text = string.Format("{0} documents retrieved in {1}ms", mQuery.ToList().Count, sw.ElapsedMilliseconds);

                    // this doesn't work :(
                    // trying to get the RU cost

                    //IDocumentQuery<dynamic> query = client.CreateDocumentQuery<dynamic>(collectionLink, sql, options).AsDocumentQuery();
                    //FeedResponse<dynamic> response;

                    //while (query.HasMoreResults)
                    //{

                    //    response = await query.ExecuteNextAsync();
                    //    txtResults.Text += string.Format("{0} request units\r\n", response.RequestCharge);
                    //    foreach (var doc in response)
                    //    {
                    //        results.Add(doc);
                    //    }
                    //}

                }
                catch (Exception ex)
                {
                    txtResults.Text = ex.ToString();
                    lblStatus.Text = "Error";
                }


                // makes it easier to use
                txtResults.Select(0, 0);
                txtQuery.Focus();
            }

            this.Cursor = Cursors.Default;
        }
    }
}
