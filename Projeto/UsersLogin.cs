using System;
using System.Collections.Generic;
using System.Data;
using Npgsql;
using NpgsqlTypes;

namespace Login
{
    class UsersLogin
    {
        Connection connected = new Connection();
        DataTable dt = new DataTable();


        string select;


        //Verificando email do usuario
        public bool verifingUserLogin(string email, string pwd, string tipo)
        {
            connected.pgsqlConnection = new NpgsqlConnection(connected.conn);

            try
            {
                select = "SELECT COUNT(ID) FROM usuarios WHERE email = @email AND password = @password AND tipo = @tipo";

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
                else
                {
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
