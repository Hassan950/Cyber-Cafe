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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void SignInBTN_Click(object sender, EventArgs e)
        {
            WindowHandler.login.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void SignUPBTN_Click(object sender, EventArgs e)
        {
            if (UserNameTB.Text == "" || PasswordTB.Text == "" || RePasswordTB.Text == "")
                return;
            if (Convert.ToInt32(UserNameTB.Text) < 10000 || Convert.ToInt32(UserNameTB.Text) > 99999)
            {
                UserNameTB.Text = "";
                MessageBox.Show("ID Must be Between 10000 and 99999");
            }
            else if (PasswordTB.Text.ToString().Length < 6)
            {
                PasswordTB.Text = "";
                RePasswordTB.Text = "";
                MessageBox.Show("Password Length Must be at Least 6");
            }
            else if (PasswordTB.Text.ToString() != RePasswordTB.Text.ToString())
            {
                PasswordTB.Text = "";
                RePasswordTB.Text = "";
                MessageBox.Show("Please Check That The Password Is The Same");
            }
            else
            {
                int IDcheck = Program.ctrl.CreateUser(Convert.ToInt32(UserNameTB.Text), PasswordTB.Text.ToString(), 3);

                if (IDcheck == 0)
                {
                    MessageBox.Show("ID is Already Taken");
                    UserNameTB.Text = "";
                }
                else
                {
                    MessageBox.Show("Registration Complete");
                    Program.ctrl.InsertCustomer(Convert.ToInt32(UserNameTB.Text), NameTB.Text.ToString(), EmailTB.Text.ToString(), PhoneTB.Text.ToString());
                    this.Hide();
                    WindowHandler.login.Show();
                }

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void NameTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
