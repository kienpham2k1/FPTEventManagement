using BussinessLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Repository;
using System.Text.RegularExpressions;

namespace FptEventWinApp
{
    public partial class loginPanel : UserControl
    {
        Bitmap user1 = Properties.Resources.user__1_;
        Bitmap user2 = Properties.Resources.audience;
        Bitmap pass1 = Properties.Resources.password__1_;
        Bitmap pass2 = Properties.Resources.password;
        IUserRepository userRepository = new UserRepository();
        public loginPanel()
        {
            InitializeComponent();
            pictureBox2.Image = user1;
            pictureBox3.Image = pass1;
        }

       public bool getCheck()
        {
            if (String.IsNullOrEmpty(txtemail.Text))
            {
                MessageBox.Show("Email is empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtemail.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtpassword.Text))
            {
                MessageBox.Show("Password is empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpassword.Focus();
                return false;
            }
            return true;
        }

       

        private void txtusername_Click_1(object sender, EventArgs e)
        {
            txtemail.Clear();
            pictureBox2.Image = user2;
            panel1.BackColor = Color.FromArgb(0, 192, 192);
            txtemail.ForeColor = Color.FromArgb(0, 192, 192);

            pictureBox3.Image = pass1;
            panel2.ForeColor = Color.Black;
            txtpassword.ForeColor = Color.Black;
        }

        private void txtpassword_Click_1(object sender, EventArgs e)
        {
            pictureBox2.Image = user1;
            panel1.BackColor = Color.Black;
            txtemail.ForeColor = Color.Black;

            txtpassword.Clear();
            txtpassword.PasswordChar = '*';
            pictureBox3.Image = pass2;
            panel2.ForeColor = Color.FromArgb(0, 192, 192); ;
            txtpassword.ForeColor = Color.FromArgb(0, 192, 192); ;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (getCheck())
            {
                string email = txtemail.Text;
                string password = txtpassword.Text;

                User user = userRepository.CheckLogin(email, password);
                if (user == null)
                {
                    MessageBox.Show("Invalid email or password");
                }
                else
                {
                    if (user.RoleId == 1)
                    {
                        MessageBox.Show("this is admin");
                    }
                    else
                    {
                        MessageBox.Show("Im user");
                    }
                }
            }
        }

        private void txtemail_Leave(object sender, EventArgs e)
        {
            string parttern = "^[a-z][a-z0-9_\\.]{5,32}@fpt.edu.vn$";
            if(Regex.IsMatch(txtemail.Text, parttern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.txtemail, "email not valid");
            }
        }
    }
}
