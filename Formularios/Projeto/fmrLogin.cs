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
            //List<string> users =  new List<string>();
            //Conectar banco de dados para trazer usuarios cadastrados
            /*Provavelmente um objeto sera trazido do banco, 
             * talvez seja viavel fazer um forEach*/



            /*foreach (string data in db.getAllUsers().Rows)
            {
                users.Add(data);
                MessageBox.Show(users.ToString());
            }*/

           /* for(int i = 0; i = users; i++)
            {

            }*/

            //Verificando se login e senha são existe no banco de dados
           // if (textBox1.Text == "ewerton" && textBox2.Text == "123456")
            //{
                //MessageBox.Show("Login efeuado com sucesso");
                //Abrir tela principal

                frmPaginaInicial pagina = new frmPaginaInicial();     
                pagina.ShowDialog();
          
            //}
            //else
           /* {
                MessageBox.Show("Login ou senha invalidos.");
                textBox1.Text = "";
                textBox2.Text = "";
            }*/
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
