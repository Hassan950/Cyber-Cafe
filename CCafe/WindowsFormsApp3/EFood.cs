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
            Update();
        }
        public new void Update()
        {
            DataTable dt = WindowHandler.controllerObj.ViewFoodAndDrinks();
            dataGridView1.DataSource = dt;

            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "name";

            DataTable dt2 = WindowHandler.controllerObj.ViewFoodAndDrinks();
            dataGridView1.DataSource = dt2;

            comboBox2.DataSource = dt2;
            comboBox2.DisplayMember = "name";
            comboBox2.ValueMember = "name";

            numericUpDown1.Maximum = int.MaxValue;
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
            WindowHandler.egames.Update();
            WindowHandler.egames.Show();
            this.Hide();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            WindowHandler.emain.Update();
            WindowHandler.emain.Show();
            this.Hide();
        }

        private void RefreshBTN_Click(object sender, EventArgs e)
        {
            DataTable dt = WindowHandler.controllerObj.ViewFoodAndDrinks();
            dataGridView1.DataSource = dt;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            WindowHandler.controllerObj.TerminateConnection();
            Application.Exit();
        }

        private void UpdateBTN_Click(object sender, EventArgs e)
        {

            string name = comboBox1.SelectedValue.ToString();
            int value = Convert.ToInt16( numericUpDown1.Value );

            if(comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Please Select All Fields To Update");
                return;
            }

            WindowHandler.controllerObj.ModifyFoodStock(name, value);
            MessageBox.Show("Updated Successfuly");
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
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = comboBox2.SelectedValue.ToString();
            int value = Convert.ToInt16(numericUpDown2.Value);

            if (comboBox2.SelectedValue == null)
            {
                MessageBox.Show("Please Select All Fields To Update");
                return;
            }

            WindowHandler.controllerObj.PlaceFoodOrder(name, value);
            MessageBox.Show("Ordered Placed Successfuly");
        }
    }
}
