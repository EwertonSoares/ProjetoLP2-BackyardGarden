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
        ProductsAccess db = new ProductsAccess();

        static int num = 0;
        static string tableName;
        public showProducts(string name)
        {
            tableName = name;
            InitializeComponent();
        }

        private void showProducts_Load(object sender, EventArgs e)
        {
            var lista = db.getProducts(tableName);

            for (int i = 0; i < lista.Count; i++)
            {

                Button btn = new Button();
                btn.Name = i.ToString();
                btn.Text = lista[i].ToUpper();
                btn.Width = 330; //Largura
                btn.Height = 50; //Altura
                btn.Top = num;
                btn.TextAlign = ContentAlignment.MiddleLeft;
                showData.Controls.Add(btn); //Adicionando o botão
                showData.Height += 20; //Aumentando tamanho do DataGridView
                btn.Click += new EventHandler(btn_Click);
                num += 40;
            }

        }

        void btn_Click(object sender, EventArgs e)
        {
             Button btn = (Button)sender;
            MessageBox.Show("Testando Evento");
        }

    }
}
