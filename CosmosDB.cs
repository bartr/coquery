using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Azure.Documents.Client;
using System.Diagnostics;
using Microsoft.Azure.Documents.Linq;

namespace coquery
{
    public class CosmosDB
    {
        // CosmosDB connection info
        public string ConnectionString = string.Empty;
        public string Key = string.Empty;
        public string Database = string.Empty;
        public string Collection = string.Empty;

        // CosmosDB client
        private DocumentClient client;
        private Uri collectionLink;

        // CosmosDB Options
        private readonly ConnectionPolicy policy = new ConnectionPolicy { ConnectionMode = ConnectionMode.Direct, ConnectionProtocol = Protocol.Tcp };
        private readonly FeedOptions options = new FeedOptions { EnableCrossPartitionQuery = true, MaxItemCount = 2000 };

        // 
        private bool isOpen
        {
            get
            {
                // Opens the client if necessary

                if (client == null)
                {
                    OpenCosmosDBConnection();
                }

                return client != null;
            }
        }

        public void OpenCosmosDBConnection()
        {
            // open / reopen the CosmosDB connection

            string conn = ConnectionString;

            // format the connection string correctly
            if (!conn.ToLower().StartsWith("http"))
            {
                conn = string.Format("https://{0}.documents.azure.com/", conn.Trim());
            }

            // Open the CosmosDB client connection
            client = new DocumentClient(new Uri(conn), Key, policy);
            client.OpenAsync();

            // set database and collection
            collectionLink = UriFactory.CreateDocumentCollectionUri(Database, Collection);
        }

        public async Task<List<dynamic>> ExecQuery(string sql)
        {
            // execute the CosmosDB query
            // needs to be wrapped in a try - catch for exception handling

            // results
            List<dynamic> results = new List<dynamic>();

            // cumulative RUs
            double rus = 0;

            // make sure the connection is open
            if (isOpen)
            {
                // timing
                Stopwatch sw = new Stopwatch();
                sw.Start();

                IDocumentQuery<dynamic> query = client.CreateDocumentQuery<dynamic>(collectionLink, sql, options).AsDocumentQuery();
                FeedResponse<dynamic> response;

                while (query.HasMoreResults)
                {
                    // process the results

                    response = await query.ExecuteNextAsync().ConfigureAwait(false);

                    // accumulate the RUs
                    rus += response.RequestCharge;

                    // add the docs to the List
                    foreach (var doc in response)
                    {
                        results.Add(doc);
                    }
                }

                sw.Stop();

                // add the elasped time and RUs to the List
                results.Insert(0, sw.ElapsedMilliseconds);
                results.Insert(1, rus);
            }

            return results;
        }
    }
}
