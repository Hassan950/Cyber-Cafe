﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class CFeedback : Form
    {
        public CFeedback()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            WindowHandler.cmain.Show();
            this.Hide();
        }

        private void SubBTN_Click(object sender, EventArgs e)
        {
            WindowHandler.csubs.Show();
            this.Hide();
        }

        private void SendFBBTN_Click(object sender, EventArgs e)
        {
            if(FeedTB.Text=="")
                MessageBox.Show("Please, insert a Feedback");
            if(WindowHandler.controllerObj.SendFeedback(FeedTB.Text) !=0)
                MessageBox.Show("Feedback Sent Successfully");
            else
                MessageBox.Show("Feedback Couldn't be Sent");
        }

        private void SendRGBTN_Click(object sender, EventArgs e)
        {
            if(ReqGameTB.Text == "")
                MessageBox.Show("Please, insert a Request");
            if (WindowHandler.controllerObj.SendFeedback(FeedTB.Text) != 0)
                MessageBox.Show("Request Sent Successfully");
            else
                MessageBox.Show("Request Couldn't be Sent");
        }
    }
}
