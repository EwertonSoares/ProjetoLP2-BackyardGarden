using System;
using System.Collections.Generic;
using System.Data;
using Npgsql;
using NpgsqlTypes;

namespace Login
{
    class UserAccess
    {
        Connection connected = new Connection();

        string select;

        DataTable dt = new DataTable();

        //Pegando usuario por id
        public DataTable getUsersById(int id)
        {
           
            connected.pgsqlConnection = new NpgsqlConnection(connected.conn);

            try
            {
                //Abrindo conexão com p PgSQL e definindo etrutura SQL
                connected.pgsqlConnection.Open();
                 select = String.Format("Select * from usuarios where id = {0} order by id", id);

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
    }
}
