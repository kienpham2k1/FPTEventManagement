﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project222
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //userControl11.BringToFront();
            //userControlLogin1.Hide();
            registorControl1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //userControlLogin1.BringToFront();
            //userControl11.Hide();
            controlLogin1.BringToFront();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            controlLogin1.BringToFront();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            controlLogin1.BringToFront();
        }
    }
}
