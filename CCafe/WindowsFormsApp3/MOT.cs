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
    public partial class MOT : Form
    {
        public MOT()
        {
            InitializeComponent();
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

        private void EditCyberBTN_Click(object sender, EventArgs e)
        {
            WindowHandler.mcyper.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TournamentSelect_Click(object sender, EventArgs e)
        {
            DataTable dt = Program.ctrl.ViewAllTournaments();
            DataGrid.DataSource = null;
            DataGrid.Refresh();
            DataGrid.DataSource = dt;
            DataGrid.Refresh();
        }

        private void OfferSelect_Click(object sender, EventArgs e)
        {
            DataTable dt = Program.ctrl.ViewAllOffers();
            DataGrid.DataSource = null;
            DataGrid.Refresh();
            DataGrid.DataSource = dt;
            DataGrid.Refresh();
        }
    }
}
