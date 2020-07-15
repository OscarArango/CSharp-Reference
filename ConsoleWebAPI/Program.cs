using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.SelfHost;
using System.Net;
using System.Net.Mail;
using System.Configuration;

namespace ConsoleWebAPI {
    class Program {
        static void Main(string[] args) {
            try {
                Config.InitWebServer.StrtWebServer();

                DataAccessLayer.Connect();
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                Console.ReadLine();
            }
        }
    }
}
