﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FptEventWinApp;
using BussinessLayer.Models;

namespace FptEventWinApp
{
    public partial class TimeScheduleContainer : UserControl
    {
        //static public Point btnDayLocation;
        public User userLogin { get; set; }
        public TimeScheduleContainer()
        {
            InitializeComponent();
            DisplayByMonth(CalendarCus.firstInCalendar);
            //TimeScheduleContainer.flpDisplayDays.Controls.Add(new FptEventWinApp.Content.TimeCalendar.Week());
        }
        public static void DisplayByMonth(DateTime Date)
        {
            flpDisplayDays.Controls.Clear();
            for (int i = 0; i < 42; i++)
            {
                var d = Date.AddDays(i);
                if (d.DayOfWeek >= DayOfWeek.Sunday && d.DayOfWeek <= DayOfWeek.Saturday)
                {
                    DayBox dayBox = new DayBox
                    {
                        time = d,
                    }                        ;
                    dayBox.Size = new Size(212, 143);
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
        private void BtnViewByMotnh_Click(object sender, EventArgs e)
        {
            DisplayByMonth(CalendarCus.firstInCalendar);
        }

        private void BtnViewByWeek_Click(object sender, EventArgs e)
        {
            flpDisplayDays.Controls.Clear();
            Week week = new Week(); 
            flpDisplayDays.Controls.Add(week);
        }

        private void TimeScheduleContainer_Load(object sender, EventArgs e)
        {
            if (frmHomePage.userLogin == null || frmHomePage.userLogin.RoleId != 1)
            {
                btnAddNewEvent.Visible = false;
            }
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
