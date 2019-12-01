using System;
using System.Collections.Generic;
using System.Data;
using Npgsql;
using NpgsqlTypes;


namespace Login
{
    class ProductsConnection
    {

        string select;

        Connection connected = new Connection();

        List<string> lista = new List<string>();

        DataTable dt = new DataTable();

        //Pegando informaçôes de uma determinada tabela de produtos
        public DataTable getProducts(string tableName)
        {
            connected.pgsqlConnection = new NpgsqlConnection(connected.conn);

            try
            {   //Abrindo conexão com p PgSQL e definindo etrutura SQL
                connected.pgsqlConnection.Open();

                select = "Select * from " + tableName + " order by nome";

                using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(select, connected.pgsqlConnection))
                {
                    Adpt.Fill(dt);
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
                connected.pgsqlConnection.Close();
            }

            return dt;
        }

        //Pega um registro de uma determinada tabela pelo id
        /*public DataTable getProductsbyId(int id, string tableName)
        {
            try
            {
                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connected.conn))
                {
                    //Abra a conexão com o PgSQL
                    connected.pgsqlConnection.Open();
                    string cmdSelect = "Select * from " + tableName + " Where id = " + id;

                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmdSelect, connected.pgsqlConnection))
                    {
                        Adpt.Fill(dt);
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
                connected.pgsqlConnection.Close();
            }
            return dt;
        }*/


    }
}
