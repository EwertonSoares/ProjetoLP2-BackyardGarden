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
    public partial class FormCadastrar : Form
    {
        public FormCadastrar()
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

            //if (textBox5.Text != textBox6.Text)
            //{
  



        }

        private void btn_cadastrando_Click(object sender, EventArgs e)
        {
            while (textBox5.Text != textBox6.Text)
            {
                MessageBox.Show("Senhas diferentes, tente novamente");
            }

            Person newUser = new Person();
            newUser.name = textBox1.Text;
            newUser.email = textBox2.Text;
            newUser.estado = textBox3.Text;
            newUser.cidade = textBox4.Text;
            newUser.password = textBox5.Text;
            newUser.confirmPassword = textBox6.Text;
            
            //MessageBox.Show(newUser.name, newUser.email);
            //MessageBox.Show(newUser.estado, newUser.cidade);
            //MessageBox.Show(newUser.password, newUser.confirmPassword);
        }

    }
}
