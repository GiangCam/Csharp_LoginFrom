﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_LoginFrom
{
    public partial class Frmlogin : Form
    {
        public Frmlogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btndn_Click(object sender, EventArgs e)
        {
            if (txtten.Text == "GiangCam" && txtmk.Text == "tn") 
            {
                
                FrmmMan frmmMan = new FrmmMan();
                this.Hide();
                frmmMan.ShowDialog();
                this.Close();
            } 
            else
            {
                MessageBox.Show("Tên hoặc Mật Khẩu sai vui nhập lại", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
