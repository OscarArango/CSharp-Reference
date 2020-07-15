using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleWebAPI.Config {
    public static class InitDB {
        public static SqlConnection initialize() {
            //var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            //var cnn = new SqlConnection(connectionString);

            //return cnn;

            //Short Hand version of the code above.
            return new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
        }
    }
}
