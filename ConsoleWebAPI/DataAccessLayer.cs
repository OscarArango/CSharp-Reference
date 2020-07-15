using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ConsoleWebAPI {
    public static class DataAccessLayer {
        public static bool Connect() {
            var cnn = Config.InitDB.initialize();

            try {
                cnn.Open();
                Console.WriteLine("Connection Open !\n");

                // create a SqlCommand object for this connection
                SqlCommand command = cnn.CreateCommand();
                command.CommandText = "Select * from Ports";
                command.CommandType = CommandType.Text;

                // execute the command that returns a SqlDataReader
                SqlDataReader reader = command.ExecuteReader();

                // display the results
                while (reader.Read()) {
                    //whatever you want to do.
                    Console.WriteLine("Services currently running: " + reader["ServiceName"] + "On Port#: " + reader["PortNumber"]);
                    
                }

                Console.ReadLine();

                // close the connection
                reader.Close();
                cnn.Close();

            }
            catch (Exception ex) {
                Console.WriteLine("Can not open connection ! " + ex);
            }

            return true;
        }
    }
}
