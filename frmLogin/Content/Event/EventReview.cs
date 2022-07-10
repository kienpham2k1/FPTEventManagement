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

namespace FptEventWinApp
{
    public partial class EventReview : UserControl
    {
        public Event @event { get; set; }
        public EventReview()
        {
            InitializeComponent();
        }

        private void LinkLbNameEvt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EventContainer.flpContent.Controls.Clear();
            DetailEvent detailEvent = new DetailEvent {
                @event = this.@event,
            };
            EventContainer.flpContent.Controls.Add(detailEvent);
        }
    }
}
