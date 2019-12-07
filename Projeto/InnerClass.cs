using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;
using NpgsqlTypes;

namespace Login
{
    class InnerClass
    {
        Connection conn = new Connection();
        DataTable dt = new DataTable();


        public DataTable vegetablesInformation(string vegetable)
        {

            conn.pgsqlConnection = new NpgsqlConnection(conn.conn);

            try
            {
                //Abrindo conexão com p PgSQL e definindo etrutura SQL
               conn.pgsqlConnection.Open();

               string select = String.Format(
                        "SELECT H.*, " +
                        "F.NOME AS FONTE, " +
                        "P.NOME AS PRAGAS, " +
                        "D.NOME AS DOENCAS " +

                        "FROM HORTALICAS AS H " +

                        "LEFT JOIN HORTALICAS_FONTES AS HF " +
                        "ON H.ID_HORT = HF.ID_HORT " +
                        "LEFT JOIN FONTES AS F " +
                        "ON F.ID_FONTE = HF.ID_FONTE " +

                        "LEFT JOIN HORTALICAS_PRAGAS AS HP " +
                        "ON H.ID_HORT = HP.ID_HORT " +
                        "LEFT JOIN PRAGAS AS P " +
                        "ON P.ID_PRAGA = HP.ID_PRAGA " +

                        "LEFT JOIN HORTALICAS_DOENCAS AS HD " +
                        "ON H.ID_HORT = HD.ID_HORT " +
                        "LEFT JOIN DOENCAS AS D " +
                        "ON D.ID_DOENCA = HD.ID_DOENCA " +
                        "WHERE H.NOME = '{0}'", vegetable.ToUpper());

                using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(select, conn.pgsqlConnection))
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
                conn.pgsqlConnection.Close();
            }

            return dt;
        }

    }
}
