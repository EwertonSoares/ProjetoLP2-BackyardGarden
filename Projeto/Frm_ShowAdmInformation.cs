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
    public partial class Frm_ShowAdmInformation : Form
    {
        string id;
        AdminAccess db = new AdminAccess();
        public Frm_ShowAdmInformation()
        {
            InitializeComponent();
        }

        //Atualizando exibição dos dados
        private void updateView()
        {
            if (ViewAll.Rows.Count.Equals(0))
            {

                ViewAll.DataSource = db.getUserInformation();
            }
            else
            {
                for (int i = 0; i < ViewAll.RowCount; i++)
                {
                    ViewAll.Rows[i].DataGridView.Columns.Clear();
                    //ViewAll.Rows.Clear();
                    //ViewAll.Refresh();

                }
            }

            }

        //Limpar exibição dos dados
        /*private void clearView()
        {
            for (int i = 0; i < ViewAll.RowCount; i++)
           {
                ViewAll.Rows[i].DataGridView.Columns.Clear();
               // ViewAll.Refresh();
            //ViewAll.Rows.Clear();
           }
        }*/

        //Evento para atualizar exebição
        private void btn_show_Click(object sender, EventArgs e)
        {
            try
            {
                updateView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }

        }

        //Evento para atualizar informações do usuario
        private void btn_upd_Click(object sender, EventArgs e)
        {
            id = ViewAll.CurrentRow.Cells[0].Value.ToString();
        
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty || textBox3.Text == string.Empty)
            {
                textBox1.Focus();
                return;
            }

            try
            {
                db.updateUserInformation(int.Parse(id), textBox1.Text, textBox2.Text, textBox3.Text);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro : " + erro.Message);
            }

            //btn_upd.Enabled = true;
        }

        //Evento para adicionar um usuario
        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                string tipo = "adm";

                db.InsertUserInformation(textBox1.Text, textBox2.Text, textBox3.Text, tipo);
               
                MessageBox.Show("Usuarios cadastrado com sucesso");
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        //Evento para deletar um usuario
        private void bnt_delete_Click(object sender, EventArgs e)
        {
            id = ViewAll.CurrentRow.Cells[0].Value.ToString();

            try
            { 

                db.DeleteUserInformation(int.Parse(id));

                MessageBox.Show("Usuario deletado com sucesso");
                //clearView();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro : " + erro.Message);
            }

        }

        //Evento para sair da tela de administrador
        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
