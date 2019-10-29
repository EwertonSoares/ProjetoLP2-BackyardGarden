using System;
using System.Collections.Generic;
using System.Data;
using Npgsql;

namespace Login
{
    class AdminAccess
    {
        Connection connected = new Connection();
        DataTable dt = new DataTable();


        string select;

        public DataTable getTableInformation(string tableName)
        {

            connected.pgsqlConnection = new NpgsqlConnection(connected.conn);

            try
            {
                //Abrindo conexão com p PgSQL e definindo etrutura SQL
                connected.pgsqlConnection.Open();
                select = "Select * from " + tableName + " order by id";

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

        //Pega um registro pelo codigo
        public DataTable getTableInformation(int id, string tableName)
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
        }

        //Inserir registros
        public void InsertInformation(string tableName, string nome, string email, string pwd)
        {

            try
            {
                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connected.conn))
                {
                    //Abra a conexão com o PgSQL                  
                    connected.pgsqlConnection.Open();

                    string cmdInsert = String.Format("Insert Into " + tableName + " (nome,email,password) values('{0}','{1}','{2}')", nome, email, pwd);

                    using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(cmdInsert, connected.pgsqlConnection))
                    {
                        pgsqlcommand.ExecuteNonQuery();
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
        }
        //Atualiza registros
        public void updateInformation(string tableName, int id, string nome, string email)
        {
            try
            {
                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connected.conn))
                {
                    //Abra a conexão com o PgSQL                  
                    connected.pgsqlConnection.Open();

                    string cmdUpdate = String.Format("Update " + tableName +" Set email = '" + nome + "' , idade = " + email + " Where id = " + id);

                    using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(cmdUpdate, connected.pgsqlConnection))
                    {
                        pgsqlcommand.ExecuteNonQuery();
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
        }

        //Deleta registros
        public void DeletarRegistro(string tableName, string nome)
        {
            try
            {
                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connected.conn))
                {
                    //abre a conexao                
                    connected.pgsqlConnection.Open();

                    string cmdDelete = String.Format("Delete From " + tableName + " Where nome = '{0}'", nome);

                    using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(cmdDelete, connected.pgsqlConnection))
                    {
                        pgsqlcommand.ExecuteNonQuery();
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
        }
    }
}
