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
        public EventContainer()
        {
            InitializeComponent();
        }
        private void ListEvent_Load(object sender, EventArgs e)
        {
            var events = eventRepo.GetEvents().ToList();
            foreach(Event evt in events)
            {
                string urlPic = imageRepo.GetImage(evt.Id).Image1.ToString();
                EventReview eventPanel = new EventReview();
                eventPanel.lbStartAt.Text = evt.Begin.ToString();
                eventPanel.lbEndAt.Text = evt.End.ToString();
                eventPanel.linkLbNameEvt.Text = evt.Name.ToString();
                
                eventPanel.picBoxView.Image = System.Drawing.Image.FromFile(@$"{urlPic}");
                eventPanel.Dock = DockStyle.Top;
                eventPanel.SendToBack();
                flpContent.Controls.Add(eventPanel);
                int left = (flpContent.Width - eventPanel.Width) / 2 - 15;
                eventPanel.Margin = new Padding(left, left, left, 0);
            }
        }
    }
}
