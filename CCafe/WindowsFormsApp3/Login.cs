using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCafe
{
    public partial class Login : Form
    {
        Controller ctrl;
        public Login()
        {
            InitializeComponent();
            ctrl = new Controller();
        }

        private void SignInBTN_Click(object sender, EventArgs e)
        {

            int ID = Convert.ToInt32(UserNameTB.Text);
            string password = PasswordTB.Text.ToString();
            int Usertype = ctrl.CheckForUser(ID, password);
            if(Usertype == 0)
            {
                MessageBox.Show("Please Enter The Correct ID and Password");
            }

            else if(Usertype == 1)
            {
                WindowHandler.mmain.Show();
                this.Hide();
            }

            else if (Usertype == 2)
            {
                WindowHandler.emain.Show();
                this.Hide();
            }

            else if (Usertype == 3)
            {
                WindowHandler.cmain.Show();
                this.Hide();
            }
        }

        private void SignUpBTN_Click(object sender, EventArgs e)
        {
            WindowHandler.register.Show();
            this.Hide();
        }
    }
}
