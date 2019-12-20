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
        public Login()
        {
            InitializeComponent();
            
        }

        private void SignInBTN_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(UserNameTB.Text);
                string password = PasswordTB.Text.ToString();
                int Usertype = WindowHandler.controllerObj.CheckForUser(ID, password);
                if (Usertype == 0)
                {
                    throw new Exception("Please Enter The Correct ID and Password");
                }

                else if (Usertype == 1)
                {
                    Program.UserID = ID;
                    WindowHandler.mmain.Show();
                    this.Hide();
                    
                }

                else if (Usertype == 2)
                {
                    Program.UserID = ID;
                    WindowHandler.emain.Show();
                    this.Hide();
                    
                }

                else if (Usertype == 3)
                {
                    Program.UserID = ID;
                    WindowHandler.cmain.Show();
                    this.Hide();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid ID that consists of Digits.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SignUpBTN_Click(object sender, EventArgs e)
        {
            WindowHandler.register.Show();
            this.Hide();
        }
    }
}
