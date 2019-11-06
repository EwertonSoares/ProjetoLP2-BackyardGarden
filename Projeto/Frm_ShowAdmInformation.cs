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

        private void updateView()
        {
            ViewAll.DataSource = db.getUserInformation();
        }

        private void Frm_ShowAdm_Load(object sender, EventArgs e)
        {
            ViewAll.DataSource = db.getUserInformation();

        }

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
                updateView();
                //Mensagem();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }

            btn_upd.Enabled = true;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string tipo = "adm";

            db.InsertUserInformation(textBox1.Text, textBox2.Text, textBox3.Text, tipo);

            MessageBox.Show("Usuarios cadastrafo com sucesso");
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
