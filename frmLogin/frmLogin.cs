using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FptEventWinApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            registorForm1.BringToFront();
            pictureBox2.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loginPanel1.BringToFront();
            pictureBox2.BringToFront();
        }

        private void Logintest_Load(object sender, EventArgs e)
        {
            loginPanel1.BringToFront();
            pictureBox2.BringToFront();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
