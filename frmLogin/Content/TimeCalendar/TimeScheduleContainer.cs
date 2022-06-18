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
    public partial class TimeScheduleContainer : UserControl
    {
        //static public Point btnDayLocation;
        public TimeScheduleContainer()
        {
            InitializeComponent();
            Display(CalendarCus.firstInCalendar);
        }
        public static void Display(DateTime date)
        {
              flpDisplayDays.Controls.Clear();
            for (int i = 0; i < 42; i++)
            {
                var d = date.AddDays(i);
                if (d.DayOfWeek >= DayOfWeek.Sunday && d.DayOfWeek <= DayOfWeek.Saturday)
                {
                    DayBox dayBox = new DayBox();
                    dayBox.Width = 212;
                    dayBox.Height = 143;
                    dayBox.btnDay.Dock = DockStyle.Fill;
                    dayBox.btnDay.Text = d.Day.ToString();
                    if (d.Month > CalendarCus.firstInMonth.Month || d.Month < CalendarCus.firstInMonth.Month)
                    {
                        dayBox.btnDay.ForeColor = Color.DarkGray;
                    }
                    if (d.Date == DateTime.Now.Date)
                    {
                        dayBox.btnDay.BackColor = Color.CornflowerBlue;
                    }
                    flpDisplayDays.Controls.Add(dayBox);
                    dayBox.btnLocationTSC = dayBox.Location;
                }
            }
        }
    }
}
