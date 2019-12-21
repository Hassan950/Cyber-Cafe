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
    public partial class ReserveReceipt : Form
    {
        private Reciept reciept;
        public ReserveReceipt()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            DataTable dt = Program.ctrl.ViewReservation(StartDatePicker.Value.ToShortDateString());
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void Print_click(object sender, EventArgs e)
        {
            try
            {
                Receipt_details r = new Receipt_details();
                DataGridViewRow dt = dataGridView1.SelectedRows[0];

                r.employeeid = dt.Cells[0].Value.ToString();
                r.date = DateTime.Now.ToShortDateString();
                r.room_no = dt.Cells[2].Value.ToString();
                r.gamename = dt.Cells[3].Value.ToString();
                r.customerid = dt.Cells[4].Value.ToString();
                r.starttime = dt.Cells[5].Value.ToString();
                r.endtime = dt.Cells[6].Value.ToString();

                r.MoneyPerHour = "15";
                r.Tax = "0.14";
                r.TimeSpent =( (Convert.ToDateTime(dt.Cells[6].Value.ToString()).Subtract(Convert.ToDateTime(dt.Cells[5].Value.ToString() ))).TotalMinutes/60.0).ToString();
                r.Discount = "0";
                r.TotalMoney = ((Convert.ToInt32(r.TimeSpent) * Convert.ToInt32(r.MoneyPerHour)) * (1.14) - Convert.ToInt32(r.Discount)).ToString();

                reciept = new Reciept(r);
                reciept.Show();
            }
            catch (Exception ex)
            { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
