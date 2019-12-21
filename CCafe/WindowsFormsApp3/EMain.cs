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

            DataTable dt3 = WindowHandler.controllerObj.ViewAvailibleConsoles();
            comboBoxRoomNumber2.DataSource = dt3;
            comboBoxRoomNumber2.DisplayMember = "room_no";
            comboBoxRoomNumber2.ValueMember = "room_no";

            DataTable dt4 = WindowHandler.controllerObj.ViewGames();
            comboBoxGameName.DataSource = dt4;
            comboBoxGameName.DisplayMember = "name";
            comboBoxGameName.ValueMember = "name";

            DataTable dt5 = WindowHandler.controllerObj.ViewCustomerID();
            comboBoxCustomerID.DataSource = dt5;
            comboBoxCustomerID.DisplayMember = "ID";
            comboBoxCustomerID.ValueMember = "ID";


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
            label15.Hide();
            label16.Hide();
            label17.Hide();
            PasswordTB.Hide();
            RePasswordTB.Hide();
            try
            {
                int returnval = Program.ctrl.InsertShiftLog(Program.UserID);
                if (returnval == 1)
                    MessageBox.Show("Shift Inserted");
                else
                {
                    MessageBox.Show("You Have Logged Before Today");
                }
            }
            catch (Exception ex)
            {
            }

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
            if (comboBoxRoomNumber.SelectedValue == null || ((radioButtonWorking.Checked == false && radioButtonNotWorking.Checked == false)))
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

        private void RefreshBTN_Click(object sender, EventArgs e)
        {
            DataTable dt1 = WindowHandler.controllerObj.ViewAvailibleConsoles();
            dataGridView1.DataSource = dt1;
            dataGridView1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowHandler.controllerObj.TerminateConnection();
            Application.Exit();
        }



        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void RefreshBTN_Click_1(object sender, EventArgs e)
        {
            DataTable dt1 = WindowHandler.controllerObj.ViewAvailibleConsoles();
            dataGridView1.DataSource = dt1;
            dataGridView1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            int roomNumber = Convert.ToInt16(comboBoxRoomNumber2.SelectedValue);
            string gameName = comboBoxGameName.SelectedValue.ToString();
            int customerID = Convert.ToInt32(comboBoxCustomerID.SelectedValue);
            string startTime = StartTime.Value.ToString("HH:mm");
            string endTime = EndTime.Value.ToString("HH:mm");

            if (EndTime.Value <= StartTime.Value)
            {
                MessageBox.Show("Start Time should be less than End Time");
                return;
            }

            int success = WindowHandler.controllerObj.MakeReservationEmployee(date, roomNumber, gameName, customerID, startTime, endTime);
            if (success == 1)
            {
                MessageBox.Show("Room Reserved Successfuly");
            }
            else
            {
                MessageBox.Show("Room Reservation Failed");

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label15.Show();
            label16.Show();
            label17.Show();
            PasswordTB.Show();
            RePasswordTB.Show();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            try
            {
                if (PasswordTB.Text.ToString() == RePasswordTB.Text.ToString())
                {
                    Program.ctrl.ChangePassword(Program.UserID, 2, PasswordTB.Text.ToString());
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
            label15.Hide();
            label16.Hide();
            label17.Hide();
            PasswordTB.Hide();
            RePasswordTB.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowHandler.login.Show();
            this.Hide();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            WindowHandler.rreceipt.Show();
        }
    }
}
