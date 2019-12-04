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
    public partial class FrmCulturas : Form
    {
        string tableName;

        public FrmCulturas(string tableName)
        {
            InitializeComponent();

            this.tableName = tableName;
        }

        //List<string> tabela = new List<string>();
        List<string> listaNomes = new List<string>();
        List<string> lista = new List<string>();

        ProductsConnection conn = new ProductsConnection();
        DataTable dt = new DataTable();
        AdminAccess db = new AdminAccess();

        public List<string> getNomes(DataTable dt, string col)
        {
            List<string> valores = new List<string>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string valor = (string)dt.Rows[i][col];
                valores.Add(valor);
            }

            return valores;
        }


        private void FrmHortalicas_Load(object sender, EventArgs e)
        {
            string id = "id_hort";

            if (tableName == "FRUTIFERAS")
            {
                id = "id_frutifera";
            }

            hotGred.DataSource = db.getTableInformation(tableName);
            hotGred.Columns[id].ReadOnly = true;

            int d;
            //int atr;
            int f = 0;

            string[] atributo = {"epoca", "colheita"};

            string nomes = "Nome";

            //Preenchendo primeiro checkbox
            dt = conn.getProducts("DOENCAS");
            listaNomes = getNomes(dt, nomes);

            for (d = 0; d < listaNomes.Count; d++)
             {
                  ckb1.Items.Add(listaNomes[d]);
             }

            //Preenchendo segundo checkbox
            dt = conn.getProducts("FONTES");
            listaNomes = getNomes(dt, nomes);

            for (f = d; f < listaNomes.Count; f++)
             {
                 ckb2.Items.Add(listaNomes[f]);
             }

            //Preenchendo terceiro checkbox
            dt = conn.getProducts("PRAGAS");
            listaNomes = getNomes(dt, nomes);

            for (int p = f; p < listaNomes.Count; p++)
              {
                 ckb3.Items.Add(listaNomes[p]);
              }



        }
    }
}
