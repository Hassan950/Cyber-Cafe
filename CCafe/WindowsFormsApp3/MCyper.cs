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
    public partial class MCyper : Form
    {
        public MCyper()
        {
            InitializeComponent();
        }

        private void HomeBTN_Click(object sender, EventArgs e)
        {
            WindowHandler.mmain.Show();
            this.Hide();
        }

        private void EditFDBTN_Click(object sender, EventArgs e)
        {
            WindowHandler.mfood.Show();
            this.Hide();
        }

        private void ManageBTN_Click(object sender, EventArgs e)
        {
            WindowHandler.mManage.Show();
            this.Hide();
        }

        private void OTBTN_Click(object sender, EventArgs e)
        {
            WindowHandler.mot.Show();
            this.Hide();
        }
    }
}
