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
                if (client == null)
                {
                    OpenCosmosDBConnection();
                }

                return client != null;
            }
        }

        public void OpenCosmosDBConnection()
        {
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

            List<dynamic> results = new List<dynamic>();

            double rus = 0;

            if (isOpen)
            {
                // timing
                Stopwatch sw = new Stopwatch();
                sw.Start();

                IDocumentQuery<dynamic> query = client.CreateDocumentQuery<dynamic>(collectionLink, sql, options).AsDocumentQuery();
                FeedResponse<dynamic> response;

                while (query.HasMoreResults)
                {

                    response = await query.ExecuteNextAsync().ConfigureAwait(false);

                    rus += response.RequestCharge;

                    foreach (var doc in response)
                    {
                        results.Add(doc);
                    }
                }

                sw.Stop();

                results.Insert(0, sw.ElapsedMilliseconds);
                results.Insert(1, rus);
            }

            return results;
        }
    }
}
