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

namespace FptEventWinApp
{
    public partial class NavigationGuest : UserControl
    {
        public NavigationGuest()
        {
            InitializeComponent();
            btnHome.Image = FptEventWinApp.Properties.Resources.home_free_icon_font;
        }
        public void btnGoHomePage_Click(object sender, EventArgs e)
        {
            btnHome.Image = FptEventWinApp.Properties.Resources.home_free_icon_font;
            btnTimeSchedule.Image = FptEventWinApp.Properties.Resources.calendar;
            btnSearch.Image = FptEventWinApp.Properties.Resources.search;
            frmHomePage.loadEvent();
        }

        private void btnOpenTimeSchedule_Click(object sender, EventArgs e)
        {
            btnHome.Image = FptEventWinApp.Properties.Resources.home;
            btnTimeSchedule.Image = FptEventWinApp.Properties.Resources.calendar_free_icon_font;
            btnSearch.Image = FptEventWinApp.Properties.Resources.search;
            frmHomePage.loadCalendar();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            btnSearch.Image = FptEventWinApp.Properties.Resources.search_free_icon_font;
            btnHome.Image = FptEventWinApp.Properties.Resources.home;
            btnTimeSchedule.Image = FptEventWinApp.Properties.Resources.calendar;
            //frmHomePage.openSearchBox();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            frmHomePage.ActiveForm.Close();
        }
    }
}
