using System;
using System.Drawing;
using System.Windows.Forms;
using FptEventWinApp;

namespace FptEventWinApp
{
    public partial class CalendarCus : UserControl
    {
        public static MonthCalendar calendar = new MonthCalendar();
        public static DateTime firstInCalendar = calendar.GetDisplayRange(false).Start;
        public static DateTime firstInMonth = calendar.GetDisplayRange(true).Start;
        private DateTime lastInMonth;
        public CalendarCus()
        {
            InitializeComponent();
            Display(firstInCalendar);

        }
        private string GetMonth(int m)
        {
            switch (m)
            {
                case 1:
                    return "January";
                case 2:
                    return "February";
                case 3:
                    return "March";
                case 4:
                    return "April";
                case 5:
                    return "May";
                case 6:
                    return "June";
                case 7:
                    return "July";
                case 8:
                    return "August";
                case 9:
                    return "September";
                case 10:
                    return "October";
                case 11:
                    return "November";
                case 12:
                    return "December";
                default:
                    return "";
            }
        }
        private void Display(DateTime date)
        {
            flpDays.Controls.Clear();
            lbMonth.Text = GetMonth(firstInMonth.Month);
            linkLbNow.Text = DateTime.Now.ToString();
            for (int i = 0; i < 42; i++)
            {
                var d = date.AddDays(i);
                if (d.DayOfWeek >= DayOfWeek.Sunday && d.DayOfWeek <= DayOfWeek.Saturday)
                {

                    DayBox dayBox = new DayBox
                    {
                        time = d,
                        small = true,
                    };
                    dayBox.Width = 54;
                    dayBox.Height = 54;
                    dayBox.btnDay.Dock = DockStyle.Fill;
                    if (d.Month > firstInMonth.Month || d.Month < firstInMonth.Month)
                    {
                        dayBox.btnDay.ForeColor = Color.DarkGray;
                    }
                    if (d.Date == DateTime.Now.Date)
                    {
                        dayBox.btnDay.BackColor = Color.CornflowerBlue;
                    }
                    flpDays.Controls.Add(dayBox);
                    dayBox.btnLocationCalen.X = dayBox.Location.X + 1;
                    dayBox.btnLocationCalen.Y = dayBox.Location.Y + 1;
                }
            }

        }
        private void BtnNext_Click(object sender, EventArgs e)
        {
            lastInMonth = calendar.GetDisplayRange(true).End;
            calendar.SetDate(lastInMonth);
            DateTime t = calendar.SelectionRange.Start;
            t -= new TimeSpan((int)t.DayOfWeek, 0, 0, 0);
            firstInMonth = calendar.GetDisplayRange(true).Start;
            firstInMonth = firstInMonth.AddMonths(1);
            calendar.SetDate(firstInMonth);
            Display(t);
            TimeScheduleContainer.DisplayByMonth(t);
        }

        private void BtnPre_Click(object sender, EventArgs e)
        {
            firstInMonth = calendar.GetDisplayRange(true).Start;
            firstInMonth = firstInMonth.AddMonths(-1);
            calendar.SetDate(firstInMonth);
            DateTime t = calendar.SelectionRange.Start;
            t -= new TimeSpan((int)t.DayOfWeek, 0, 0, 0);
            Display(t);
            TimeScheduleContainer.DisplayByMonth(t);
        }
    }
}
