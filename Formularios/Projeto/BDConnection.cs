﻿using System;
using System.Data;
using Npgsql;

namespace Login
{
    class BDConnection
    {
        static string server = "127.0.0.1";
        static string port = "5432";
        static string userName = "postgres";
        static string password = "1234";
        static string dbName = "BackyardGarden";

        NpgsqlConnection pgsqlConnection = null;
        string conn = null;

        public BDConnection()
        {
            conn = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};",
                server, port, userName, password, dbName);
        }

        //Pegar todos os usuarios registrados
        public DataTable getAllUsers()
        {
            DataTable dt = new DataTable();
            pgsqlConnection = new NpgsqlConnection(conn);

            try
            {
                //Abrindo conexão com p PgSQL e definindo etrutura SQL
                pgsqlConnection.Open();
                string select = "Select * from hortalicas order by id";

                using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(select, pgsqlConnection))
                {
                    Adpt.Fill(dt);
                }
            }
            catch(NpgsqlException ex)
            {
                throw ex;
            }
            catch(Exception ex)
            {
                throw ex;
                
            }
            finally
            {
                pgsqlConnection.Close();
            }

            return dt;
        }
    }
}