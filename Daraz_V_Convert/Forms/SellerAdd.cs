﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Daraz_V_Convert.DL;
using Daraz_V_Convert.BL;

namespace Daraz_V_Convert.Forms
{
    public partial class SellerAdd : Form
    {

        public SellerAdd()
        {
            InitializeComponent();
        }

        private void SellerAdd_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Seller s = new Seller(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            SellerDL.add_list(s);
            AdminDL.Admin.add_history("You added "+textBox1.Text+" to "+textBox3.Text+" Buisness list.");
            //store to file
            //save file
            this.Hide();
        }
    }
}
