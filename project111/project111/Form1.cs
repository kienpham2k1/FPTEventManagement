using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project111
{
    public partial class Form1 : Form
    {
        Bitmap user1 = Properties.Resources.user__1_;
        Bitmap user2 = Properties.Resources.audience;
        Bitmap pass1 = Properties.Resources.key;
        Bitmap pass2 = Properties.Resources.password;

        public Form1()
        {
            InitializeComponent();
            pictureBox2.Image = user1;
            pictureBox3.Image = pass1;
        }

        private void txtusername_Click(object sender, EventArgs e)
        {
            txtusername.Clear();
            pictureBox2.Image = user2;
            panel1.BackColor= Color.FromArgb(0, 192, 192);
            txtusername.ForeColor = Color.FromArgb(0, 192, 192);

            pictureBox3.Image = pass1;
            panel2.ForeColor = Color.Black;
            txtpassword.ForeColor= Color.Black;

        }

        private void txtpassword_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = user1;
            panel1.BackColor = Color.Black;
            txtusername.ForeColor = Color.Black;

            txtpassword.Clear();
            txtpassword.PasswordChar = '*';
            pictureBox3.Image = pass2;
            panel2.ForeColor = Color.FromArgb(0, 192, 192); ;
            txtpassword.ForeColor = Color.FromArgb(0, 192, 192); ;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
