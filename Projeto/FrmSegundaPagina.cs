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
    public partial class FrmSegundaPagina : Form
    {

        
        UserAccess db = new UserAccess();
        public FrmSegundaPagina()
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

        //Chamando datagridview para exibir todas as hortalicas
        private void btnHort_Click(object sender, EventArgs e)
        {
            {       
                try
                {
                    exibir("HORTALICAS");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                }
            }
        }

        //Chamando datagridview para exibir todas as frutiferas
        private void btn_Frt_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    exibir("FRUTIFERAS");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                }
            }
        }
    }
}
