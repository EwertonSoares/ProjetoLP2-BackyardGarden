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

        //Pegar todos os usuarios registrados
        public List<string> getProducts(string tableName)
        {
            List<string> lista = new List<string>();
            DataTable dt = new DataTable();

            connected.pgsqlConnection = new NpgsqlConnection(connected.conn);

            try
            {
                //Abrindo conexão com p PgSQL e definindo etrutura SQL
                connected.pgsqlConnection.Open();
                 select = "Select * from " + tableName + " order by id";

                using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(select, connected.pgsqlConnection))
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
                connected.pgsqlConnection.Close();
            }

            return lista;
        }

        //Verificando email do usuario
        public bool verifingUserLogin(string email, string pwd, string tipo)
        {
            connected.pgsqlConnection = new NpgsqlConnection(connected.conn);

            try
            {
                select = "SELECT COUNT(ID) FROM usuarios WHERE email = @email AND password = @password And @tipo = tipo";

                NpgsqlCommand cmd = new NpgsqlCommand(select, connected.pgsqlConnection);
                cmd.Parameters.Add("@email", NpgsqlDbType.Varchar).Value = email;
                cmd.Parameters.Add("@password", NpgsqlDbType.Varchar).Value = pwd;
                cmd.Parameters.Add("@tipo", NpgsqlDbType.Varchar).Value = tipo;

                //Abrindo conexão com p PgSQL e definindo etrutura SQL
                connected.pgsqlConnection.Open();

                string userFound = cmd.ExecuteScalar().ToString();
                //int.Parse(userFound);
                if (int.Parse(userFound) == 1)
                {
                    return true;
                }
                else {
                    return false;
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
