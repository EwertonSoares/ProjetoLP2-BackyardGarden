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

    public List<string> getNomes(DataTable dt, string col)
    {
        List<string> nomes = new List<string>();


        for (int i = 0; i < dt.Rows.Count; i++)
        {
            string nome = (string)dt.Rows[i][col];
            nomes.Add(nome);
        }

        return nomes;
    }

    //List<string> tabela = new List<string>();
    List<string> listaNomes = new List<string>();
    List<string> listaEpoca = new List<string>();


    ProductsConnection conn = new ProductsConnection();
    DataTable dt = new DataTable();

    private void AdicionandoProduto_Load(object sender, EventArgs e)
    {
            int d;
            int ep;
            int f = 0;

            string[] atributo = {"epoca", "colheita","propagacao", "produtividade", "semeadura_direta"};

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


            //Preenchendo combobox epoca do plantio
             dt = conn.getProducts("HORTALICAS");
             listaEpoca = getNomes(dt, atributo[0]);
         
            for (ep = 0; ep < listaEpoca.Count; ep++)
            {
                //ckb1.Items.Add(listaNomes[d]);
                cbb1.Items.Add(listaEpoca[ep]);

            }
            

        }

        private void button1_Click(object sender, EventArgs e)
    {
        List<string> doen = new List<string>();

        foreach(object item in ckb1.CheckedItems)
        {
                doen.Add(item.ToString() + Environment.NewLine);

        }

        MessageBox.Show("iuvlv");


        /*if (teste != string.Empty)
        {
            MessageBox.Show(teste);
        }*/
    }

}
}
