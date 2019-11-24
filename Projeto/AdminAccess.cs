using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace Login
{
    class AdminAccess
    {
        Connection connected = new Connection();

        private NpgsqlDataAdapter dataAdapter;
        private DataTable dataTable;



        //String de conexão com o banco de dados local
        public DataTable getTableInformation(string tableName) {

            //String com o comado select
            //string strSelect = "SELECT nome, cpf, endereco, cep FROM tb_cliente";
            string strSelect = "SELECT * FROM " + tableName;

            //cria a conexão
            NpgsqlConnection conexao = new NpgsqlConnection(connected.conn); 

            try
            {
                //Cria um novo adaptador para os dados na tabela
                dataAdapter = new NpgsqlDataAdapter();
                dataAdapter.SelectCommand = new NpgsqlCommand(strSelect, conexao);


                //cria os comandos insert update e delete
                NpgsqlCommandBuilder cmdBuilder = new NpgsqlCommandBuilder(dataAdapter);

                //Diz que iremos utilizar "colchetes" para especificar objetos 
                //de banco de dados (tabelas, colunas...)cujos nomes contenham caracteres 
                //como espaços ou símbolos reservados;
                cmdBuilder.QuotePrefix = "[";
                cmdBuilder.QuoteSuffix = "]";

                //cria e prenche uma tabela com os dados do banco usando o adaptador
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                //diz para o grid utilizar essa tabela como fonte de dados
                //gvClientes.DataSource = data_table;

            }
            //monitora possíveis erros
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            //fecha a conexão
            finally
            {
                conexao.Close();
            }

            return dataTable;
        }

        public void saveInformation()
        {
            MessageBox.Show(dataTable.ToString());

            try
            {
                dataAdapter.Update(dataTable);

            }
            catch(NpgsqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }

        }



    }
}








































































        /* DataTable dt = new DataTable();


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
}*/
