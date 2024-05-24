using POSApp.Screens;
using POSApp.Screens.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewUser user = new NewUser();
            user.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductFrm frm = new ProductFrm();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrdListForm frm = new PrdListForm();
            frm.Show();
        }

        private void listProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductFrm frm = new ProductFrm();
            frm.Show();
        }
    }
}
