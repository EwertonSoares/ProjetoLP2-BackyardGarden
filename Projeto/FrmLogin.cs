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
        private void btn_Login_Click(object sender, EventArgs e)
        {
            string typeOfUser = "adm";

            if (rdb_Adm.Checked == true)
            {
                //Passando tabela administradores como parametro
                bool isAnUser = db.verifingUserLogin(textBox1.Text, textBox2.Text, typeOfUser);

                if (isAnUser)
                {
                    FrmAdmin frmAdmin = new FrmAdmin();
                    frmAdmin.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Login ou senha invalidos.");
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
            }

            if (rdb_user.Checked == true)
            {
                typeOfUser = "user";
                //Passando tabela usuarios como paramentro
                bool isAnUser = db.verifingUserLogin(textBox1.Text, textBox2.Text, typeOfUser);

                if (isAnUser)
                {
                    FrmInicial pagina = new FrmInicial();
                    pagina.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Login ou senha invalidos.");
                    textBox1.Text = "";
                    textBox2.Text = "";
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
            FrmEditarPerfil editar = new FrmEditarPerfil();
            editar.ShowDialog();
        }

    }
}
