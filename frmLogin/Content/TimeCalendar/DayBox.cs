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

namespace FptEventWinApp
{
    public partial class DayBox : UserControl
    {
        Button btn = new Button();

        public DayBox()
        {
            InitializeComponent();
            btnLocation = new Point();
        }
        public Point btnLocation;
        private void BtnDay_MouseHover(object sender, EventArgs e)
        {
            btn.Height = 500;
            btn.Width = 100;
            btn.Text = btnLocation.ToString();
            btn.Location = new Point(btnLocation.X + btnDay.Width, btnLocation.Y);
            if ((btnLocation.X >= TimeScheduleContainer.pnContent.Width - btnDay.Width)
               && btnLocation.Y >= (TimeScheduleContainer.pnContent.Height - btn.Height))
            {
                btn.Location = new Point(btnLocation.X - btn.Width, TimeScheduleContainer.pnContent.Height - btn.Height);
            }
            else if (btnLocation.X >= TimeScheduleContainer.pnContent.Width - btnDay.Width)
            {
                btn.Location = new Point(btnLocation.X - btn.Width, btnLocation.Y);
            }
            else if (btnLocation.Y >= (TimeScheduleContainer.pnContent.Height - btn.Height))
            {
                btn.Location = new Point(btnLocation.X + btnDay.Width, TimeScheduleContainer.pnContent.Height - btn.Height);
            }

            TimeScheduleContainer.pnContent.Controls.Add(btn);
            btn.BringToFront();
        }
        private void BtnDay_MouseLeave(object sender, EventArgs e)
        {
            TimeScheduleContainer.pnContent.Controls.Remove(btn);
        }
    }
}
