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
        public Event @event { get; set; }
        public User userLogin { get; set; }
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
            };
            EventContainer.flpContent.Controls.Add(detailEvent);
        }

        private void EventReview_Load(object sender, EventArgs e)
        {
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
                lbbyUser.Text = userRepo.GetUser(@event.IdUser).Name;
                if (urlPic != null)
                {
                    picBoxView.Image = System.Drawing.Image.FromFile(@$"{urlPic}");
                }
            }
            catch { }
        }
    }
}
