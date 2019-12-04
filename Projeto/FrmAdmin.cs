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
            //string table;

            if (rdb_Adm.Checked == true)
            {
                Frm_ShowTableInformation showAdmin = new Frm_ShowTableInformation("USUARIOS");
                showAdmin.ShowDialog();
            }
            if(rdb_frut.Checked == true)
            {
                FrmCulturas nova = new FrmCulturas("FRUTIFERAS");
                nova.ShowDialog();
            }
            if(rdb_hort.Checked == true)
            {
                //table = "hortalicas";
                FrmCulturas nova = new FrmCulturas("HORTALICAS");
                nova.ShowDialog();
            }

            if (rdb_font.Checked == true)
            {
                FrmPDF pdf = new FrmPDF("FONTES");
                pdf.ShowDialog();
            }

            if (rdb_prag.Checked == true)
            {
                FrmPDF pdf = new FrmPDF("PRAGAS");
                pdf.ShowDialog();
            }

            if (rdb_doen.Checked == true)
            {
                FrmPDF pdf = new FrmPDF("DOENCAS");
                pdf.ShowDialog();
            }

  
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
