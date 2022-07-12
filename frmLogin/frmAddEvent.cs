﻿using Bussiness_layer;
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
    public partial class frmAddEvent : Form
    {
        IEventRepository eventRepository = new EventRepository();
        IImageRepository imageRepository = new ImageRepository();
        DateTime now =DateTime.Parse( DateTime.Now.ToString("MM/dd/yyyy"));
        public frmAddEvent()
        {
            InitializeComponent();
        }

        public bool getCheck()
        {
            if (String.IsNullOrEmpty(textBox1.Text)){
                MessageBox.Show("Name is empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return false;
            }if(DateTime.Compare(dateTimePicker1.Value,now) < 0)
            {
                MessageBox.Show("Date Create Less than to day", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePicker1.Focus();
                return false;
            }if(DateTime.Compare(dateTimePicker1.Value,dateTimePicker2.Value) > 0)
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
            }if(pictureBox1.Image == null)
            {
                MessageBox.Show("Choice image please", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pictureBox1.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(richTextBox1.Text)) {
                MessageBox.Show("Content is empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                richTextBox1.Focus();
                return false;
            }
            return true;
        }

        private void frmAddEvent_Load(object sender, EventArgs e)
        {

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
                        p.Image = Image.FromFile(dialog.FileName);
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (getCheck())
            {
                try
                {
                    

                    var ev = new Event
                    {
                        Name = textBox1.Text,
                        IdUser = 8,
                        Create = dateTimePicker1.Value,
                        Begin = dateTimePicker2.Value,
                        End = dateTimePicker3.Value,
                        Status = true,
                        IdCategory = 1,
                        Content = richTextBox1.Text,
                    };
                    eventRepository.SaveEvent(ev);
                    string fname = eventRepository.GetNewIdEventCreate() + ".jpg";
                    string folder = "D:\\Files";
                    string pathString = System.IO.Path.Combine(folder, fname);
                    Image a = pictureBox1.Image;
                    a.Save(pathString);
                    var pic = new Images
                    {
                        IdEvent = eventRepository.GetNewIdEventCreate(),
                        Image1 = pathString,
                    };
                    imageRepository.SaveImage(pic);

                    MessageBox.Show("suc");
                }catch (Exception ex)
                {
                    MessageBox.Show("Fail");

                }
            }
           
}

}
}
