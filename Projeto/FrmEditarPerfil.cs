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

        List<string> dados = new List<string>();

        UserAccess acesso = new UserAccess();

        string emailValue;

        public FrmEditarPerfil(List<string> dados, string emailValue)
        {
            InitializeComponent();

            this.dados = dados;
            this.emailValue = emailValue;
        }

        private void fmrEditarPerfil_Load(object sender, EventArgs e)
        {

            txbNome.Text = dados[0];
            txbSobrenome.Text = dados[1];
            txbEmail.Text = dados[2];
        }



        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonUpdPass_Click(object sender, EventArgs e)
        {
            FrmUpPass uppass = new FrmUpPass(emailValue);
            uppass.ShowDialog();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            acesso.updUser(txbNome.Text, txbSobrenome.Text, txbEmail.Text, emailValue);
            MessageBox.Show("Editado com sucesso!!");
        }
    }
}
