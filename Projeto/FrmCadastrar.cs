using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class FrmCadastrar : Form
    {
        public FrmCadastrar()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormCadastrar_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cadastrando_Click(object sender, EventArgs e)
        {
            bool senha = true;

            //Verificando se a senha e confirmar senha são diferentes
            do
            {
                if (textBox5.Text != textBox6.Text)
                {
                    textBox5.Text = "";
                    textBox6.Text = "";
                    senha = false;
                    MessageBox.Show("Tente novamente!", "Senhas divergentes", MessageBoxButtons.OK, MessageBoxIcon.Error);       
                }
             
            } while (senha != true);

            //Verificando se a senha tem menos de 8 caracteries
            /*do
            { 
                if (textBox5.Text.Length < 8 || textBox6.Text.Length < 8)
                {
                    senha = false;
                    textBox5.Text = "";
                    textBox6.Text = "";
                    MessageBox.Show("Senha deve conter no minimo 8 digitos", "Senha Invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } while (senha != true);*/


            //Cadastrando novo usuario
            bool sucesso = true;

                Usuario novoUsuario = new Usuario();
                novoUsuario.setUser(textBox1.Text, textBox2.Text, textBox3.Text, 
                textBox4.Text, textBox5.Text, textBox6.Text);


                /* Enviar objeto para o banco de dados caso o objeto seja salvo
                 a variavel "sucesso" deve permancer com valor "true" caso contrario a mesma
                 deve ser setada para "false". */

                //Exibir mensagem caso o objeto seja salvo ou não
                if(sucesso)
                {
                    MessageBox.Show("Cadastro realizado com sucesso");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Não foi possivel fazer o cadasrtro, tente fazer o cadastro novamente", "Erro ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = "";
               }

        }

    }
}
