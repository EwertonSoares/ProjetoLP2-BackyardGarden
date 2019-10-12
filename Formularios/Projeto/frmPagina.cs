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
    public partial class frmPagina : Form
    {
        public frmPagina()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saindo de sua sessão.");
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
