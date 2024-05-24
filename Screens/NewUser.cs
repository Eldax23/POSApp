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

namespace POSApp.Screens
{
    public partial class NewUser : Form
    {

        poscontext context = new poscontext();
        string ImagePath;
        public NewUser()
        {
            InitializeComponent();
            
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            UserDB U = new UserDB();
            U.UserName = txtUserName.Text;
            U.Password = txtPassword.Text;
            U.Image = ImagePath;
            context.Users.Add(U);

            //context.Users.Add(new UserDB()
            //{
            //    UserName = txtUserName.Text,
            //    Password = txtPassword.Text,
            //});
            int isAdded = context.SaveChanges();

            string newPath = Environment.CurrentDirectory + "\\Images\\Users\\" + U.ID + ".jpg";
            File.Copy(ImagePath, Environment.CurrentDirectory + "\\Images\\Users\\" + U.ID + ".jpg");

            if (isAdded > 0)
            {
                MessageBox.Show("Item Has Been Added Succesfully.");
            }
            else
            {
                MessageBox.Show("Adding Failed");
            }

            U.Image = newPath;
            context.SaveChanges();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                ImagePath = dialog.FileName;
                pictureBox1.ImageLocation = dialog.FileName;
            }
        }
    }
}
