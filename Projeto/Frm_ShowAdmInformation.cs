﻿using System;
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
    public partial class Frm_ShowAdmInformation : Form
    {
        int id = 0;

        AdminAccess db = new AdminAccess();

        string tableName;
        public Frm_ShowAdmInformation(string table)
        {
            InitializeComponent();
            this.tableName = table;
        }

        private void Frm_ShowAdm_Load(object sender, EventArgs e)
        {
            ViewAll.DataSource = db.getTableInformation(tableName);
            ViewAll.Columns["id"].ReadOnly = true;

        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.ViewAll.SelectedRows)
            {
                ViewAll.Rows.RemoveAt(item.Index);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            db.saveInformation();         
        }
    }
}
