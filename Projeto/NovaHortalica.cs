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
        public NovaHortalica()
        {
            InitializeComponent();
        }

        List<string> tabela = new List<string>();
        int i;
        int f = 0;
        ProductsConnection conn = new ProductsConnection();
        private void AdicionandoProduto_Load(object sender, EventArgs e)
        {
            getDoencas();
            getFontes();
            getPragas();

        }

        private void getDoencas()
        {
            tabela = conn.getProducts("DOENÇAS");

            for(i = 0; i < tabela.Count; i++)
            {
                DoenÇas.Items.Add(tabela[i]);
            }

        }
        
        private void getFontes() {
            
            tabela = conn.getProducts("FONTES");


            for (f = i; f < tabela.Count; f++)
            {
               Fontes.Items.Add(tabela[f]);
            }
        }

        private void getPragas()
        {

            tabela = conn.getProducts("PRAGAS");

            for (int p = f; p < tabela.Count; p++)
            {
                Pragas.Items.Add(tabela[p]);
            }
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
