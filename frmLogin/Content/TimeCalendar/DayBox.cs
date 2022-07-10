using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FptEventWinApp.Content.TimeCalendar;
using BussinessLayer.Models;
using DataAccess.Repository;

namespace FptEventWinApp
{
    public partial class DayBox : UserControl
    {
        FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
        public Point btnLocationTSC;
        public Point btnLocationCalen;
        public DateTime time { get; set; }
        public Event evt { get; set; }
        IEnumerable<Event> events = null;
        IEventRepository eventRepo = new EventRepository();
        public DayBox()
        {
            InitializeComponent();
            btnLocationTSC = new Point();
           
        }
        private void BtnDay_MouseHover(object sender, EventArgs e)
        {
            //events = eventRepo.GetEvents(time);
            if (events.Count() >0)
            {
                flowLayoutPanel.AutoScroll = true;
                flowLayoutPanel.Size = new System.Drawing.Size(400, 410);
                foreach (Event item in events)
                {
                    EventFastView eventFastView = new EventFastView
                    {
                        @event = item,
                    };
                    flowLayoutPanel.Controls.Add(eventFastView);
                    eventFastView.Dock = DockStyle.Top;
                }
                if ((btnLocationTSC.X >= TimeScheduleContainer.pnContent.Width - btnDay.Width - flowLayoutPanel.Width)
                   && btnLocationTSC.Y >= (TimeScheduleContainer.pnContent.Height - flowLayoutPanel.Height))
                {
                    flowLayoutPanel.Location = new Point(btnLocationTSC.X - flowLayoutPanel.Width,
                                                        TimeScheduleContainer.pnContent.Height - flowLayoutPanel.Height);
                }
                else if (btnLocationTSC.X >= TimeScheduleContainer.pnContent.Width - btnDay.Width - flowLayoutPanel.Width)
                {
                    flowLayoutPanel.Location = new Point(btnLocationTSC.X - flowLayoutPanel.Width,
                                                        btnLocationTSC.Y);
                }
                else if (btnLocationTSC.Y >= (TimeScheduleContainer.pnContent.Height - flowLayoutPanel.Height))
                {
                    flowLayoutPanel.Location = new Point(btnLocationTSC.X + btnDay.Width,
                                                        TimeScheduleContainer.pnContent.Height - flowLayoutPanel.Height);
                }
                else
                {
                    flowLayoutPanel.Location = new Point(btnLocationTSC.X + btnDay.Width, btnLocationTSC.Y);
                }
                if (btnLocationTSC.X == 0 &&
                    btnLocationCalen.X >= 1)
                {
                    flowLayoutPanel.Location = new Point(0, 0);
                }

                TimeScheduleContainer.pnContent.Controls.Add(flowLayoutPanel);
                flowLayoutPanel.BringToFront();
            }
        }
        private void BtnDay_MouseLeave(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
            TimeScheduleContainer.pnContent.Controls.Remove(flowLayoutPanel);
        }

        private void DayBox_Load(object sender, EventArgs e)
        {
            events = eventRepo.GetEvents(time);
            btnDay.Text = time.Day.ToString();
            if (events.Count() > 0)
            {
                label1.Visible = true;
            }
        }
    }
}
