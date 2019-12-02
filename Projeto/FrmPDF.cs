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
    public partial class FrmPDF : Form
    {
        string tableName;

        public FrmPDF(string tableName)
        {
            InitializeComponent();

            this.tableName = tableName;
        }

        //ProductsConnection conn = new ProductsConnection();
        DataTable dt = new DataTable();
        AdminAccess db = new AdminAccess();

        private void FrmPDF_Load(object sender, EventArgs e)
        {
            string id = "id_praga";

            if (tableName == "DOENCAS")
            {
                id = "id_doenca";
            }

            else if (tableName == "FONTES")
            {
                id = "id_fonte";
            }
            

            PDFGred.DataSource = db.getTableInformation(tableName);
            PDFGred.Columns[id].ReadOnly = true;
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.PDFGred.SelectedRows)
            {
                PDFGred.Rows.RemoveAt(item.Index);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            db.saveInformation();
            MessageBox.Show("salvo com sucesso");
            MessageBox.Show("Teste");
        }
    }
}
