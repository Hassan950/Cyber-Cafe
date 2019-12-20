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
        Boolean TournorOffer = false;
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
            TournorOffer = false;
            label1.Text = "New Tournament";
            label3.Text = "Edit Tournament";
            label10.Text = "Status";
            label6.Text = "Particpants";
            label11.Hide();
            dateTimePicker1.Hide();


        }

        private void OfferSelect_Click(object sender, EventArgs e)
        {
            DataTable dt = Program.ctrl.ViewAllOffers();
            DataGrid.DataSource = null;
            DataGrid.Refresh();
            DataGrid.DataSource = dt;
            DataGrid.Refresh();
            TournorOffer = true;
            label1.Text = "New Offer";
            label3.Text = "Edit Offer";
            label10.Text = "Type";
            label6.Text = "Discount";
            label11.Show();
            dateTimePicker1.Show();
            TournNameCB.DataSource = Program.ctrl.ViewAllOffers();
            TournNameCB.DisplayMember = "name";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MOT_Load(object sender, EventArgs e)
        {
            DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            IDLabel.Text = Program.UserID.ToString();
            TournNameCB.DataSource = Program.ctrl.ViewAllTournaments();
            TournNameCB.DisplayMember = "name";
            TournorOffer = false;
            label1.Text = "New Tournament";
            label3.Text = "Edit Tournament";
            label3.Text = "Status";
            label6.Text = "Particpants";
            label11.Hide();
            dateTimePicker1.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AddTourn_Click(object sender, EventArgs e)
        {
            if (!TournorOffer)
            {
                try
                {
                    Program.ctrl.AddTournaments(TournNameTB.Text.ToString(), StartDatePicker.Value.ToShortDateString(), StatusNewTB.Text.ToString(), Convert.ToInt32(ParticNumNew.Value));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                DataTable dt = Program.ctrl.ViewAllTournaments(); //view after insertion
                DataGrid.DataSource = null;
                DataGrid.Refresh();
                DataGrid.DataSource = dt;
                DataGrid.Refresh();

                TournNameCB.DataSource = Program.ctrl.ViewAllTournaments();
                TournNameCB.DisplayMember = "name";
            }
            else
            {
                   try
                {
                    Program.ctrl.AddOffers(TournNameTB.Text.ToString(), StatusNewTB.Text.ToString(), Convert.ToInt32(ParticNumNew.Value), StartDatePicker.Value.ToShortDateString(), dateTimePicker1.Value.ToShortDateString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                DataTable dt = Program.ctrl.ViewAllOffers(); //view after insertion
                DataGrid.DataSource = null;
                DataGrid.Refresh();
                DataGrid.DataSource = dt;
                DataGrid.Refresh();
            }
            
        }

        private void label11_Click(object sender, EventArgs e)
        {
            if (!TournorOffer)
            {
                try
                {
                    Program.ctrl.AddTournaments(TournNameCB.Text.ToString(), StartDatePicker.Value.ToShortDateString(), StatusNewTB.Text.ToString(), Convert.ToInt32(ParticNumNew.Value));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                DataTable dt = Program.ctrl.ViewAllTournaments(); //view after insertion
                DataGrid.DataSource = null;
                DataGrid.Refresh();
                DataGrid.DataSource = dt;
                DataGrid.Refresh();
            }
            else
            {
                try
                {
                    Program.ctrl.AddOffers(TournNameCB.Text.ToString(), StatusNewTB.Text.ToString(), Convert.ToInt32(ParticNumNew.Value), StartDatePicker.Value.ToShortDateString(), dateTimePicker1.Value.ToShortDateString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                DataTable dt = Program.ctrl.ViewAllOffers(); //view after insertion
                DataGrid.DataSource = null;
                DataGrid.Refresh();
                DataGrid.DataSource = dt;
                DataGrid.Refresh();
            }
        }

        private void StartDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
