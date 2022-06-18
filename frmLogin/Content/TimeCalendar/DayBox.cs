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

namespace FptEventWinApp
{
    public partial class DayBox : UserControl
    {
        FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
        public Point btnLocationTSC;
        public Point btnLocationCalen;
        public DayBox()
        {
            InitializeComponent();
            btnLocationTSC = new Point();
        }
        private void BtnDay_MouseHover(object sender, EventArgs e)
        {
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.Size = new System.Drawing.Size(400, 410);
            for (int i = 0; i < 5; i++)
            {
                EventFastView eventFastView = new EventFastView();
                flowLayoutPanel.Controls.Add(eventFastView);
                //eventFastView.Dock = DockStyle.Top; 
                eventFastView.lbName.Text = btnLocationCalen.ToString() + "\n" + btnLocationTSC.ToString();
            }
            //flowLayoutPanel.Location = new Point(0,0);
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
        private void BtnDay_MouseLeave(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
            TimeScheduleContainer.pnContent.Controls.Remove(flowLayoutPanel);
        }
    }
}
