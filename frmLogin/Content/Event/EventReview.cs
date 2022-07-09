using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FptEventWinApp.Content.Event;

namespace FptEventWinApp
{
    public partial class EventReview : UserControl
    {
        public EventReview()
        {
            InitializeComponent();
        }

        private void LinkLbNameEvt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EventContainer.flpContent.Controls.Clear();
            EventContainer.flpContent.Controls.Add(new DetailEvent());
        }
    }
}
