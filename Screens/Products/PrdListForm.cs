using POSApp.DB.Context;
using POSApp.DB.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSApp.Screens.Products
{
    public partial class PrdListForm : Form
    {

        poscontext context = new poscontext();
        string ImagePath = "";
        public PrdListForm()
        {
            InitializeComponent();
            prdGridView.DataSource = context.Products.ToList();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (txtPrdCode.Text.Length > 0)
            {
                prdGridView.DataSource = (from P in context.Products
                                          where P.Code == txtPrdCode.Text
                                          select P).ToList();
            }

            else if (txtPrdName.Text.Length > 0)
            {
                prdGridView.DataSource = (from P in context.Products
                                          where P.Name.Contains(txtPrdName.Text)
                                          select P).ToList();
            }

            else
            {
                MessageBox.Show("Please Enter At Least One Of The Two Search Properties");
            }




        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPrdCode.Text = string.Empty;
            txtPrdName.Text = string.Empty;
            prdGridView.DataSource = context.Products.ToList();
        }

        private void prdGridView_SelectionChanged(object sender, EventArgs e)
        {
            int index = int.Parse(prdGridView.CurrentRow.Cells[0].Value.ToString());
            var Result = context.Products.SingleOrDefault(P => P.ID == index);

            try
            {
                if (Result != null)
                {
                    textBox2.Text = Result.Code;
                    txtCustName.Text = Result.Name;
                    txtPrdNotes.Text = Result.Notes;
                    txtPrdPrice.Text = Result.Price.ToString();
                    txtPrdQuantity.Text = Result.Quantity.ToString();
                    prdImage.ImageLocation = Result.Image;
                }


            }
            catch { }



            Console.WriteLine();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = int.Parse(prdGridView.CurrentRow.Cells[0].Value.ToString());
            var Result = context.Products.SingleOrDefault(P => P.ID == index);
            Result.Name = txtCustName.Text;
            Result.Code = textBox2.Text;
            Result.Notes = txtPrdNotes.Text;
            Result.Price = decimal.Parse(txtPrdPrice.Text);
            Result.Quantity = int.Parse(txtPrdQuantity.Text);
            Result.Image = prdImage.ImageLocation;

            if (ImagePath != "")
            {
                string newPath = Environment.CurrentDirectory + "\\Images\\Products\\" + Result.ID + ".jpg";
                File.Copy(ImagePath, newPath, true);
                Result.Image = newPath;
            }

            MessageBox.Show("Item Has Been Updated Successfully.");
            prdGridView.Refresh();



        }

        private void txtPrdNotes_TextChanged(object sender, EventArgs e)
        {

        }

        private void prdImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ImagePath = dialog.FileName;
                prdImage.ImageLocation = dialog.FileName;
            }
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {

            var r = MessageBox.Show("Are You Sure You Want To Delete This Product ? ", "Notice", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                int index = int.Parse(prdGridView.CurrentRow.Cells[0].Value.ToString());

                var RemovedItem = context.Products.Find(index);
                context.Products.Remove(RemovedItem);

                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Item Has Been Deleted Successfully.");
                }

                prdGridView.DataSource = context.Products.ToList();

            }


        }

        private void btnAddNewPrd_Click(object sender, EventArgs e)
        {
            ProductFrm frm = new ProductFrm();
            frm.Show();
        }
    }
}
 