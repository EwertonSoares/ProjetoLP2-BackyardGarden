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
    public partial class FrmInicial : Form
    {
        string emailValue;

        UserAccess acesso = new UserAccess();

        public FrmInicial(string value)
        {
            InitializeComponent();

            this.emailValue = value;
        }

        public List<string> getData(DataTable dt)
        {
            string valor1;
            string valor2;
            string valor3;

            List<string> valores = new List<string>();

            for (int i = 0; i < 1; i++)
            {
                valor1 = (string)dt.Rows[i]["NOME"];
                valor2 = (string)dt.Rows[i]["SOBRENOME"];
                valor3 = (string)dt.Rows[i]["EMAIL"];
                valores.Add(valor1);
                valores.Add(valor2);
                valores.Add(valor3);
               
            }

            return valores;
        }


        private void btn_newlist_Click(object sender, EventArgs e)
        {
            FrmSegundaPagina segunda = new FrmSegundaPagina();
            segunda.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            List<string> dados = new List<string>();

            dt = acesso.getUser(emailValue);

            dados = getData(dt);

            FrmEditarPerfil perfil = new FrmEditarPerfil(dados, emailValue);
            perfil.ShowDialog();

            
        }
    }
}
