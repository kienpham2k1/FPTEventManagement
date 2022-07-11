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
    public partial class Comment : UserControl
    {
        public User userLogin { get; set; }
        public Comment()
        {
            InitializeComponent();
        }
    }
}
