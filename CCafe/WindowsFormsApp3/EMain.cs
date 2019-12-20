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
    public partial class EMain : Form
    {
        public EMain()
        {
            InitializeComponent();
            DataTable dt1 = WindowHandler.controllerObj.ViewAvailibleConsoles();
            dataGridView1.DataSource = dt1;
            dataGridView1.Refresh();

            DataTable dt2 = WindowHandler.controllerObj.ViewRoomNumber();
            comboBoxRoomNumber.DataSource = dt2;
            comboBoxRoomNumber.DisplayMember = "number";
            comboBoxRoomNumber.ValueMember = "number";
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
            // TODO: This line of code loads data into the 'cyber_CafeDataSet.Console' table. You can move, or remove it, as needed.
            //this.consoleTableAdapter.Fill(this.cyber_CafeDataSet.Console);
            label5.Hide();
            label8.Hide();
            label7.Hide();
            PasswordTB.Hide();
            RePasswordTB.Hide();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FoodBTN_Click(object sender, EventArgs e)
        {
            WindowHandler.efood.Show();
            this.Hide();
        }

        private void ViewBTN_Click(object sender, EventArgs e)
        {

        }

        private void UpdateBTN_Click(object sender, EventArgs e)
        {
            if ( comboBoxRoomNumber.SelectedValue == null || ((radioButtonWorking.Checked == false && radioButtonNotWorking.Checked == false)))
            {
                MessageBox.Show("Please Select All Fields To Update");
                return;

            }
            else
            {
                int roomNumber = Convert.ToInt16(comboBoxRoomNumber.SelectedValue);
                string condition;

                if (radioButtonWorking.Checked)
                {
                    condition = "okay";
                }
                else
                {
                    condition = "not okay";
                }

                WindowHandler.controllerObj.UpdateConsoles(roomNumber, condition);
                dataGridView1.Refresh();
                MessageBox.Show("Console Updated Successfuly");

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            WindowHandler.controllerObj.TerminateConnection();
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowHandler.login.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            WindowHandler.controllerObj.TerminateConnection();
            Application.Exit();
        }

        private void PasswordTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void RePasswordTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            try
            {
                if (PasswordTB.Text.ToString() == RePasswordTB.Text.ToString())
                {
                    Program.ctrl.ChangePassword(Program.UserID,2, PasswordTB.Text.ToString());
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
            label8.Hide();
            label7.Hide();
            PasswordTB.Hide();
            RePasswordTB.Hide();
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            label5.Show();
            label8.Show();
            label7.Show();
            PasswordTB.Show();
            RePasswordTB.Show();
        }
    }
}
