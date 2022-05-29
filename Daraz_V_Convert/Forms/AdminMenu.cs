﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daraz_V_Convert.Forms
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdminChangePassword a = new AdminChangePassword();
            a.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AdminGV a = new AdminGV();
            a.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AdminHistory h = new AdminHistory();
            h.ShowDialog();
        }
    }
}
