﻿using System;
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

        static string select;
        static string email;
        static string password;

        NpgsqlConnection pgsqlConnection = null;
        string conn = null;

        public DbConnection(string value1, string value2)
        {
            conn = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};",
                server, port, userName, password, dbName);

                email = value1;
                password = value2;
        }

        Usuario users = new Usuario();
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

                if (tableName == "Usuario") {
                    select = "Select email,password from " + tableName + " order by id";
                }
                else {
                    select = "Select * from " + tableName + " order by id";
                }
               
                using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(select, pgsqlConnection))
                {
                    Adpt.Fill(dt);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (tableName == "usuarios")
                        {
                            string email = (string)dt.Rows[i]["email"];
                            string password = (string)dt.Rows[i]["password"];
                            lista.Add(email);
                            lista.Add(password);
                        }
                        else
                        {
                            lista.Add(dt.Rows[i]["Nome"].ToString());
                        }
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

        /// <summary>
        /// /////////////////////
        /// </summary>
        /// <returns></returns>
       /* public List<string> getUsersInformation()
        {
            DataTable dt = new DataTable();
            pgsqlConnection = new NpgsqlConnection(conn);

            try
            {
                //Abrindo conexão com p PgSQL e definindo etrutura SQL
                pgsqlConnection.Open();
                string select = "Select * from usuarios order by id";

                using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(select, pgsqlConnection))
                {
                    Adpt.Fill(dt);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string email = (string)dt.Rows[i]["email"];
                        string password = (string)dt.Rows[i]["password"];
                        lista.Add(email+password);
                        //users.setUser(email, password);
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
        }*/
    }
}
