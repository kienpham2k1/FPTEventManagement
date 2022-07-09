using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FptEventWinApp;

//namespace frmHomePage
//{
    public partial class frmHomePage : Form
    {
        //static Panel pnNavigation = this.ac
        public frmHomePage()
        {
            InitializeComponent();
        addNavBar();
        //btnExit.Hide();
        loadEvent();
    }
        public static void addNavBar()
    {
        pnNavigation.Controls.Add(new NavigationGuest());
    }
    private static UserControl activeForm = null;
    public static void openContainer(UserControl container)
    {
        addNavBar();
        if (activeForm != null)
            pnContent.Controls.Clear();
        activeForm = container;
        container.Dock = DockStyle.Fill;
        pnContent.Controls.Add(container);
        pnContent.Tag = container;
        container.BringToFront();
        container.Show();
    }

    //Load List of all event
        public static void loadEvent()
    {
        openContainer(new EventContainer());
    }
    public static void loadCalendar()
    {
        openContainer(new TimeScheduleContainer());
    }
    private void btnExit_Click(object sender, EventArgs e)
        {
            Close();

        }
}
//}
