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
    public partial class MFood : Form
    {
        public MFood()
        {
            InitializeComponent();
            TypeBox.SelectedIndex = 0;
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

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HomeBTN_Click(object sender, EventArgs e)
        {
            WindowHandler.mmain.Show();
            this.Hide();
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

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DataTable dt = WindowHandler.controllerObj.ViewSupply(TypeBox.Text);
            dataGridView1.DataSource = dt;
            if (TypeBox.Text == "ALL")
            {
                InsertGroup.Hide();
                dataGridView1.Width = Convert.ToInt32(WindowHandler.cmain.Width * 0.63);
            }
            else
            {
                InsertGroup.Show();
                dataGridView1.Width = Convert.ToInt32(WindowHandler.cmain.Width * 0.37);
                InsertGroup.Text = "Insert " + TypeBox.Text;
                NameCombo.DataSource = dt;
                NameCombo.DisplayMember = "name";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                InsertGroup.Text = "Update " + TypeBox.Text;
                NameBox.Hide();
                NameCombo.Show();
                checkBox2.Show();
                StockBox.Minimum = 0;
                StockBox.Text = "0";
            }
            else
            {
                InsertGroup.Text = "Insert " + TypeBox.Text;
                NameBox.Show();
                NameCombo.Hide();
                checkBox2.Checked = false;
                checkBox2.Hide();
                StockBox.Minimum = 1;
            }
        }

        private void NameCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddDrinksBTN_Click(object sender, EventArgs e)
        {
            try
            {
                string name = (checkBox1.Checked == true) ? NameCombo.Text : NameBox.Text;
                if(name == "") throw new FormatException();
                int price = (checkBox2.Checked == true) ? -1 : Convert.ToInt32(PriceBox.Value);
                int r = WindowHandler.controllerObj.BuySupplies(name, TypeBox.Text, price, Convert.ToInt32(StockBox.Value));
                if (r <= 0) throw new Exception("Task Failed");

                DataTable dt = WindowHandler.controllerObj.ViewSupply(TypeBox.Text);
                dataGridView1.DataSource = dt;
                MessageBox.Show("Done Successfuly");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid input");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            PriceBox.Enabled = !checkBox2.Checked;
        }
    }
}
