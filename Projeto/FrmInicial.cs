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
    public partial class FrmInicial : Form
    {
        public FrmInicial()
        {
            InitializeComponent();
        }

        private void btn_newlist_Click(object sender, EventArgs e)
        {
            FrmSegundaPagina segunda = new FrmSegundaPagina();
            segunda.ShowDialog();
        }

        private void btn_mylist_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmEditarPerfil profile = new FrmEditarPerfil();
            profile.ShowDialog();
        }
    }
}
