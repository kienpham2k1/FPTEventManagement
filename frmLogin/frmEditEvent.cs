using BussinessLayer.Models;
using DataAccess.Repository;
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
    public partial class frmEditEvent : Form
    {
        IEventRepository eventRepository = new EventRepository();
        IImageRepository imageRepository = new ImageRepository();

        static public bool isOpen = false;
        public Event @event { get; set; }
        public frmEditEvent()
        {
            InitializeComponent();
        }
        public bool getCheck()
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Name is empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return false;
            }

            if (DateTime.Compare(@event.Create, dateTimePicker2.Value) > 0)
            {
                MessageBox.Show("Date Begin less than Date Create", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePicker2.Focus();
                return false;
            }
            if (DateTime.Compare(dateTimePicker2.Value, dateTimePicker3.Value) > 0)
            {
                MessageBox.Show("Date End less than Date Begin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePicker3.Focus();
                return false;
            }
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Choice image please", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pictureBox1.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(richTextBox1.Text))
            {
                MessageBox.Show("Content is empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                richTextBox1.Focus();
                return false;
            }

            return true;
        }
        public bool checkDateTime(Event e)
        {
            List<Event> evn = (List<Event>)eventRepository.GetEvents();
            List<Event> checkdate = new List<Event>();
            List<Event> checktime = new List<Event>();

            foreach (Event ee in evn)
            {
                if (ee.Id != e.Id)
                {
                    checkdate.Add(ee);
                }
            }
            foreach (Event ee in checkdate)
            {
                if ((DateTime.Compare(DateTime.Parse(dateTimePicker2.Value.ToString("MM/dd/yyyy")), DateTime.Parse(ee.End.ToString("MM/dd/yyyy"))) == 0 && DateTime.Compare(DateTime.Parse(dateTimePicker2.Value.ToString("MM/dd/yyyy")), DateTime.Parse(ee.Begin.ToString("MM/dd/yyyy"))) == 0) || (DateTime.Compare(DateTime.Parse(dateTimePicker3.Value.ToString("MM/dd/yyyy")), DateTime.Parse(ee.End.ToString("MM/dd/yyyy"))) == 0 && DateTime.Compare(DateTime.Parse(dateTimePicker3.Value.ToString("MM/dd/yyyy")), DateTime.Parse(ee.Begin.ToString("MM/dd/yyyy"))) == 0))
                {
                    checktime.Add(ee);
                }

            }
            foreach (Event en in checktime)
            {
                if ((DateTime.Compare(dateTimePicker2.Value, en.End) <= 0 && DateTime.Compare(dateTimePicker2.Value, en.Begin) >= 0) == true)
                {
                    MessageBox.Show(" date and time coincide with the previous created event", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dateTimePicker2.Focus();
                    return false;
                }
                if ((DateTime.Compare(dateTimePicker3.Value, en.End) <= 0 && DateTime.Compare(dateTimePicker3.Value, en.Begin) >= 0) == true)
                {
                    MessageBox.Show(" date1 and time coincide with the previous created event", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dateTimePicker3.Focus();
                    return false;
                }

            }
            return true;
        }

        private void frmEditEvent_Load(object sender, EventArgs e)
        {
            var ev = eventRepository.GetEventById(@event.Id);
            var pic = imageRepository.GetImage(ev.Id);
            string pathString = System.IO.Path.Combine(pic.Image1);

            textBox1.Text = ev.Name;
            dateTimePicker2.Value = ev.Begin;
            dateTimePicker3.Value = ev.End;
            pictureBox1.Image = System.Drawing.Image.FromFile(pathString);
            richTextBox1.Text = ev.Content;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (getCheck() && checkDateTime(eventRepository.GetEventById(@event.Id)))
            {
                try
                {
                    var ev = new Event
                    {
                        Id = @event.Id,
                        Name = textBox1.Text,
                        IdUser = frmHomePage.userLogin.Id,
                        Create = @event.Create,
                        Begin = dateTimePicker2.Value,
                        Like = @event.Like,
                        Follow = @event.Follow,
                        End = dateTimePicker3.Value,
                        Content = richTextBox1.Text,
                    };
                    eventRepository.Update(ev);
                    string fname = ev.Id + ".jpg";
                    string folder = "D:\\Files";
                    string pathString = System.IO.Path.Combine(folder, fname);
                    if (!pathString.Equals(imageRepository.GetImage(ev.Id).Image1))
                    {
                        System.Drawing.Image a = pictureBox1.Image;
                        a.Save(pathString);
                    }
                    var pic = new BussinessLayer.Models.Image
                    {
                        Id = imageRepository.GetImage(ev.Id).Id,
                        IdEvent = ev.Id,
                        Image1 = pathString,
                    };
                    imageRepository.Update(pic);

                    MessageBox.Show("suc");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fail");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                PictureBox p = sender as PictureBox;
                if (p != null)
                {
                    dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        p.Image = System.Drawing.Image.FromFile(dialog.FileName);
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
