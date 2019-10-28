using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;
using Npgsql;
using NpgsqlTypes;

namespace Login
{
   class Connection
    {
        public string server = "127.0.0.1";
        public string port = "5432";
        public string userName = "postgres";
        public string password = "1234";
        public string dbName = "BackyardGarden";

       public NpgsqlConnection pgsqlConnection = null;

        public string conn = null;


        public Connection()
        {
            conn = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};",
                server, port, userName, password, dbName);

        }
    }
}
