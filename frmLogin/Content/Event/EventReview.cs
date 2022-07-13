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
    public partial class EventReview : UserControl
    {
        IImageRepository imageRepo = new ImageRepository();
        IUserRepository userRepo = new UserRepository();
        IEventRepository eventRepo = new EventRepository();
        public Event @event { get; set; }
        public User userLogin { get; set; }
        public int back { get; set; }
        public EventReview()
        {
            InitializeComponent();
        }

        private void LinkLbNameEvt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EventContainer.flpContent.Controls.Clear();
            DetailEvent detailEvent = new DetailEvent
            {
                @event = this.@event,
                userLogin = this.userLogin,
                back = this.back,
            };
            EventContainer.flpContent.Controls.Add(detailEvent);
        }

        private void EventReview_Load(object sender, EventArgs e)
        {
            if (frmHomePage.userLogin != null)
            {
                if (frmHomePage.userLogin.RoleId == 1 && frmHomePage.userLogin.Id == @event.IdUser)
                {
                    button1.Visible = true;
                
                }
            }
            lbStartAt.Text = @event.Begin.ToString("HH:mm \ndd/MM/yyyy");
            lbEndAt.Text = @event.End.ToString("HH:mm \ndd/MM/yyyy");
            linkLbNameEvt.Text = @event.Name.ToString();
            string? urlPic = null;
            if (imageRepo.GetImage(@event.Id) != null)
            {
                urlPic = imageRepo.GetImage(@event.Id).Image1.ToString();
            }
            try
            {
                if (userRepo.GetUser(@event.IdUser) != null)
                {
                    lbbyUser.Text = userRepo.GetUser(@event.IdUser).Name;
                }
                if (urlPic != null)
                {
                    picBoxView.Image = System.Drawing.Image.FromFile(@$"{urlPic}");
                }
            }
            catch { }
        }
        private void PicBoxView_Click(object sender, EventArgs e)
        {
            EventContainer.flpContent.Controls.Clear();
            DetailEvent detailEvent = new DetailEvent
            {
                @event = this.@event,
                userLogin = this.userLogin,
                back = this.back,
            };
            EventContainer.flpContent.Controls.Add(detailEvent);
        }

        private void PnContent_MouseClick(object sender, MouseEventArgs e)
        {
            EventContainer.flpContent.Controls.Clear();
            DetailEvent detailEvent = new DetailEvent
            {
                @event = this.@event,
                userLogin = this.userLogin,
                back = this.back,
            };
            EventContainer.flpContent.Controls.Add(detailEvent);
        }

        private void EventReview_MouseClick(object sender, MouseEventArgs e)
        {
            EventContainer.flpContent.Controls.Clear();
            DetailEvent detailEvent = new DetailEvent
            {
                @event = this.@event,
                userLogin = this.userLogin,
                back = this.back,
            };
            EventContainer.flpContent.Controls.Add(detailEvent);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmEditEvent editEvent = new frmEditEvent { @event = @event };
            editEvent.Show();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this Event", "Delete Event", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                eventRepo.DeleteEvent(@event);
            }
        }
    }
}
