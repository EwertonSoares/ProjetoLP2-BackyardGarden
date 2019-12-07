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

        NovoRelatorio novoRel = new NovoRelatorio();
        ProductsConnection db = new ProductsConnection();

        static int num = 0;
        string tableName;

        DataTable dt = new DataTable();
        List<string> lista = new List<string>();

         public showProducts(string name)
        {
            this. tableName = name;
            InitializeComponent();
        }

        private void showProducts_Load(object sender, EventArgs e)
        {

            dt = db.getProducts(tableName);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string nome = (string)dt.Rows[i]["Nome"];
                lista.Add(nome);
            }

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

            string nomeRel = btn.Text;

            novoRel.gerarRelatorio(nomeRel.ToLower(), tableName);

            MessageBox.Show("Relatorio gerado com sucesso");

            System.Diagnostics.Process.Start(novoRel.caminho);
            }
           }
        }
