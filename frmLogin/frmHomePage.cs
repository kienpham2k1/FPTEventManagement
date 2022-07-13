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
using BussinessLayer.Models;
using DataAccess.Repository;

//namespace frmHomePage
//{
public partial class frmHomePage : Form
{
    static public User userLogin;
    public frmHomePage()
    {
        InitializeComponent();
        addNavBar();
        loadEvent();
    }
    public static void addNavBar()
    {
        pnNavigation.Controls.Add(new NavigationGuest());
        NavigationGuest.userLogin = userLogin;
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
    public static void loadEvent(IEnumerable<Event> events = null, int? back = null)
    {
        if (events != null)
        {
            if (back != null)
            {
                openContainer(new EventContainer
                {
                    events = events,
                    back = back.Value,
                });

            }
            else
            {
                openContainer(new EventContainer
                {
                    events = events,
                    back = 1,
                });
            }
        }
        else
        {
            openContainer(new EventContainer());
        }
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
