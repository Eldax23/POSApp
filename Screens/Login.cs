using POSApp.DB.Context;

namespace POSApp
{
    public partial class Login : Form
    {

        poscontext context = new poscontext();
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var Result = context.Users.Where(U => U.UserName == txtUserName.Text && U.Password == txtPassword.Text);

            if (Result.Count() > 0)
            {
                this.Close();
                Thread th = new Thread(openForm);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
            {
                MessageBox.Show("UserName or Password are Invalid.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }


        }

        void openForm()
        {
            Application.Run(new MainForm());
        }
    }
}
