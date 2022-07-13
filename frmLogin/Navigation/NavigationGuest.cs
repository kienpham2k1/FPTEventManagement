using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accessibility;
using BussinessLayer.Models;
using DataAccess.Repository;

namespace FptEventWinApp
{
    public partial class NavigationGuest : UserControl
    {
        IEventRepository evtRepo = new EventRepository();
        public static User userLogin;
        public NavigationGuest()
        {
            InitializeComponent();
            btnHome.Image = FptEventWinApp.Properties.Resources.home_free_icon_font;
        }
        public void btnGoHomePage_Click(object sender, EventArgs e)
        {
            btnHome.Image = Properties.Resources.home_free_icon_font;
            btnTimeSchedule.Image = Properties.Resources.calendar;
            btnSearch.Image = Properties.Resources.search;
            frmHomePage.loadEvent();
        }

        private void btnOpenTimeSchedule_Click(object sender, EventArgs e)
        {
            btnHome.Image = Properties.Resources.home;
            btnTimeSchedule.Image = Properties.Resources.calendar_free_icon_font;
            btnSearch.Image = Properties.Resources.search;
            frmHomePage.loadCalendar();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            btnSearch.Image = Properties.Resources.search_free_icon_font;
            btnHome.Image = Properties.Resources.home;
            btnTimeSchedule.Image = Properties.Resources.calendar;
            var search = evtRepo.GetEvents(txtSearch.Text);
            frmHomePage.loadEvent(search);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            frmHomePage.ActiveForm.Close();
        }

        private void NavigationGuest_Load(object sender, EventArgs e)
        {
            if (frmHomePage.userLogin == null)
            {
                btnLogin.Click += new System.EventHandler(BtnLogin_Click);
                btnViewNotify.Visible = false;
                textBox1.Visible = false;
            }
            else
            {
                btnLogin.Click += new System.EventHandler(Logout_Click);
                btnViewNotify.Visible = true;
                textBox1.Visible = true;
                textBox1.Text = $"Hello: {userLogin.Name}";
                btnLogin.Image = Properties.Resources.sign_out_alt_free_icon_font;
            }
        }
        private void Logout_Click(object sender, EventArgs e)
        {
            frmHomePage.userLogin = null;
            NavigationGuest navbar = new NavigationGuest();
            NavigationGuest.userLogin = null;
            frmHomePage.pnNavigation.Controls.Add(navbar);
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
        }
    }
}
