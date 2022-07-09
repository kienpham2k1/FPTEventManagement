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
        public EventContainer()
        {
            InitializeComponent();
        }
        private void ListEvent_Load(object sender, EventArgs e)
        {
            var events = eventRepo.GetEvents().ToList();
            foreach(Event evt in events)
            {
                EventReview eventPanel = new EventReview();
                eventPanel.lbStartAt.Text = evt.Begin.ToString();
                eventPanel.Dock = System.Windows.Forms.DockStyle.Top;
                eventPanel.SendToBack();
                flpContent.Controls.Add(eventPanel);
                int left = (flpContent.Width - eventPanel.Width) / 2 - 15;
                eventPanel.Margin = new Padding(left, left, left, 0);
            }
        }
    }
}
