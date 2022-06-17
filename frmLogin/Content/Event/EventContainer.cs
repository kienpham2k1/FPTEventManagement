using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FptEventWinApp
{
    public partial class EventContainer : UserControl
    {
        public EventContainer()
        {
            InitializeComponent();
        }
        private void ListEvent_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                EventReview eventPanel = new EventReview();
                eventPanel.Dock = System.Windows.Forms.DockStyle.Top;
                eventPanel.SendToBack();
                flpContent.Controls.Add(eventPanel);
                int left = (flpContent.Width - eventPanel.Width) / 2 - 15;
                eventPanel.Margin = new Padding(left, left, left, 0);
            }
        }
    }
}
