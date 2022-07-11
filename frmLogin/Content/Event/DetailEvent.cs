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
        public Event @event { get; set; }
        public DetailEvent()
        {
            InitializeComponent();
        }

        private void DetailEvent_Load(object sender, EventArgs e)
        {
            label1.Text = @event.Name;
            label2.Text = @event.Begin.ToString("MM/dd/yyyy") + "  -   " + @event.End.ToString("MM/dd/yyyy");
            richTextBox1.Text = @event.Content;
            buttonChange();

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
    }
}
