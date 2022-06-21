using System;
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
    public partial class RegistorControl : UserControl
    {
        Bitmap user1 = Properties.Resources.user__1_;
        Bitmap user2 = Properties.Resources.audience;
        Bitmap pass1 = Properties.Resources.password__1_;
        Bitmap pass2 = Properties.Resources.password;
        Bitmap email1 = Properties.Resources.mail;
        Bitmap email2 = Properties.Resources.gmail;
        Bitmap cpass1 = Properties.Resources.login__1_;
        Bitmap cpass2 = Properties.Resources.padlock;
       

        public RegistorControl()
        {
            InitializeComponent();
            p1.Image = user1;
            p2.Image = email1;
            p3.Image = pass1;
            p4.Image = cpass1;
        }

        private void txtusername_Click(object sender, EventArgs e)
        {
            txtusername.Clear();
            p1.Image = user2;
            panel1.BackColor = Color.FromArgb(0, 192, 192);
            txtusername.ForeColor = Color.FromArgb(0, 192, 192);

            p2.Image = email1;
            panel2.ForeColor = Color.Black;
            txtemail.ForeColor = Color.Black;

            p3.Image = pass1;
            panel3.ForeColor = Color.Black;
            txtpassword.ForeColor = Color.Black;

            p4.Image = cpass1;
            panel4.ForeColor = Color.Black;
            txtconfirmpass.ForeColor = Color.Black;
        }

        private void txtpassword_Click(object sender, EventArgs e)
        {
            p1.Image = user1;
            panel1.BackColor = Color.Black;
            txtusername.ForeColor = Color.Black;

            p2.Image = email1;
            panel2.ForeColor = Color.Black;
            txtemail.ForeColor = Color.Black;

            p4.Image = cpass1;
            panel4.ForeColor = Color.Black;
            txtconfirmpass.ForeColor = Color.Black;


            txtpassword.Clear();
            txtpassword.PasswordChar = '*';
            p3.Image = pass2;
            panel3.BackColor = Color.FromArgb(0, 192, 192);
            txtpassword.ForeColor = Color.FromArgb(0, 192, 192); ;
        }

        private void txtemail_Click(object sender, EventArgs e)
        {
            txtemail.Clear();
            p2.Image = email2;
            panel2.BackColor = Color.FromArgb(0, 192, 192);
            txtemail.ForeColor = Color.FromArgb(0, 192, 192);

            p3.Image = pass1;
            panel3.ForeColor = Color.Black;
            txtpassword.ForeColor = Color.Black;

            p4.Image = cpass1;
            panel4.ForeColor = Color.Black;
            txtconfirmpass.ForeColor = Color.Black;

            p1.Image = user1;
            panel1.ForeColor = Color.Black;
            txtusername.ForeColor = Color.Black;
        }

        private void txtconfirmpass_Click(object sender, EventArgs e)
        {
            p1.Image = user1;
            panel1.BackColor = Color.Black;
            txtusername.ForeColor = Color.Black;

            p2.Image = email1;
            panel2.ForeColor = Color.Black;
            txtemail.ForeColor = Color.Black;

            p3.Image = pass1;
            panel3.ForeColor = Color.Black;
            txtpassword.ForeColor = Color.Black;

            txtconfirmpass.Clear();
            p4.Image = cpass2;
            panel4.BackColor = Color.FromArgb(0, 192, 192);
            txtconfirmpass.ForeColor = Color.FromArgb(0, 192, 192);
        }
    }
}
