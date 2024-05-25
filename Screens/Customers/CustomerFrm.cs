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

namespace POSApp.Screens.Customers
{
    public partial class CustomerFrm : Form
    {
        poscontext context = new poscontext();
        string ImagePath = "";

        public CustomerFrm()
        {
            InitializeComponent();
            custGridView.DataSource = context.Customers.ToList();
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            if (txtPhone.Text != "")
            {
                custGridView.DataSource = context.Customers.Where(C => C.Phone.Contains(txtPhone.Text) || C.Name.Contains(txtName.Text)).ToList();
            }
            else if (txtPhone.Text == "")
            {
                custGridView.DataSource = context.Customers.Where(C => C.Name.Contains(txtName.Text)).ToList();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            custGridView.DataSource = context.Customers.ToList();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {

            if(custNameTxt.Text == "" || txtCustPhone.Text == "")
            {
                MessageBox.Show("Please Enter The Requireddd Information.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Customer Cust = new Customer();
                Cust.Name = custNameTxt.Text;
                Cust.Phone = txtCustPhone.Text;
                Cust.Notes = txtCustNotes.Text;
                Cust.Email = txtCustEmail.Text;
                Cust.Address = txtCustAddress.Text;
                Cust.Company = txtCompany.Text;
                Cust.IsActive = checkBox1.Checked;
                Cust.Image = custImg.ImageLocation;

                if (ImagePath != "")
                {
                    string newPath = Environment.CurrentDirectory + "\\Images\\Customers\\" + Cust.ID + ".jpg";
                    File.Copy(ImagePath, newPath);
                    Cust.Image = newPath;
                }

                context.Customers.Add(Cust);

                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Item ddd Been Added Succesfully.");
                    Cust.Name = "";
                    Cust.Phone = "";
                    Cust.Notes = "";
                    Cust.Email = "";
                    Cust.Address = "";
                    Cust.Company = "";
                    Cust.Image = "";
                }

                else
                {
                    MessageBox.Show("ed To Add Item.");
                }
            }

        }

        private void custImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                custImg.ImageLocation = dialog.FileName;
                ImagePath = dialog.FileName;
            }
        }
    }
}
