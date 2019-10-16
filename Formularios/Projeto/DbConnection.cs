using System;
using System.Collections.Generic;
using System.Data;
using Npgsql;
using System.Windows.Forms;

namespace Login
{
    class DbConnection
    {
        static string server = "127.0.0.1";
        static string port = "5432";
        static string userName = "postgres";
        static string password = "1234";
        static string dbName = "BackyardGarden";

        NpgsqlConnection pgsqlConnection = null;
        string conn = null;

        public DbConnection()
        {
            conn = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};",
                server, port, userName, password, dbName);
        }

        List<string> lista = new List<string>();

        //Pegar todos os usuarios registrados
        public List<string> getProductsName(string tableName)
        {
            DataTable dt = new DataTable();
            pgsqlConnection = new NpgsqlConnection(conn);

            try
            {
                //Abrindo conexão com p PgSQL e definindo etrutura SQL
                pgsqlConnection.Open();
                string select = "Select * from " + tableName + " order by id";

                using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(select, pgsqlConnection))
                {
                    Adpt.Fill(dt);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string nome = (string)dt.Rows[i]["Nome"];
                        lista.Add(nome);
                    }

                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                pgsqlConnection.Close();
            }

            return lista;
        }
    }
}
