using System;
using System.Collections.Generic;

#nullable disable

namespace BussinessLayer.Models
{
    public partial class Image
    {
        public int Id { get; set; }
        public int IdEvent { get; set; }
        public string Image1 { get; set; }

        public virtual Event IdEventNavigation { get; set; }
    }
}
