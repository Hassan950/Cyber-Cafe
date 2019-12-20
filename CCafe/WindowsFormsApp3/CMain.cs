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
    public partial class CMain : Form
    {
        bool changePass = false;
        Point Loc;
        public CMain()
        {

            InitializeComponent();

            Update();
        }

        public new void Update()
        {
            Console.WriteLine(Program.UserName);
            Loc = UserNameLp.Location;
            DataTable dt = WindowHandler.controllerObj.ViewGames();
            GameCB.DataSource = dt;
            GameCB.DisplayMember = "name";
            GameCB.ValueMember = "name";
            dt = WindowHandler.controllerObj.ViewRooms();
            RoomCB.DataSource = dt;
            RoomCB.DisplayMember = "number";
            RoomCB.ValueMember = "number";
            UserNameLp.Text = Program.UserName;
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
            string st = StartTime.Value.ToString("hh:mm:ss");
            string et = EndTime.Value.ToString("hh:mm:ss");
            WindowHandler.controllerObj.CustomerReserve(Convert.ToInt32(RoomCB.SelectedValue), GameCB.SelectedValue.ToString(), Program.UserID, st, et);
        }

        private void FeedBTN_Click(object sender, EventArgs e)
        {
            WindowHandler.cfeedback.Update();
            WindowHandler.cfeedback.Show();
            this.Hide();
        }

        private void SubBTN_Click(object sender, EventArgs e)
        {
            WindowHandler.csubs.Update();
            WindowHandler.csubs.Show();
            
            this.Hide();
        }

        private void CMain_Load(object sender, EventArgs e)
        {
            label9.Hide();
            label8.Hide();
            label7.Hide();
            PasswordTB.Hide();
            RePasswordTB.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            WindowHandler.controllerObj.TerminateConnection();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowHandler.controllerObj.TerminateConnection();
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            WindowHandler.login.Update();
            WindowHandler.login.Show();
            this.Hide();
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
            label9.Hide();
            label8.Hide();
            label7.Hide();
            PasswordTB.Hide();
            RePasswordTB.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!changePass)
            {
                label9.Show();
                label8.Show();
                label7.Show();
                PasswordTB.Show();
                RePasswordTB.Show();
                changePass = !changePass;

                UserNameLp.Location = new Point(0, 74);
            }
            else
            {
                label9.Hide();
                label8.Hide();
                label7.Hide();
                PasswordTB.Hide();
                RePasswordTB.Hide();
                changePass = !changePass;
                UserNameLp.Location = Loc;
            }
        }
        
    }
}
