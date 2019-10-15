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
    public partial class showProducts : Form
    {
        DbConnection db = new DbConnection();
        public showProducts()
        {
            InitializeComponent();
        }

        private void showProducts_Load(object sender, EventArgs e)
        {
            var lista = db.getProducts();

            for(int i = 0; i < lista.Count; i++)
            {
                //Criar botão dinamincamente
                MessageBox.Show(lista[i]);
            }

            

            /*foreach(var dado in lista)
            {
                showData.DataSource = dado;
            }*/
            
        }
    }
}
