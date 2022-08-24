using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp.GeneralManagement
{
    public partial class frmGeneralManagement : Form
    {
        public frmGeneralManagement()
        {
            InitializeComponent();
        }

        private void btnProductManagement_Click(object sender, EventArgs e)
        {
            frmProduct ProductsForm = new frmProduct();
            this.Hide();
            ProductsForm.ShowDialog();
        }

        private void btnMemberManagement_Click(object sender, EventArgs e)
        {

        }
    }
}
