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
        UserAccess db = new UserAccess();
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            string typeOfUser = "adm";

            if (rdb_user.Checked == true)
            {
                typeOfUser = "user";
            }

            try
            {
                //Passando tabela usuarios como paramentro
                bool isAnUser = db.verifingUserLogin(textBox1.Text, textBox2.Text, typeOfUser);

                if (isAnUser && typeOfUser == "user")
                {
                    FrmPaginaInicial pagina = new FrmPaginaInicial();
                    pagina.ShowDialog();
                }
                else if (isAnUser && typeOfUser == "adm")
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
            catch (Exception error)
            {
                throw error;
            }
            finally{

                this.Close();
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
