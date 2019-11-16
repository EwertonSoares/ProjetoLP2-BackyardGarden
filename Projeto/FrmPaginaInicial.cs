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
    public partial class FrmPaginaInicial : Form
    {

        
        UserAccess db = new UserAccess();
        public FrmPaginaInicial()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saindo de sua sessão.");
            Close();
        }

        private void exibir(string tableName)
        {
            showProducts products = new showProducts(tableName);
            products.ShowDialog();
        }

        private void btnHort_Click(object sender, EventArgs e)
        {
            {       
                try
                {
                    exibir("Hortalicas");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                }
            }
        }

        private void btn_Frt_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    exibir("Fruticolas");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                }
            }
        }
    }
}
