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
    public partial class SellerMenu : Form
    {
        public SellerMenu()
        {
            InitializeComponent();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SellerChangePassword s = new SellerChangePassword();
            s.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SellerGV g = new SellerGV();
            this.Hide();
            g.Show();
        }
    }
}
