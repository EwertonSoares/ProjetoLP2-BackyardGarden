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

        public FrmUpPass()
        {
            InitializeComponent();
        }

        private void FrmUpPass_Load(object sender, EventArgs e)
        { 

        }

        private void buttonSavePass_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
