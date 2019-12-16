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
    public partial class EFood : Form
    {
        public EFood()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //panel1.BackColor = Color.FromArgb(35, 135, 200);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ReserveBTN_Click(object sender, EventArgs e)
        {

        }

        private void FeedBTN_Click(object sender, EventArgs e)
        {
            WindowHandler.cfeedback.Show();
            this.Hide();
        }


        private void CMain_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void GamesBTN_Click(object sender, EventArgs e)
        {
            WindowHandler.egames.Show();
            this.Hide();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            WindowHandler.emain.Show();
            this.Hide();
        }
    }
}
