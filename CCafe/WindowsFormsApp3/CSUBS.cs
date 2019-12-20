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
    public partial class CSUBS : Form
    {
        public CSUBS()
        {
            InitializeComponent();
            Update();
            
        }
        public new void Update()
        {
            UserNameLp.Text = Program.UserName;
            TDGV.DataSource = WindowHandler.controllerObj.ViewTournaments();
            ODGV.DataSource = WindowHandler.controllerObj.ViewOffers();
        }
        private void HomeBtn_Click(object sender, EventArgs e)
        {
            WindowHandler.cmain.Update();
            WindowHandler.cmain.Show();
            
            this.Hide();
        }

        private void FeedBTN_Click(object sender, EventArgs e)
        {
            WindowHandler.cfeedback.Update();
            WindowHandler.cfeedback.Show();
           
            this.Hide();
        }

        private void AcceptBTN_Click(object sender, EventArgs e)
        {
            if (ODGV.SelectedRows.Count > 0)
            {
                if (WindowHandler.controllerObj.AcceptOffer(ODGV.SelectedRows[0].Cells[0].Value.ToString()) !=0) 
                    MessageBox.Show("Offer Accepted");
                else
                    MessageBox.Show("Offer Already Accepted");
            }
            else
                MessageBox.Show("Please, Select an Offer");


        }
        private void EnrollBTN_Click(object sender, EventArgs e)
        {
       

            if(TDGV.SelectedRows.Count > 0)
            { 
                if (WindowHandler.controllerObj.TournamentEnroll(TDGV.SelectedRows[0].Cells[0].Value.ToString()) != 0)
                    MessageBox.Show("Enrolled Succesfully");
                else
                    MessageBox.Show("Already Enrolled");
            }
            else
                MessageBox.Show("Please, Select a Tournament");


        }
        private void Exit_Click(object sender, EventArgs e)
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
    }
}
