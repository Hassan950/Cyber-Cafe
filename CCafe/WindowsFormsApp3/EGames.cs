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
    public partial class EGames : Form
    {
        public EGames()
        {
            InitializeComponent();
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
            WindowHandler.efood.Show();
            this.Hide();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            WindowHandler.emain.Show();
            this.Hide();
        }
    }
}