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
    public partial class FrmUpPass : Form
    {
        UserAccess acesso = new UserAccess();

        string emailValue;

        public FrmUpPass(string value)
        {
            InitializeComponent();

            this.emailValue = value;
        }

        private void FrmUpPass_Load(object sender, EventArgs e)
        { 

        }

        private void buttonSavePass_Click(object sender, EventArgs e)
        {
            acesso.updPassword(txb_novaSenha.Text, emailValue);
            MessageBox.Show("Senha alterada com sucesso");
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
