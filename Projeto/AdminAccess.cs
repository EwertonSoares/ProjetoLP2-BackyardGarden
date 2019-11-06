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

        //Pegando usuario registrado
        public DataTable getUserInformation()
        {

            connected.pgsqlConnection = new NpgsqlConnection(connected.conn);

            try
            {
                //Abrindo conexão com p PgSQL e definindo etrutura SQL
                connected.pgsqlConnection.Open();
                //select = "Select * from usuarios where tipo = 'adm' order by id";
                select = "Select id, nome, email, password from usuarios where tipo = 'adm' order by nome ASC";

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

        //Inserir registros
        public void InsertUserInformation(string nome, string email, string pwd, string tipo)
        {

            try
            {
                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connected.conn))
                {
                    //Abra a conexão com o PgSQL                  
                    connected.pgsqlConnection.Open();

                    string cmdInsert = String.Format("Insert Into usuarios (nome ,email , password, tipo) values('{0}','{1}','{2}','{3}')", nome, email, pwd, tipo);

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
        public void updateUserInformation(int id, string nome, string email, string pwd)
        {
            try
            {
                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connected.conn))
                {
                    //Abra a conexão com o PgSQL                  
                    connected.pgsqlConnection.Open();

                    string cmdUpdate = String.Format("Update usuarios Set nome = '" + nome + "' , email = '" + email + "', password = '" + pwd + "' Where id = " + id);

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
        public void DeleteUserInformation(int id)
        {
            try
            {
                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connected.conn))
                {
                    //abre a conexao                
                    connected.pgsqlConnection.Open();

                    string cmdDelete = String.Format("Delete From usuarios Where id = {0}", id);

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

        //Pega um registro pelo codigo
        /*  public DataTable getTableInformation(int id)
          {
              try
              {
                  using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connected.conn))
                  {
                      //Abra a conexão com o PgSQL
                      connected.pgsqlConnection.Open();
                      string cmdSelect = "Select * from usuarios Where id = " + id;

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
