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
    public partial class ProductFrm : Form
    {

        poscontext context = new poscontext();
        string ImagePath = "";
        public ProductFrm()
        {
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (txtPrdName.Text == "" || txtPrdCode.Text == "" || txtPrdPrice.Text == "")
            {
                MessageBox.Show("Enter The Required Information", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                Product prd = new Product();
                prd.Name = txtPrdName.Text;
                prd.Code = txtPrdCode.Text;
               // prd.Price = decimal.Parse(txtPrdPrice.Text);
                prd.Notes = txtPrdNotes.Text;
               // prd.Quantity = int.Parse(txtPrdQuantity.Text);
                prd.Image = ImagePath;

                int price, qty;
                int.TryParse(txtPrdPrice.Text, out price);
                int.TryParse(txtPrdQuantity.Text, out qty);


                    prd.Quantity = qty;
                prd.Price = price;
                

                var CheckIfExists = context.Products.Where(P => P.Code == prd.Code).ToList().Count;

                if (CheckIfExists > 0)
                {
                    MessageBox.Show("This Product Code Already Exists , Enter Another One");
                }
                else
                {
                    context.Products.Add(prd);
                    txtPrdCode.Text = "";
                    txtPrdName.Text = "";
                    txtPrdQuantity.Text = "";
                    txtPrdPrice.Text = "";
                    txtPrdNotes.Text = "";
                    prdImage.ImageLocation = "";

                }




                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Product Has Been Added Succesfully.");

                }

                if(ImagePath != "")
                {
                    string newPath = Environment.CurrentDirectory + "\\Images\\Products\\" + prd.ID + ".jpg";
                    File.Copy(ImagePath, newPath);
                    prd.Image = newPath;
                    context.SaveChanges();
                }



                
            }

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
    }
}
