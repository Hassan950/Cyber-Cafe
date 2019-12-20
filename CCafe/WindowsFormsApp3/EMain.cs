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

            DataTable dt3 = WindowHandler.controllerObj.ViewRoomNumber();
            comboBoxRoomNumber2.DataSource = dt3;
            comboBoxRoomNumber2.DisplayMember = "number";
            comboBoxRoomNumber2.ValueMember = "number";
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

        private void button3_Click(object sender, EventArgs e)
        {
            WindowHandler.controllerObj.TerminateConnection();
            Application.Exit();
        }

        private void RefreshBTN_Click(object sender, EventArgs e)
        {
            DataTable dt = WindowHandler.controllerObj.ViewAvailibleConsoles();
            dataGridView1.DataSource = dt;
        }
    }
}
