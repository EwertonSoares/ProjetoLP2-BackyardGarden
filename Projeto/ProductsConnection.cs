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
        public void inserir(string tableName,string nome,string esp,string epoca,string col,string prop, string prod, string seme, string irrig, string trans,string tratos)
        {

                connected.pgsqlConnection = new NpgsqlConnection(connected.conn);

              try
              {
                    //Abrindo conexão com p PgSQL e definindo etrutura SQL
                    connected.pgsqlConnection.Open();

               string cmdInsert = String.Format("insert into hortalicas (nome, epoca, propagacao, semeadura_direta, transplante, espacamento, colheita, produtividade, irrigacao, tratos_culturais) " + 
                   " VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}')", nome, esp, epoca, col, prop, prod, seme, irrig, trans, tratos);


                 using (NpgsqlCommand Adpt = new NpgsqlCommand(cmdInsert, connected.pgsqlConnection))
                 {
                    Adpt.ExecuteNonQuery();
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
        }


    }
}
