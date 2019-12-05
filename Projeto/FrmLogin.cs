using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class FrmLogin : Form
    {
        UsersLogin db = new UsersLogin();

        public FrmLogin()
        {
            InitializeComponent();
        }

        string value;

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string typeOfUser = "USER";

            if (rdb_user.Checked == true)
            {
                //Passando tabela usuarios como paramentro
                value = txbUser.Text;

                bool isAnUser = db.verifingUserLogin(txbUser.Text, txtSenha.Text, typeOfUser);

                if (isAnUser)
                {
                    FrmInicial pagina = new FrmInicial(value);
                    pagina.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Login ou senha invalidos.");
                    txbUser.Text = "";
                    txtSenha.Text = "";
                }
            }

            if (rdb_Adm.Checked == true)
            {
                typeOfUser = "ADM";

                //Passando tabela administradores como parametro
                bool isAnUser = db.verifingUserLogin(txbUser.Text, txtSenha.Text, typeOfUser);

                if (isAnUser)
                {
                    FrmAdmin frmAdmin = new FrmAdmin();
                    frmAdmin.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Login ou senha invalidos.");
                    txbUser.Text = "";
                    txtSenha.Text = "";
                }
            }

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            FrmCadastrar cadastrar = new FrmCadastrar();
            cadastrar.ShowDialog();
            //this.Close();
        }

        private void editar_Click(object sender, EventArgs e)
        {
           /* FrmEditarPerfil editar = new FrmEditarPerfil();
            editar.ShowDialog();*/
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
