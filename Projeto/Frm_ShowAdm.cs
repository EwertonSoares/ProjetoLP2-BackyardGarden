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
    public partial class Frm_ShowAdm : Form
    {
        private string labelName;
        public Frm_ShowAdm(string labelName)
        {
            InitializeComponent();

            labelName = this.labelName;
        }
        
        int num = 0;
    
        private void Frm_ShowAdm_Load(object sender, EventArgs e)
        {
           // var[] labelsList = 2;
            for (int i = 0; i <= 10; i++)
            {
                Label lbl = new Label();
                lbl.Name = labelName + i;
               // lbl.Text = labelsList[i].ToUpper();
                lbl.Top = num;
                lbl.TextAlign = ContentAlignment.MiddleLeft;
                DgvAdm.Controls.Add(lbl); //Adicionando o botão
                DgvAdm.Height += 20; //Aumentando tamanho do DataGridView
                num += 40;
            }
        }
        
        /* static void generatingLabels(string labelName)
         {
             //var lista = db.getProducts();

             // for (int i = 0; i < lista.Count; i++)
             //{


             //}
         }*/

    }
}
