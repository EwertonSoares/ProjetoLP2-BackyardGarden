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

        static int num = 0;
        static string valueParam;

        public showProducts(string value)
        {
            valueParam = value;
            InitializeComponent();
        }

        private void showProducts_Load(object sender, EventArgs e)
        {
            var lista = db.getProductsName(valueParam);

            for (int i = 0; i < lista.Count; i++)
            {

                Button btn = new Button
                {
                    Name = "btnBg" + i,
                    Text = lista[i].ToUpper(),
                    Width = 330, //Largura
                    Height = 50, //Altura
                    Top = num,
                    TextAlign = ContentAlignment.MiddleLeft
                };
                showData.Controls.Add(btn); //Adicionando o botão
                showData.Height += 20; //Aumentando tamanho do DataGridView
                btn.Click += new EventHandler(btn_Click);
                num += 40;
            }

        }

        void btn_Click(object sender, EventArgs e)
        {
             //Button btn = (Button)sender;
            MessageBox.Show("Testando Evento");
        }

        private void showData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frmPaginaInicial frmPaginaInicial = new frmPaginaInicial();
            frmPaginaInicial.ShowDialog();
        }
    }
}
