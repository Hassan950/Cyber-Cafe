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
            comboBox4.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox6.SelectedIndex = 0;
            comboBox7.SelectedIndex = 0;

            ConsolesDGV.DataSource = WindowHandler.controllerObj.ViewConsoles();
            GamesDGV.DataSource = WindowHandler.controllerObj.ViewGames();
            RoomsDGV.DataSource = WindowHandler.controllerObj.ViewRoomNumber();
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                RoomBox.Hide();
                RoomCombo.Show();
                RoomCombo.DataSource = WindowHandler.controllerObj.ViewConsoles();
                RoomCombo.DisplayMember = "room_no";
                AddConsoleBTN.Text = "Update";
                InsertGroup.Text = "Update Console";
            }
            else
            {
                RoomBox.Show();
                RoomCombo.Hide();
                AddConsoleBTN.Text = "Add";
                InsertGroup.Text = "Add Console";
            }
        }

        private void ConsolesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddConsoleBTN_Click(object sender, EventArgs e)
        {
            try
            {
                int room_no = (checkBox1.Checked) ? Convert.ToInt32(RoomCombo.Text) : Convert.ToInt32(RoomBox.Text);
                int r = WindowHandler.controllerObj.EditConsoles(room_no, comboBox3.Text, comboBox4.Text);
                if (r <= 0) throw new Exception("Task Failed");
                ConsolesDGV.DataSource = WindowHandler.controllerObj.ViewConsoles();
                MessageBox.Show("Task Done Successfully");
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter Valid Input.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox1.Hide();
                comboBox1.Show();
                comboBox1.DataSource = WindowHandler.controllerObj.ViewGames();
                comboBox1.DisplayMember = "name";
                button3.Text = "Update";
                groupBox1.Text = "Update Games";
            }
            else
            {
                textBox1.Show();
                comboBox1.Hide();
                button3.Text = "Add";
                groupBox1.Text = "Add Games";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string name = (checkBox2.Checked) ? comboBox1.Text : textBox1.Text;
                int r = WindowHandler.controllerObj.EditGames(name, Convert.ToInt32(numericUpDown2.Value));
                if (r <= 0) throw new Exception("Task Failed");
                GamesDGV.DataSource = WindowHandler.controllerObj.ViewGames();
                MessageBox.Show("Task Done Successfully");
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter Valid Input.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                numericUpDown1.Hide();
                comboBox5.Show();
                comboBox5.DataSource = WindowHandler.controllerObj.ViewRoomNumber();
                comboBox5.DisplayMember = "number";
                button4.Text = "Update";
                groupBox2.Text = "Update Rooms";
            }
            else
            {
                numericUpDown1.Show();
                comboBox5.Hide();
                button4.Text = "Add";
                groupBox2.Text = "Add Rooms";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int number = (checkBox3.Checked) ? Convert.ToInt32(comboBox5.Text) : Convert.ToInt32(numericUpDown1.Value);
                bool available = (comboBox7.Text == "Yes");
                int r = WindowHandler.controllerObj.EditRooms(number, comboBox6.Text, available);
                if (r <= 0) throw new Exception("Task Failed");
                RoomsDGV.DataSource = WindowHandler.controllerObj.ViewRooms();
                MessageBox.Show("Task Done Successfully");
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter Valid Input.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
