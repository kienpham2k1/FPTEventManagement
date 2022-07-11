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
        public User userLogin { get; set; }
        public BussinessLayer.Models.Comment cmt { get; set; }
        public CommentUSC()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Button del = new Button();
            del.Text = "Delete";
            del.Click += new EventHandler(this.Delete_Click);
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            if (
            MessageBox.Show("Do you realy want to delete this?", "Delete Comment",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

            }
        }
        private void Comment_Load(object sender, EventArgs e)
        {
            label1.Text = userRepo.GetUser(cmt.IdUser).Name;
            label2.Text = cmt.Comment1;
        }
    }
}
