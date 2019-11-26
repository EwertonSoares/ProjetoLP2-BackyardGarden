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
    public partial class NovaHortalica : Form
    {
        private string tablePragas;
        private string tableDoencas;
        private string tableFontes;

        public NovaHortalica(string tablePragas, string tableDoencas, string tableFontes)
        {
            InitializeComponent();

            this.tablePragas = tablePragas;
        }

        ProductsConnection conn = new ProductsConnection();
        private void AdicionandoProduto_Load(object sender, EventArgs e)
        {
            List<string> tabelas = new List<string>();

            tabelas = conn.getProducts(tablePragas);

            foreach(string item in tabelas)
            {
                Fontes.Items.Add(item);
            }
            

            tabelas = conn.getProducts(tablePragas);

            foreach (string item in tabelas)
            {
                Pragas.Items.Add(item);
            }


            tabelas = conn.getProducts(tableDoencas);

            foreach (string item in tabelas)
            {
                Doencas.Items.Add(item);
            }


            /* Fontes.Items.Add("NOME2");
            Fontes.Items.Add("NOME3");
            Fontes.Items.Add("NOME4");
            Fontes.Items.Add("NOME5");*/

        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* string teste = string.Empty;

            foreach(object o in checkedListBox1.CheckedItems)
            {
                teste += o.ToString() + Environment.NewLine; 
            }

            if(teste != string.Empty)
            {
                MessageBox.Show(teste);
            }*/
        }
    }
}
