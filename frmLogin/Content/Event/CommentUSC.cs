using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLayer.Models;
using DataAccess.Repository;

namespace FptEventWinApp
{
    public partial class CommentUSC : UserControl
    {
        IUserRepository userRepo = new UserRepository();
        ICommentRepository cmtRepo = new CommentRepository();
        public User userLogin { get; set; }
        public BussinessLayer.Models.Comment cmt { get; set; }
        public CommentUSC()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (
           MessageBox.Show("Do you realy want to delete this?", "Delete Comment",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cmtRepo.DeleteComment(cmt.Id);
            }
        }
        private void Comment_Load(object sender, EventArgs e)
        {
            if (frmHomePage.userLogin != null)
            {
                if (frmHomePage.userLogin.Id == cmt.IdUser)
                {
                    button1.Visible = true;
                }
            }
            label1.Text = userRepo.GetUser(cmt.IdUser).Name;
            label2.Text = cmt.Comment1;
            this.Size = new Size(this.Width, label2.Height + 30);
        }
    }
}
