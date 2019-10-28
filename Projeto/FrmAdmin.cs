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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void btn_entarAdmin_Click(object sender, EventArgs e)
        {
            if (rdb_Adm.Checked == true)
            {
                Frm_ShowAdm showAdmin = new Frm_ShowAdm("Adm");
                ShowDialog();
            }
            if(rdb_fert.Checked == true)
            {

            }
            if(rdb_frut.Checked == true)
            {

            }
            if(rdb_hort.Checked == true)
            {

            }
            if(rdb_pest.Checked == true)
            {

            }
        }
    }
}
