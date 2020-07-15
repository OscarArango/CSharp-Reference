using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinCan;
using TinCan.LRSResponses;

namespace TinCanDotNet {
    public class Endpoint {
        public static RemoteLRS EndpointConn() {
            Console.Write("Enter the EndPoint URL: ");
            var endpoint = Console.ReadLine();

            Console.Write("Enter username: ");
            var username = Console.ReadLine();

            Console.Write("Enter password: " );
            var password = Console.ReadLine();
            Console.WriteLine();

            var lrs = new RemoteLRS(
                Convert.ToString(endpoint),
                Convert.ToString(username),
                Convert.ToString(password)
            );

            //var lrs = new RemoteLRS(
            //    "https://cloud.scorm.com/lrs/8A7BD794LF/sandbox/",
            //    "oscar@bboyledesign.com",
            //    "bbd1209!"
            //);

            return lrs;
        }
    }
}
