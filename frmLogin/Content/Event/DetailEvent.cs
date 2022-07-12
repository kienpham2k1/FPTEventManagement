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
        ILikeRepository likeRepo = new LikeRepository();
        IImageRepository imageRepo = new ImageRepository();
        ICommentRepository cmtRepo = new CommentRepository();
        public Event @event { get; set; }
        public User userLogin { get; set; }
        public int back { get; set; }

        private int count = -1;
        public DetailEvent()
        {
            InitializeComponent();
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(256, 256);

        }

        private void DetailEvent_Load(object sender, EventArgs e)
        {
            buttonFollowChange();
            buttonLikeChange();

            label1.Text = @event.Name;
            label2.Text = @event.Begin.ToString("HH:mm  dd/MM/yyyy") + "  -   " + @event.End.ToString("HH:mm  dd/MM/yyyy");
            label3.Text = $@"{@event.Content}";

            this.groupBox1.Location = new Point(57, this.label3.Location.Y + this.label3.Size.Height + 20);
            this.flowLayoutPanel2.Location = new Point(105, this.label3.Location.Y + this.label3.Size.Height + 30 + this.groupBox1.Height);
            if (userLogin != null)
            {
                AddCommet addCmt = new AddCommet
                {
                    idEvent = @event.Id,
                    userLogin = userLogin
                };
                flowLayoutPanel2.Controls.Add(addCmt);
            }
            var listImage = imageRepo.GetImages(@event.Id);
            if (listImage != null)
            {
                foreach (BussinessLayer.Models.Image img in listImage)
                {
                    imageList1.Images.Add(System.Drawing.Image.FromFile(@$"{img.Image1}"));
                }
                pictureBox1.Image = imageList1.Images[0];
                if (listImage.Count() > 1)
                {
                    button4.Visible = true;
                    button5.Visible = true;
                }
            }

            IEnumerable<Comment> listComment = cmtRepo.GetComments(@event.Id);
            if (listComment != null)
            {
                foreach (BussinessLayer.Models.Comment cmt in listComment)
                {
                    CommentUSC comt = new CommentUSC { cmt = cmt };
                    comt.Dock = DockStyle.Top;
                    comt.BringToFront();
                    flowLayoutPanel2.Controls.Add(comt);
                }
            }
            this.flowLayoutPanel2.Size = new Size(this.groupBox1.Width, this.groupBox1.Height);
        }
        private void buttonFollowChange()
        {
            if (userLogin != null)
            {
                if (followRepo.GetFollow(userLogin.Id, @event.Id) != null)
                {
                    this.button2.Image = global::FptEventWinApp.Properties.Resources.following_free_icon_font;
                }
                else
                {
                    this.button2.Image = global::FptEventWinApp.Properties.Resources.following__2_;
                }
            }
        }
        private void buttonLikeChange()
        {
            if (userLogin != null)
            {
                if (likeRepo.GetLike(userLogin.Id, @event.Id) != null)
                {
                    this.button1.Image = global::FptEventWinApp.Properties.Resources.heart_free_icon_font;
                }
                else
                {
                    this.button1.Image = global::FptEventWinApp.Properties.Resources.heart__1_;
                }
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (userLogin == null)
            {
                Logintest frmLogin = new Logintest();
                frmLogin.ShowDialog();
            }
            else
            {
                eventRepo.Like(userLogin.Id, @event.Id);
                buttonLikeChange();
            }
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
            count++;
            if (count >= imageList1.Images.Count) count = 0;
            pictureBox1.Image = imageList1.Images[count];

        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            if (userLogin == null)
            {
                Logintest frmLogin = new Logintest();
                frmLogin.ShowDialog();
            }
            else
            {
                eventRepo.Follow(userLogin.Id, @event.Id);
                buttonFollowChange();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (back == 0)
            {
                frmHomePage.loadEvent();
            }
            else if (back == 2)
            {
                frmHomePage.loadCalendar();
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (count <= 0) count = imageList1.Images.Count;
            count--;
            pictureBox1.Image = imageList1.Images[count];
        }
    }
}
