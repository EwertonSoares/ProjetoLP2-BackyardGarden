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
        int id = 0;
        AdminAccess db = new AdminAccess();

        private string labelName;
        private string tableName;
        public Frm_ShowAdmInformation(string labelName, string tableName)
        {
            InitializeComponent();

            this.labelName = labelName;
            this.tableName = tableName;
        }

        private void updateView()
        {
            ViewAll.DataSource = db.getTableInformation(tableName);
        }

        private void Frm_ShowAdm_Load(object sender, EventArgs e)
        {
            ViewAll.DataSource = db.getTableInformation(tableName);

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
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty || textBox3.Text == string.Empty)
            {
                textBox1.Focus();
                return;
            }

            try
            {
                db.updateInformation("Admistradores", id, textBox2.Text, textBox3.Text);
                updateView();
                //Mensagem();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
            btn_upd.Enabled = true;
        }

            private void dgvFunci_CellEnter(object sender, DataGridViewCellEventArgs e)
            {
                id = Convert.ToInt32(ViewAll.Rows[e.RowIndex].Cells[0].Value);
                textBox1.Text = Convert.ToString(ViewAll.Rows[e.RowIndex].Cells[1].Value);
                textBox2.Text = Convert.ToString(ViewAll.Rows[e.RowIndex].Cells[2].Value);
                textBox3.Text = Convert.ToString(ViewAll.Rows[e.RowIndex].Cells[3].Value);
            }

        private void btn_add_Click(object sender, EventArgs e)
        {
            db.InsertInformation("Administradores", textBox1.Text, textBox2.Text, textBox3.Text);
        }

    }
}
