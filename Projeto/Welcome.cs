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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void btn_welcome_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.ShowDialog();
        }
    }
}
