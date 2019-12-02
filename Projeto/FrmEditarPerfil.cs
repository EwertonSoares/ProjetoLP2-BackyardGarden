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
        private BindingSource bind_source;
        private NpgsqlDataAdapter data_adapter;
        private DataTable data_table;

        public FrmEditarPerfil()
        {
            InitializeComponent();
        }

        private void fmrEditarPerfil_Load(object sender, EventArgs e)
        {
            string connection = @"Host=127.0.0.1,Username=localhost,,Password=bruno2108,Database=newBd";

            string select = @"SELECT * FROM usuarios";

            string update = @"UPDATE usuarios SET " +
                "nome=@nome" +
                "sobrenome=@sobrenome" +
                "email=@email" +
                "senha=@senha" +
                "tipo=@tipo";

            string delete = @"DELETE FROM usuarios WHERE email=@email";

            NpgsqlConnection connect = new NpgsqlConnection(connection);

            try
            {
                data_adapter = new NpgsqlDataAdapter();
                data_adapter.SelectCommand = new NpgsqlCommand(select, connect);

                data_adapter.UpdateCommand = new NpgsqlCommand(update, connect);
                data_adapter.UpdateCommand.Parameters.Add("@nome", NpgsqlDbType.Varchar, 30, "nome");
                data_adapter.UpdateCommand.Parameters.Add("@sobrenome", NpgsqlDbType.Varchar, 30, "sobrenome");
                data_adapter.UpdateCommand.Parameters.Add("@email", NpgsqlDbType.Varchar, 300, "email");
                data_adapter.UpdateCommand.Parameters.Add("@senha", NpgsqlDbType.Varchar, 30, "senha");

                data_adapter.DeleteCommand = new NpgsqlCommand(delete, connect);
                data_adapter.DeleteCommand.Parameters.Add("@email", NpgsqlDbType.Varchar, 30, "email");

                data_table = new DataTable();
                data_adapter.Fill(data_table);

                bind_source = new BindingSource();
                bind_source.DataSource = data_table;

                txbNome.DataBindings.Add("Text", bind_source, "nome", true);
                txbSobrenome.DataBindings.Add("Text", bind_source, "sobrenome", true);
                txbEmail.DataBindings.Add("Text", bind_source, "email", true);
                txbSenha.DataBindings.Add("Text", bind_source, "senha", true);
                txbConfSenha.DataBindings.Add("Text", bind_source, "senha", true);
                
            }

            catch (NpgsqlException exception)
            {
                MessageBox.Show(exception.Message + exception.StackTrace);
            }

            finally
            {
                connect.Close();
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
    }
}
