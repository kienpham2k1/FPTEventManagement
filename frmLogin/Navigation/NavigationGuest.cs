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

namespace FptEventWinApp
{
    public partial class NavigationGuest : UserControl
    {
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
            // frmHomePage.openSearchBox();
            if (frmHomePage.userLogin == null) txtSearch.Text = "Chua login";
            else
                txtSearch.Text = frmHomePage.userLogin.Name.ToString();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            frmHomePage.ActiveForm.Close();
        }

        private void NavigationGuest_Load(object sender, EventArgs e)
        {
            //userLogin = _user;
            if (userLogin == null) txtSearch.Text = "Chua login";
            else
                txtSearch.Text = userLogin.Id.ToString();
        }
    }
}
