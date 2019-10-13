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
    public partial class showProducts : Form
    {
        BDConnection db = new BDConnection();
        public showProducts()
        {
            InitializeComponent();
        }

        private void showProducts_Load(object sender, EventArgs e)
        {
            showData.DataSource = db.getAllUsers();
        }
    }
}
