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
    public partial class fmrLogin : Form
    {
        DbConnection db = new DbConnection();

        //static string tabela;
        public fmrLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void fmrLogin_Load(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            var users = db.getProductsName("usuarios");

            /*frmPaginaInicial pagina = new frmPaginaInicial();
            pagina.ShowDialog();*/
            
            for(int i = 0; i < users.Count; i++)
            {
                if (textBox1.Text == users[i] && textBox2.Text == users[i+1])
                {
                    textBox1.Text = "";
                    textBox2.Text = "";

                    frmPaginaInicial pagina = new frmPaginaInicial();
                    pagina.ShowDialog();

                    return;
                }
               
            }

            MessageBox.Show("Login ou senha invalidos.");
            textBox1.Text = "";
            textBox2.Text = "";

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            FmrCadastrar cadastrar = new FmrCadastrar();
            cadastrar.ShowDialog();
            //this.Close();
        }

        private void editar_Click(object sender, EventArgs e)
        {
            fmrEditarPerfil editar = new fmrEditarPerfil();
            editar.ShowDialog();
        }

    }
}
