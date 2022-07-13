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
    public partial class AddCommet : UserControl
    {
        public User userLogin { get; set; }
        public int idEvent { get; set; }
        ICommentRepository cmtRepo = new CommentRepository();


        public AddCommet()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (frmHomePage.userLogin == null)
            {
                frmLogin frmLogin = new frmLogin();
                frmLogin.ShowDialog();
            }
            else
            {
                BussinessLayer.Models.Comment cmt = new BussinessLayer.Models.Comment
                {
                    IdEvent = idEvent,
                    IdUser = frmHomePage.userLogin.Id,
                    Comment1 = textBox1.Text,
                    Time = DateTime.Now,

                };
                cmtRepo.Comment(cmt);
            }
        }
    }
}
