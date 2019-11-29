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
            string table;

            if (rdb_Adm.Checked == true)
            {
                Frm_ShowTableInformation showAdmin = new Frm_ShowTableInformation("USUARIOS");
                showAdmin.ShowDialog();
            }
            if(rdb_frut.Checked == true)
            {
                //table = "pragas";
                /*NovaHortalica nova = new NovaHortalica("DOENÇAS", "FONTES", "PRAGAS");
                nova.ShowDialog();*/
            }
            if(rdb_hort.Checked == true)
            {
                //table = "hortalicas";
                NovaHortalica nova = new NovaHortalica();
                nova.ShowDialog();
            }
  
        }

    }
}
