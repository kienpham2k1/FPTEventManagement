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
    public partial class DetailEvent : UserControl
    {
        IEventRepository eventRepo = new EventRepository();
        IFollowRepository followRepo = new FollowRepository();
        IImageRepository imageRepo = new ImageRepository();
        public Event @event { get; set; }
        public User userLogin { get; set; }
        private int count = 0;
        public DetailEvent()
        {
            InitializeComponent();
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(256, 256);

        }

        private void DetailEvent_Load(object sender, EventArgs e)
        {
            label1.Text = @event.Name;
            label2.Text = @event.Begin.ToString("MM/dd/yyyy") + "  -   " + @event.End.ToString("MM/dd/yyyy");
            string content = @event.Content.ToString();
            label3.Text = $@"{content}";
            buttonChange();
            this.groupBox1.Location = new Point(57, this.label3.Location.Y + this.label3.Size.Height);
            var listImage = imageRepo.GetImages(@event.Id);
            if (listImage != null)
            {
                foreach (BussinessLayer.Models.Image img in listImage)
                {
                    imageList1.Images.Add(System.Drawing.Image.FromFile(@$"{img.Image1}"));
                }
                pictureBox1.Image = imageList1.Images[0];
                if (listImage.Count() >1)
                {
                    button4.Visible = true;
                    button5.Visible = true;
                }
            }
        }
        private void buttonChange()
        {
            if (followRepo.GetFollow(1, @event.Id) != null)
            {
                button2.BackColor = Color.Blue;
                button2.ForeColor = Color.White;
            }
            else
            {
                button2.BackColor = SystemColors.ControlLightLight;
                button2.ForeColor = SystemColors.ControlText;
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            eventRepo.Follow(1, @event.Id);
            buttonChange();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Text = "Video";
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Text = "Image";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[count];
            count++;
            if (count >= imageList1.Images.Count) count = 0;
        }
    }
}
