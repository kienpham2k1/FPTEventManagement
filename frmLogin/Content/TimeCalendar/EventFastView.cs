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
using DataAccess.Repository;

namespace FptEventWinApp
{
    public partial class EventFastView : UserControl
    {
        IImageRepository imageRepo = new ImageRepository();
        public Event @event { get; set; }
        public User userLogin { get; set; }
        public EventFastView()
        {
            InitializeComponent();
        }

        private void EventFastView_Load(object sender, EventArgs e)
        {
            lbName.Text = @event.Name;
            lbShortDiscrip.Text = @event.Content;
            string? urlPic = null;
            if (imageRepo.GetImage(@event.Id) != null)
            {
                urlPic = imageRepo.GetImage(@event.Id).Image1.ToString();
            }
            try
            {
                if (urlPic != null)
                {
                    Image.Image = System.Drawing.Image.FromFile(@$"{urlPic}");
                }
            }
            catch { }
        }
    }
}
