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
        string insert;
        string update;

        DataTable dt = new DataTable();

        //Pegando usuario por id
        public DataTable getUser(string email)
        {
           
            connected.pgsqlConnection = new NpgsqlConnection(connected.conn);

            try
            {
                //Abrindo conexão com p PgSQL e definindo etrutura SQL
                connected.pgsqlConnection.Open();
                 select = String.Format("Select nome, sobrenome, email from usuarios where email = '{0}'", email);

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

        //senha
        public void updPassword(string senha, string email)
        {
            connected.pgsqlConnection = new NpgsqlConnection(connected.conn);

            try
            {
                connected.pgsqlConnection.Open();

                update = String.Format("Update usuarios set senha = '{0}' where email = '{1}' ", senha, email);

                using (NpgsqlCommand adpt = new NpgsqlCommand(insert, connected.pgsqlConnection))
                {
                    adpt.ExecuteNonQuery();
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

        public void addUser(string nome, string sobrenome, string email, string senha)
        {
            connected.pgsqlConnection = new NpgsqlConnection(connected.conn);


            try
            {
                connected.pgsqlConnection.Open();

                insert = String.Format("Insert into usuarios (nome, sobrenome, email, senha, tipo)" +
                    " values('{0}','{1}','{2}','{3}','USER')", nome, sobrenome, email, senha);

                using (NpgsqlCommand adpt = new NpgsqlCommand(insert, connected.pgsqlConnection))
                {
                    adpt.ExecuteNonQuery();
                }

            }

            catch (NpgsqlException ex)
            {
                throw ex;
            }

            catch(Exception ex)
            {
                throw ex;
            }

            finally
            {
                connected.pgsqlConnection.Close();
            }


        }

        public void updUser(string nome, string sobrenome, string email, string emailValue)
        {
            
            connected.pgsqlConnection = new NpgsqlConnection(connected.conn);

            try
            {
                //Abrindo conexão com p PgSQL e definindo etrutura SQL
                connected.pgsqlConnection.Open();
                //select = String.Format("Select nome,sobrenome, email from usuarios where email = '{0}'", email);
                update = String.Format("Update usuarios set nome = '{0}', sobrenome = '{1}', email = '{2}' where email = '{3}' ", nome, sobrenome, email, emailValue);

                // using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(select, connected.pgsqlConnection))
                using (NpgsqlCommand adpt = new NpgsqlCommand(update, connected.pgsqlConnection))
                {
                    adpt.ExecuteNonQuery();
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
