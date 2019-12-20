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
    public partial class MMain : Form
    {
        public MMain()
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


        private void GamesBTN_Click(object sender, EventArgs e)
        {
            WindowHandler.egames.Show();
            this.Hide();
        }

        private void CMain_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            label4.Text = Program.UserID.ToString();
            DataTable dt = Program.ctrl.ViewAllFeedback(); //view after insertion
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            PasswordTB.Hide();
            RePasswordTB.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FoodBTN_Click(object sender, EventArgs e)
        {
            WindowHandler.mfood.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ManageBTN_Click(object sender, EventArgs e)
        {
            WindowHandler.mManage.Show();
            this.Hide();
        }

        private void EditCyberBTN_Click(object sender, EventArgs e)
        {
            WindowHandler.mcyper.Show();
            this.Hide();
        }

        private void TournmentsBTN_Click(object sender, EventArgs e)
        {
            WindowHandler.mot.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowHandler.controllerObj.TerminateConnection();
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowHandler.login.Show();
            this.Hide();
        }

        private void UserNameLp_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label5.Show();
            label6.Show();
            label7.Show();
            PasswordTB.Show();
            RePasswordTB.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            try
            {
                if (PasswordTB.Text.ToString() == RePasswordTB.Text.ToString())
                {
                    Program.ctrl.ChangePassword(Program.UserID,1, PasswordTB.Text.ToString());
                    MessageBox.Show("Password Changed Successfully");
                }
                else
                {
                    MessageBox.Show("Please Check that the Passwords are the same");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Please Enter a Correct Password");
            }
            label5.Hide();
            label6.Hide();
            label7.Hide();
            PasswordTB.Hide();
            RePasswordTB.Hide();
        }
    }
}
