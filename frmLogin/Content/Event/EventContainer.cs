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
using BussinessLayer.Models;
namespace FptEventWinApp
{
    public partial class EventContainer : UserControl
    {
        IEventRepository eventRepo = new EventRepository();
        IImageRepository imageRepo = new ImageRepository();
        IUserRepository userRepo = new UserRepository();
        public IEnumerable<Event> events { get; set; }
        public User userLogin { get; set; }
        public int back { get; set; }
        Logintest frmLogin;
        public EventContainer()
        {
            InitializeComponent();
        }
        private void ListEvent_Load(object sender, EventArgs e)
        {
            if (userLogin == null || userLogin.RoleId != 1)
            {
                btnAddNewEvent.Visible = false;
            }
            LoadEvent(events);
        }
        private void LoadEvent(IEnumerable<Event> search = null)
        {
            if (search == null)
            {
                DateTime? time = DateTime.Now;
                search = eventRepo.GetEvents(time).ToList();
            }
            else
            {
                flpContent.Controls.Clear();
            }
            foreach (Event evt in search)
            {
                EventReview eventReview = new EventReview
                {
                    @event = evt,
                    back = this.back,
                };

                eventReview.Dock = DockStyle.Top;
                eventReview.SendToBack();
                flpContent.Controls.Add(eventReview);
                int left = (flpContent.Width - eventReview.Width) / 2 - 15;
                eventReview.Margin = new Padding(left, left, left, 0);


            }
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

            if (userLogin == null)
            {
                frmLogin = new Logintest();
                frmLogin.Show();
            }
            else
            {
                IEnumerable<Event> search = null;
                search = eventRepo.GetEvents(userLogin.Id);
                if (search != null)
                    LoadEvent(search);
            }
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (userLogin == null)
            {
                frmLogin = new Logintest();
                frmLogin.Show();
            }
            else
            {
                IEnumerable<Event> search = null;
                search = eventRepo.GetEventsUserCreate(1);
                if (search != null)
                    LoadEvent(search);
            }
        }
    }
}
