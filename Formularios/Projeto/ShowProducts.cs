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
                //MessageBox.Show(lista[i]);

                
                    Button btn = new Button();
                    btn.Name = "btnHorta" + i;
                    btn.Text = lista[i];
                    btn.Width = 100; //Largura
                    btn.Height = 20; //Altura
                    
                //btn.Location = new Point(100, 100);
                //btn.StyleChanged["Position"] = "Absolute"; //CSS
                    btn.Top = num; //Posição na tela, se não será criado um ao lado do outro
                    showData.Controls.Add(btn); //Adicionando o botão
                    //btn.Click += new EventHandler(Button1_Click); //Evento relacionado ao clicar do botão
                  
                    num += 20;
                

                /*private void Button1_Click(object sender, EventArgs e)
                {
                    //Button btn = (Button)sender;
                    //Response.Write("<script>alert('O botao apertado foi: " + btn.ID.ToString() + "')</script>");
                }*/

                //showData.Controls.Add()
            }

            

            /*foreach(var dado in lista)
            {
                showData.DataSource = dado;
            }*/
            
        }
    }
}
