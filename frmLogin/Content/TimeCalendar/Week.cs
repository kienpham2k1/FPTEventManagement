using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FptEventWinApp.Content.TimeCalendar
{
    public partial class Week : UserControl
    {
        DateTime dateTime;// = DateTime.Now;
        public Week()
        {
            InitializeComponent();
            SideBarTime();
        }

        private void Week_Load(object sender, EventArgs e)
        {

        }
        private void SideBarTime()
        {
            for (int i = 5; i < 29; i++)
            {
                dateTime -= new TimeSpan(0, (int)dateTime.Hour, 0, 0);
                Label lbl = new Label();
                lbl.Dock = DockStyle.Top;
                lbl.Size = new Size(185, 100);
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                var h = dateTime.AddHours(i);
                lbl.Text = h.TimeOfDay.ToString();
                flpTimeInDay.Controls.Add(lbl);
            }
        }
        private void DisplayByWeek(DateTime Date)
        {
            //flpContent.Controls.Clear();
            ////DateTime t = monthCalendar1.SelectionRange.Start;
            //Date -= new TimeSpan((int)Date.DayOfWeek, (int)Date.Hour, 0, 0);
            ////Range: Monday to Friday
            //for (int j = 0; j < 24; j++)
            //{
            //    var e = Date.AddHours(j);
            //    for (int i = 0; i < 7; i++)
            //{
            //    var d = Date.AddDays(i);
            //    if (d.DayOfWeek >= DayOfWeek.Sunday && d.DayOfWeek <= DayOfWeek.Saturday)
            //    {
            //        UserControl1 usContrl = new UserControl1();
            //        DateTime w = d.Date;// + e.TimeOfDay;
            //                            //usContrl.label1.Text = d.Day.ToString() + "  " + e.TimeOfDay.ToString();
            //        usContrl.label1.Text = w.ToString();
            //        flpTimeInDay.Controls.Add(usContrl);
            //    }
            //    //}
            //}
        }
    }
}
