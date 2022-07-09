using System;
using System.Collections.Generic;

#nullable disable

namespace BussinessLayer.Models
{
    public partial class Video
    {
        public int Id { get; set; }
        public int IdEvent { get; set; }
        public string Video1 { get; set; }

        public virtual Event IdEventNavigation { get; set; }
    }
}
