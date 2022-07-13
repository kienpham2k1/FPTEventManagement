using BussinessLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Repository;

namespace FptEventWinApp
{
    public partial class RegistorForm : UserControl
    {
        IUserRepository userRepository = new UserRepository();
        Bitmap user1 = Properties.Resources.user__1_;
        Bitmap user2 = Properties.Resources.audience;
        Bitmap pass1 = Properties.Resources.password__1_;
        Bitmap pass2 = Properties.Resources.password;
        Bitmap email1 = Properties.Resources.mail;
        Bitmap email2 = Properties.Resources.gmail;
        Bitmap cpass1 = Properties.Resources.login__1_;
        Bitmap cpass2 = Properties.Resources.padlock;
        Bitmap phone1 = Properties.Resources.phone_call;
        Bitmap phone2 = Properties.Resources.telephone;
        public RegistorForm()
        {
            InitializeComponent();
            p1.Image = user1;
            p2.Image = pass1;
            p3.Image = email1;
            p4.Image = cpass1;
            p5.Image = phone1;
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

            p5.Image = phone1;
            panel5.ForeColor = Color.Black;
            txtphone.ForeColor = Color.Black;
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

            p5.Image = phone1;
            panel5.ForeColor = Color.Black;
            txtphone.ForeColor = Color.Black;

        }

        private void txtpassword_Click(object sender, EventArgs e)
        {
            txtpassword.Clear();
            txtpassword.PasswordChar = '*';
            p3.Image = pass2;
            panel3.BackColor = Color.FromArgb(0, 192, 192);
            txtpassword.ForeColor = Color.FromArgb(0, 192, 192); ;

            p1.Image = user1;
            panel1.BackColor = Color.Black;
            txtusername.ForeColor = Color.Black;

            p2.Image = email1;
            panel2.ForeColor = Color.Black;
            txtemail.ForeColor = Color.Black;

            p4.Image = cpass1;
            panel4.ForeColor = Color.Black;
            txtconfirmpass.ForeColor = Color.Black;

            p5.Image = phone1;
            panel5.ForeColor = Color.Black;
            txtphone.ForeColor = Color.Black;
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
            txtconfirmpass.PasswordChar = '*';
            p4.Image = cpass2;
            panel4.BackColor = Color.FromArgb(0, 192, 192);
            txtconfirmpass.ForeColor = Color.FromArgb(0, 192, 192);

            p5.Image = phone1;
            panel5.ForeColor = Color.Black;
            txtphone.ForeColor = Color.Black;
        }

        private void txtphone_Click(object sender, EventArgs e)
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

            p4.Image = cpass1;
            panel4.ForeColor = Color.Black;
            txtconfirmpass.ForeColor = Color.Black;

            txtphone.Clear();
            p5.Image = phone2;
            panel4.BackColor = Color.FromArgb(0, 192, 192);
            txtphone.ForeColor = Color.FromArgb(0, 192, 192);
        }
        public bool getCheck()
        {
            if (String.IsNullOrEmpty(txtusername.Text))
            {
                MessageBox.Show("Name is empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtusername.Focus();
                return false;
            }
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
            if (String.IsNullOrEmpty(txtconfirmpass.Text))
            {
                MessageBox.Show("Confirm password is empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtconfirmpass.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtphone.Text))
            {
                MessageBox.Show("Confirm password is empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtconfirmpass.Focus();
                return false;
            }
            if (!txtpassword.Text.ToString().Equals(txtconfirmpass.Text.ToString()))
            {
                MessageBox.Show("Confirm password is not same password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtconfirmpass.Focus();
                return false;
            }
            if (!Regex.IsMatch(txtemail.Text, "^[a-z][a-z0-9_\\.]{5,32}@fpt.edu.vn$"))
            {
                MessageBox.Show("Email not correct form must ...@fpt.edu.vn", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtemail.Focus();
                return false;
            }
            

            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            
            if (getCheck())
            {
                bool check = false;

                
                try
                {
                    if (male.Checked == true)
                    {
                        check = true;
                    }
                    //int id = userRepository.getID();
                    var user = new User
                    {
                        //Id = id,
                        Name = txtusername.Text.ToString(),
                        Email = txtemail.Text.ToString(),
                        Password = txtpassword.Text.ToString(),
                        Phone = txtphone.Text.ToString(),
                        Gender = check,
                                        RoleId = 1,
                    };
                    userRepository.SaveUser(user);
                    //MessageBox.Show(id.ToString());
                    MessageBox.Show("Successfully ");
                }catch (Exception ex)
                {
                    MessageBox.Show("Fail");
                }
            }
        }

        private void txtemail_Leave(object sender, EventArgs e)
        {
            string parttern = "^[a-z][a-z0-9_\\.]{5,32}@fpt.edu.vn$";
            if (Regex.IsMatch(txtemail.Text, parttern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.txtemail, "Email not correct form must ...@fpt.edu.vn");
            }
        }
    }
}
