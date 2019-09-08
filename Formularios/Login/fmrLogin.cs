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
            //Conectar banco de dados para trazer usuarios cadastrados
            /*Provavelmente um objeto sera trazido do banco, 
             * talvez seja viavel fazer um forEach*/
            if (textBox1.Text == "ewerton" && textBox2.Text == "123456")
            {
                MessageBox.Show("Login efeuado com sucesso");
            }
            else
            {
                MessageBox.Show("Login ou senha invalidos.");
            }
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            FormCadastrar cadastrar = new FormCadastrar();
            cadastrar.ShowDialog();
            //this.Close();
        }
    }
}
