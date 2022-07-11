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
        public EventContainer()
        {
            InitializeComponent();
        }
        private void ListEvent_Load(object sender, EventArgs e)
        {
            if (events == null)
            {
                DateTime? time = DateTime.Now;
                events = eventRepo.GetEvents(time).ToList();
            }
            foreach (Event evt in events)
            {
                EventReview eventReview = new EventReview
                {
                    @event = evt,
                };
         
                eventReview.Dock = DockStyle.Top;
                eventReview.SendToBack();
                flpContent.Controls.Add(eventReview);
                int left = (flpContent.Width - eventReview.Width) / 2 - 15;
                eventReview.Margin = new Padding(left, left, left, 0);
            }
        }
    }
}
