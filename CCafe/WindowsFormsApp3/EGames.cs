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
    public partial class EGames : Form
    {
        public EGames()
        {
            InitializeComponent();
            Update();

        }
        public new void Update()
        {

            UserNameLp.Text = Program.UserName;
            DataTable dt = WindowHandler.controllerObj.ViewGameDetails();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "name";

            numericUpDown1.Maximum = int.MaxValue;
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


        private void CMain_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void FoodBTN_Click(object sender, EventArgs e)
        {
            WindowHandler.efood.Update();
            WindowHandler.efood.Show();
            this.Hide();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            WindowHandler.emain.Update();
            WindowHandler.emain.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RefreshBTN_Click(object sender, EventArgs e)
        {
            DataTable dt = WindowHandler.controllerObj.ViewGameDetails();
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
            int number = Convert.ToInt16( numericUpDown1.Value );

            if (comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Please Select All Fields To Update");
                return;
            }

            WindowHandler.controllerObj.ModifyGameStock(name, number);
            MessageBox.Show("Updated Successfuly");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowHandler.login.Update();
            WindowHandler.login.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            WindowHandler.controllerObj.TerminateConnection();
            Application.Exit();
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
