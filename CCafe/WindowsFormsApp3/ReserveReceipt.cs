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

        private void AddTourn_Click(object sender, EventArgs e)
        {

        }
    }
}
