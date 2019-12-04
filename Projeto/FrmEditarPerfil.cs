using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Npgsql;
using NpgsqlTypes;

namespace Login
{
    public partial class FrmEditarPerfil : Form
    {
        private BindingSource     bind_source;
        private NpgsqlDataAdapter data_adapter;
        private DataTable         data_table;

        private int id_usuario = 0;
        
        public FrmEditarPerfil()
        {
            InitializeComponent();
        }

        private void fmrEditarPerfil_Load(object sender, EventArgs e)
        {
            string connect = @"Host=127.0.0.1;Username=postgres;Password=bruno2108;Database=newBd";

            string select = "SELECT NOME, SOBRENOME, EMAIL FROM usuarios WHERE TIPO = 'USER'";

            string update = "UPDATE USUARIOS SET " +
                            "nome=@nome, " +
                            "sobrenome=@sobrenome, " +
                            "email=@email" +
                            "WHERE id_usuario=@id_usuario ;";

            NpgsqlConnection conn = new NpgsqlConnection(connect);

            try
            {
                    data_adapter = new NpgsqlDataAdapter();
                    data_adapter.SelectCommand = new NpgsqlCommand(select, conn);

                    data_adapter.UpdateCommand = new NpgsqlCommand(update, conn);
                    data_adapter.UpdateCommand.Parameters.Add("@nome", NpgsqlDbType.Varchar, 30, "nome");
                    data_adapter.UpdateCommand.Parameters.Add("@sobrenome", NpgsqlDbType.Varchar, 30, "sobrenome");
                    data_adapter.UpdateCommand.Parameters.Add("@email", NpgsqlDbType.Varchar, 300, "email");

                    data_table = new DataTable();
                    data_adapter.Fill(data_table);

                    bind_source = new BindingSource();
                    bind_source.DataSource = data_table;

                    txbNome.DataBindings.Add("Text", bind_source, "nome", true);
                    txbSobrenome.DataBindings.Add("Text", bind_source, "sobrenome", true);
                    txbEmail.DataBindings.Add("Text", bind_source, "email", true);
            }

            catch (NpgsqlException except)
            {
                MessageBox.Show(except.Message + except.StackTrace);
            }

            finally
            {
                conn.Close();
            }
        }

        private void btn_editarPerfil_Click(object sender, EventArgs e)
        {
            bind_source.EndEdit();
            data_adapter.Update(data_table);
            MessageBox.Show("Dados alterados");
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            bind_source.CancelEdit();
        }

        private void buttonUpdPass_Click(object sender, EventArgs e)
        {
            FrmUpPass uppass = new FrmUpPass();
            uppass.ShowDialog();
        }
    }
}
