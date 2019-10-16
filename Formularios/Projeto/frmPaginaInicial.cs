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
    public partial class frmPaginaInicial : Form
    {

        
        DbConnection db = new DbConnection();
        public frmPaginaInicial()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saindo de sua sessão.");
            Close();
        }

        private void exibirHortalicas(string value)
        {
            showProducts products = new showProducts(value);
            products.ShowDialog();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            {
                string frutosa = "frutosas";
                try
                {
                    exibirHortalicas(frutosa);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                }
            }

        }

        private void btnHort_Click(object sender, EventArgs e)
        {
            {
                string hortalica = "hortalicas";
                try
                {
                    exibirHortalicas(hortalica);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                }
            }
        }
    }
}
