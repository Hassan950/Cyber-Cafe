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
        }

        private void SignInBTN_Click(object sender, EventArgs e)
        {
            //execute query here then the output with if conditions goes to the one who signed in if correct if 0 dont

        }

        private void SignUpBTN_Click(object sender, EventArgs e)
        {
            WindowHandler.register.Show();
            this.Hide();
        }
    }
}
