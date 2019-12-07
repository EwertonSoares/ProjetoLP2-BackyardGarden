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
        bool newuser;

        string connection = @"Host=127.0.0.1;Username=postgres;Password=bruno2108;Database=newBD";

        string insert = "Insert into usuarios (nome, sobrenome, email, senha)" +
                        "value (@nome, @sobrenome, @email, @senha)";

        UserAccess acesso = new UserAccess();

        public FrmCadastrar()
        {
            InitializeComponent();
        }

        private void FormCadastrar_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_cadastrando_Click(object sender, EventArgs e)
        {
            acesso.addUser(txbNome.Text, txbSobrenome.Text, txbEmail.Text, txbSenha.Text);
            MessageBox.Show("Cadastro realizado com sucesso!!", "Use seus dados cadastrados para realizar o Login!!");
            /*bool senha = true;
            //Verificando se a senha e confirmar senha são diferentes         
                if (txbSenha.Text != txbConfSenha.Text)
                {
                    txbSenha.Text = "";
                    txbConfSenha.Text = "";
                    senha = false;
                    MessageBox.Show("Tente novamente!", "Senhas divergentes", MessageBoxButtons.OK, MessageBoxIcon.Error);       
                }
            
            //Verificando se a senha tem menos de 8 caracteries
                if (txbSenha.Text.Length < 8 || txbConfSenha.Text.Length < 8)
                {
                    senha = false;
                    txbSenha.Text = "";
                    txbConfSenha.Text = "";
                    MessageBox.Show("Senha deve conter no minimo 8 digitos", "Senha Invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            acesso.addUser(txbNome.Text, txbSobrenome.Text, txbMail.Text, txbSenha.Text);
            MessageBox.Show("Cadastro realizado com sucesso!!");*/

            //Cadastrando novo usuario
            bool sucesso = true;

                /*Usuario novoUsuario = new Usuario();
                novoUsuario.setUser(txbNome.Text, txbSobrenome.Text, txbMail.Text, 
                txbSenha.Text, txbConfSenha.Text);*/


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
                        txbNome.Text = "";
                        txbSobrenome.Text = "";
                        txbEmail.Text = "";
                        txbSenha.Text = "";
                        txbConfSenha.Text = "";
               }
        }

    }
}
