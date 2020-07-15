using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinCan;
using TinCan.LRSResponses;

namespace TinCanDotNet {
    class GetStatement {
        public static void fetchStatement() {
            var lrs = Endpoint.EndpointConn();

            try {
                var query = new StatementsQuery();
                query.since = DateTime.ParseExact("2013-08-29 07:42:10Z", "u", System.Globalization.CultureInfo.InvariantCulture);
                query.limit = 10;

                StatementsResultLRSResponse lrsResponse = lrs.QueryStatements(query);
                if (lrsResponse.success) {
                    // List of statements available
                    Console.WriteLine("Count of statements: " + lrsResponse.content.statements.Count);
                    Console.ReadLine();
                }
                else {
                    // Do something with failure
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                throw;
            }
        }
    }
}
