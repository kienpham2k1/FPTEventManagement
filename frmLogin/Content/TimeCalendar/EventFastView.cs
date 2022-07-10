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
    public partial class EventFastView : UserControl
    {
        public Event @event { get; set; }
        public EventFastView()
        {
            InitializeComponent();
        }

        private void EventFastView_Load(object sender, EventArgs e)
        {
            lbName.Text = @event.Name;
            lbShortDiscrip.Text = @event.Content;
        }
    }
}
