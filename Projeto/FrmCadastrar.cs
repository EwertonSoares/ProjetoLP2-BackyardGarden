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

//biblioteca Npgsql
using Npgsql;
using NpgsqlTypes;

namespace Login
{
    public partial class FrmCadastrar : Form
    {
        

        public FrmCadastrar()
        {
            InitializeComponent();
        }

        private void FormCadastrar_Load(object sender, EventArgs e)
        {
            string connection = @"Host=127.0.0.1;Username=postgres;Password=brun2108;Database=newBd";

            string insert = "INSERT INTO USUARIOS" +
                "(NOME, SOBRENOME, EMAIL, SENHA)" + 
                "VALUES (@NOME, @SOBRENOME, @EMAIL, @SENHA);";

            NpgsqlConnection conn = new NpgsqlConnection(connection);
            
            try
            {
             
            }

            catch
            {

            }

            finally
            {

            }
        }

        private void btn_cadastrando_Click(object sender, EventArgs e)
        {
            bool senha = true;

            //Verificando se a senha e confirmar senha são diferentes
            do
            {
                if (textBox4.Text != textBox5.Text)
                {
                    textBox4.Text = "";
                    textBox5.Text = "";
                    senha = false;
                    MessageBox.Show("Tente novamente!", "Senhas divergentes", MessageBoxButtons.OK, MessageBoxIcon.Error);       
                }
             
            } while (senha != true);

            //Verificando se a senha tem menos de 8 caracteries
            do
            { 
                if (textBox4.Text.Length < 8 || textBox5.Text.Length < 8)
                {
                    senha = false;
                    textBox4.Text = "";
                    textBox5.Text = "";
                    MessageBox.Show("Senha deve conter no minimo 8 digitos", "Senha Invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } while (senha != true);


            //Cadastrando novo usuario
            /*bool sucesso = true;

                Usuario novoUsuario = new Usuario();
                novoUsuario.setUser(textBox1.Text, textBox2.Text, textBox3.Text, 
                textBox4.Text, textBox5.Text);


                // Enviar objeto para o banco de dados caso o objeto seja salvo
                // a variavel "sucesso" deve permancer com valor "true" caso contrario a mesma
                // deve ser setada para "false". 

                //Exibir mensagem caso o objeto seja salvo ou não
                if(sucesso)
                {
                    MessageBox.Show("Cadastro realizado com sucesso");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Não foi possivel fazer o cadastro, tente novamente", "Erro ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
               }*/

        }
    }
}
