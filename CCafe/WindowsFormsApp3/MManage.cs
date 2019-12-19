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
    public partial class MManage : Form
    {
        public MManage()
        {
            InitializeComponent();
            TypeBox.SelectedIndex = 0;
            StartTime.Value = StartTime.Value.AddMilliseconds(-StartTime.Value.Millisecond);
            StartTime.Value = StartTime.Value.AddSeconds(-StartTime.Value.Second);
            EndTime.Value = StartTime.Value;
            
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

        private void FoodBTN_Click(object sender, EventArgs e)
        {
            WindowHandler.mfood.Show();
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

        private void TypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = WindowHandler.controllerObj.ViewAccounts(TypeBox.SelectedIndex + 1);
            dataGridView1.DataSource = dt;
            if (TypeBox.Text == "Customers")
            {
                InsertGroup.Hide();
                panel3.Hide();
                dataGridView1.Width = Convert.ToInt32(WindowHandler.cmain.Width * 0.63);
            }
            else
            {
                InsertGroup.Show();
                dataGridView1.Width = Convert.ToInt32(WindowHandler.cmain.Width * 0.37);
                InsertGroup.Text = "Insert " + TypeBox.Text;
                InsertGroup.Text = InsertGroup.Text.Remove(InsertGroup.Text.Length - 1);
                if (TypeBox.Text == "Managers")
                {
                    panel3.Hide();
                }
                else
                {
                    panel3.Show();
                }
                
            }
        }

        private void AddDrinksBTN_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(IDBox.Text);
                if (IDBox.Text.Length != 5) throw new Exception("ID Must be a Between 10000 and 99999");
                string password = PasswordBox.Text;
                if(password.Length < 6) throw new Exception("Password Length Must be at Least 6");
                if (TypeBox.Text == "Employees")
                {
                    string name = NameBox.Text;
                    if (name.Length <= 0) throw new FormatException();
                    int salary = Convert.ToInt32(SalaryBox.Value);
                    if (EndTime.Value <= StartTime.Value) throw new Exception("Start Time should be less that End Time");
                    int r = WindowHandler.controllerObj.CreateUser(ID, password, 2);
                    if (r <= 0) throw new Exception("Registration Failed.\nChange ID and Try Again");
                    WindowHandler.controllerObj.InsertEmployee(ID, name, salary, StartTime.Value.ToString("HH:mm"), EndTime.Value.ToString("HH:mm"));
                }
                else
                {
                    int r = WindowHandler.controllerObj.CreateUser(ID, password, 1);
                    if (r <= 0) throw new Exception("Registration Failed.\nChange ID and Try Again");
                }
                DataTable dt = WindowHandler.controllerObj.ViewAccounts(TypeBox.SelectedIndex + 1);
                dataGridView1.DataSource = dt;
                MessageBox.Show("Reistration Done Successfully");
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
    }
}
